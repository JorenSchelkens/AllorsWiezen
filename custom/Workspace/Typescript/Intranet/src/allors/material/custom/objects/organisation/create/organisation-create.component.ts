import { Component, OnDestroy, OnInit, Self, Inject } from '@angular/core';
import { Location } from '@angular/common';
import { ActivatedRoute } from '@angular/router';

import { BehaviorSubject, Subscription, combineLatest } from 'rxjs';

import { ErrorService, Saved, ContextService, MetaService } from '../../../../../angular';
import { Locale, Organisation } from '../../../../../domain';
import { PullRequest } from '../../../../../framework';
import { Meta } from '../../../../../meta';
import { StateService } from '../../../services/state';
import { Fetcher } from '../../Fetcher';
import { AllorsMaterialDialogService } from '../../../../base/services/dialog';
import { switchMap } from 'rxjs/operators';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material';
import { ObjectData, CreateData } from 'src/allors/material/base/services/object';

@Component({
  templateUrl: './organisation-create.component.html',
  providers: [ContextService]
})
export class OrganisationCreateComponent implements OnInit, OnDestroy {

  public m: Meta;

  public title = 'Add Organisation';

  public organisation: Organisation;
  public locales: Locale[];

  private refresh$: BehaviorSubject<Date>;
  private subscription: Subscription;

  private fetcher: Fetcher;

  constructor(
    @Self() private allors: ContextService,
    @Inject(MAT_DIALOG_DATA) public data: CreateData,
    public dialogRef: MatDialogRef<OrganisationCreateComponent>,
    public metaService: MetaService,
    public location: Location,
    private errorService: ErrorService,
    private route: ActivatedRoute,
    private stateService: StateService) {

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
      }, this.errorService.handler);
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
        (error: Error) => {
          this.errorService.handle(error);
        });
  }
}
