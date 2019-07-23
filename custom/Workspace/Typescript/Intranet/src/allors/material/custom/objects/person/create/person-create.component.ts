import { Component, OnDestroy, OnInit, Self, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { BehaviorSubject, Subscription, combineLatest } from 'rxjs';
import { switchMap } from 'rxjs/operators';

import { Saved, ContextService, NavigationService, MetaService, TestScope } from '../../../../../angular';
import { Person, } from '../../../../../domain';
import { PullRequest } from '../../../../../framework';
import { Meta } from '../../../../../meta';
import { ObjectData, SaveService } from '../../../../../material';

@Component({
  templateUrl: './person-create.component.html',
  providers: [ContextService]
})
export class PersonCreateComponent extends TestScope implements OnInit, OnDestroy {

  readonly m: Meta;

  public title = 'Add Person';

  person: Person;

  private subscription: Subscription;
  private readonly refresh$: BehaviorSubject<Date>;

  constructor(
    @Self() public allors: ContextService,
    @Inject(MAT_DIALOG_DATA) public data: ObjectData,
    public dialogRef: MatDialogRef<PersonCreateComponent>,
    public metaService: MetaService,
    public navigationService: NavigationService,
    public location: Location,
    private route: ActivatedRoute,
    private saveService: SaveService) {

    super();

    this.m = this.metaService.m;
    this.refresh$ = new BehaviorSubject<Date>(undefined);
  }

  public ngOnInit(): void {

    const { m, pull, x } = this.metaService;

    this.subscription = combineLatest(
      this.route.url,
      this.refresh$
    )
      .pipe(
        switchMap(([urlSegments, date]) => {

          const pulls = [
          ];

          return this.allors.context
            .load('Pull', new PullRequest({ pulls }));
        })
      )
      .subscribe((loaded) => {
        this.allors.context.reset();
        this.person = this.allors.context.create('Person') as Person;
      });
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
        this.saveService.errorHandler);
  }
}
