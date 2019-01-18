import { Component, OnDestroy, OnInit, Self, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material';
import { Subscription, combineLatest } from 'rxjs';
import { switchMap, map } from 'rxjs/operators';

import { PullRequest } from '../../../../../framework';
import { Meta } from '../../../../../meta';
import { Employment, Organisation } from '../../../../../domain';
import { ErrorService, Saved, ContextService, MetaService, RefreshService } from '../../../../../angular';
import { CreateData, EditData, ObjectData } from '../../../../base/services/object';
import { StateService } from '../../../services/state';

@Component({
  templateUrl: './employment-edit.component.html',
  providers: [ContextService]
})
export class EmploymentEditComponent implements OnInit, OnDestroy {

  public m: Meta;
  public title = 'Edit Employment';

  public create: boolean;
  public container: Organisation;
  public object: Employment;

  private subscription: Subscription;

  constructor(
    @Self() public allors: ContextService,
    @Inject(MAT_DIALOG_DATA) public data: CreateData & EditData,
    public stateService: StateService,
    public dialogRef: MatDialogRef<EmploymentEditComponent>,
    public metaService: MetaService,
    public refreshService: RefreshService,
    private errorService: ErrorService) {

    this.m = this.metaService.m;
  }

  public ngOnInit(): void {

    const { m, pull, x } = this.metaService;

    this.subscription = combineLatest(this.refreshService.refresh$)
      .pipe(
        switchMap(([]) => {

          const create = (this.data as EditData).id === undefined;
          const { id, associationId } = this.data;

          const pulls = [
            pull.Employment(
              {
                object: id,
                include: {
                  Employer: x,
                  Employee: x,
                }
              }),
          ];

          if (create && associationId) {
            pulls.push(
              pull.Organisation(
                {
                  object: associationId,
                }),
            );
          }

          return this.allors.context.load('Pull', new PullRequest({ pulls }))
            .pipe(
              map((loaded) => ({ loaded, create }))
            );
        })
      )
      .subscribe(({ loaded, create }) => {
        this.allors.context.reset();

        this.container = loaded.objects.Organisation as Organisation;
        this.object = loaded.objects.Employment as Employment;

        if (create) {
          this.title = 'Add Employement';
          this.object = this.allors.context.create('Employment') as Employment;
          this.object.Employer = this.container;
        }

      }, this.errorService.handler);
  }

  public ngOnDestroy(): void {
    if (this.subscription) {
      this.subscription.unsubscribe();
    }
  }

  public save(): void {

    this.allors.context.save()
      .subscribe((saved: Saved) => {
        const data: ObjectData = {
          id: this.object.id,
          objectType: this.object.objectType,
        };

        this.dialogRef.close(data);
      },
        (error: Error) => {
          this.errorService.handle(error);
        });
  }
}
