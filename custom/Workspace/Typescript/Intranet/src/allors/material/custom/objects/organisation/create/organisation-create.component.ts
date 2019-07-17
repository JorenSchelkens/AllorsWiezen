import { Component, OnDestroy, OnInit, Self, Inject } from '@angular/core';
import { Location } from '@angular/common';
import { ActivatedRoute } from '@angular/router';

import { BehaviorSubject, Subscription, combineLatest } from 'rxjs';

import { Saved, ContextService, MetaService, TestScope } from '../../../../../angular';
import { Locale, Organisation } from '../../../../../domain';
import { PullRequest } from '../../../../../framework';
import { Meta } from '../../../../../meta';
import { StateService } from '../../../services/state';
import { Fetcher } from '../../Fetcher';
import { switchMap } from 'rxjs/operators';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material';
import { SaveService, ObjectData } from '../../../../../material';

@Component({
  templateUrl: './organisation-create.component.html',
  providers: [ContextService]
})
export class OrganisationCreateComponent extends TestScope implements OnInit, OnDestroy {

  public m: Meta;

  public title = 'Add Organisation';

  public organisation: Organisation;
  public locales: Locale[];

  private refresh$: BehaviorSubject<Date>;
  private subscription: Subscription;

  private fetcher: Fetcher;

  constructor(
    @Self() private allors: ContextService,
    @Inject(MAT_DIALOG_DATA) public data: ObjectData,
    public dialogRef: MatDialogRef<OrganisationCreateComponent>,
    public metaService: MetaService,
    public location: Location,
    private saveService: SaveService,
    private route: ActivatedRoute,
    private stateService: StateService) {

    super();

    this.m = this.metaService.m;
    this.refresh$ = new BehaviorSubject<Date>(undefined);
    this.fetcher = new Fetcher(this.stateService, this.metaService.pull);
  }

  public ngOnInit(): void {

    this.subscription = combineLatest(this.route.url, this.refresh$, this.stateService.organisationId$)
      .pipe(
        switchMap(([urlSegments, date, organisationId]) => {

          const pulls = [
            this.fetcher.locales,
          ];

          return this.allors.context
            .load('Pull', new PullRequest({ pulls }));
        }),
      )
      .subscribe((loaded) => {
        this.locales = loaded.collections.AdditionalLocales as Locale[];
        this.organisation = this.allors.context.create('Organisation') as Organisation;
      });
  }

  public ngOnDestroy(): void {
    if (this.subscription) {
      this.subscription.unsubscribe();
    }
  }

  public save(): void {

    // Postprocessing

    // Save
    this.allors.context
      .save()
      .subscribe((saved: Saved) => {
        const data: ObjectData = {
          id: this.organisation.id,
          objectType: this.organisation.objectType,
        };

        this.dialogRef.close(data);
      },
        this.saveService.errorHandler);
  }
}
