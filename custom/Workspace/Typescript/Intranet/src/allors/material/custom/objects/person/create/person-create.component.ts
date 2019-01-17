import { Component, OnDestroy, OnInit, Self, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { BehaviorSubject, Subscription, combineLatest } from 'rxjs';
import { switchMap } from 'rxjs/operators';

import { ErrorService, Saved, ContextService, NavigationService, MetaService } from '../../../../../angular';
import { Enumeration, Locale, Organisation, Person, } from '../../../../../domain';
import { PullRequest } from '../../../../../framework';
import { Meta } from '../../../../../meta';
import { StateService } from '../../../services/state';
import { Fetcher } from '../../Fetcher';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { ObjectData, CreateData } from 'src/allors/material/base/services/object';

@Component({
  templateUrl: './person-create.component.html',
  providers: [ContextService]
})
export class PersonCreateComponent implements OnInit, OnDestroy {

  readonly m: Meta;

  public title = 'Add Person';

  person: Person;

  private subscription: Subscription;
  private readonly refresh$: BehaviorSubject<Date>;
  private readonly fetcher: Fetcher;

  constructor(
    @Self() public allors: ContextService,
    @Inject(MAT_DIALOG_DATA) public data: CreateData,
    public dialogRef: MatDialogRef<PersonCreateComponent>,
    public metaService: MetaService,
    public navigationService: NavigationService,
    public location: Location,
    private errorService: ErrorService,
    private route: ActivatedRoute,
    private stateService: StateService) {

    this.m = this.metaService.m;
    this.refresh$ = new BehaviorSubject<Date>(undefined);
    this.fetcher = new Fetcher(this.stateService, this.metaService.pull);
  }

  public ngOnInit(): void {

    const { m, pull, x } = this.metaService;

    this.subscription = combineLatest(
      this.route.url,
      this.refresh$,
      this.stateService.organisationId$
    )
      .pipe(
        switchMap(([urlSegments, date, organisationId]) => {

          const pulls = [
            this.fetcher.locales,
          ];

          return this.allors.context
            .load('Pull', new PullRequest({ pulls }));
        })
      )
      .subscribe((loaded) => {
        this.allors.context.reset();

        this.person = this.allors.context.create('Person') as Person;

      }, this.errorService.handler);
  }

  public ngOnDestroy(): void {
    if (this.subscription) {
      this.subscription.unsubscribe();
    }
  }

  public save(): void {
    this.allors.context
      .save()
      .subscribe((saved: Saved) => {
        const data: ObjectData = {
          id: this.person.id,
          objectType: this.person.objectType,
        };

        this.dialogRef.close(data);
      },
        (error: Error) => {
          this.errorService.handle(error);
        });
  }
}
