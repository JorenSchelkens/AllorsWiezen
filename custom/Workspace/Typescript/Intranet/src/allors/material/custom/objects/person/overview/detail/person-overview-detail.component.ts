import { Component, OnDestroy, OnInit, Self } from '@angular/core';
import { Location } from '@angular/common';
import { Subscription } from 'rxjs';
import { switchMap, filter } from 'rxjs/operators';

import { ErrorService, ContextService, NavigationService, PanelService, RefreshService, MetaService } from '../../../../../../angular';
import { Locale, Person } from '../../../../../../domain';
import { PullRequest } from '../../../../../../framework';
import { Meta } from '../../../../../../meta';
import { StateService } from '../../../../services/state';
import { Fetcher } from '../../../Fetcher';

@Component({
  // tslint:disable-next-line:component-selector
  selector: 'person-overview-detail',
  templateUrl: './person-overview-detail.component.html',
  providers: [PanelService, ContextService]
})
export class PersonOverviewDetailComponent implements OnInit, OnDestroy {

  readonly m: Meta;

  person: Person;
  locales: Locale[];

  private subscription: Subscription;

  constructor(
    @Self() public allors: ContextService,
    @Self() public panel: PanelService,
    private metaService: MetaService,
    public refreshService: RefreshService,
    public navigationService: NavigationService,
    public location: Location,
    private errorService: ErrorService,
    private stateService: StateService) {

    this.m = this.metaService.m;

    panel.name = 'detail';
    panel.title = 'Personal Data';
    panel.icon = 'person';
    panel.expandable = true;

    // Collapsed
    const pullName = `${this.panel.name}_${this.m.Person.name}`;

    panel.onPull = (pulls) => {

      this.person = undefined;

      if (this.panel.isCollapsed) {
        const { pull, x } = this.metaService;
        const id = this.panel.manager.id;

        pulls.push(
          pull.Person({
            name: pullName,
            object: id,
            include: {
            }
          })
        );
      }
    };

    panel.onPulled = (loaded) => {
      if (this.panel.isCollapsed) {
        this.person = loaded.objects[pullName] as Person;
      }
    };
  }

  public ngOnInit(): void {

    // Expanded
    this.subscription = this.panel.manager.on$
      .pipe(
        filter(() => {
          return this.panel.isExpanded;
        }),
        switchMap(() => {

          this.person = undefined;

          const { m, pull, x } = this.metaService;
          const fetcher = new Fetcher(this.stateService, this.metaService.pull);
          const id = this.panel.manager.id;

          const pulls = [
            fetcher.locales,
            pull.Person({
              object: id,
              include: {
                Picture: x,
              }
            }),
          ];

          return this.allors.context.load('Pull', new PullRequest({ pulls }));
        })
      )
      .subscribe((loaded) => {
        this.allors.context.reset();

        this.person = loaded.objects.Person as Person;
        this.locales = loaded.collections.AdditionalLocales as Locale[];
      }, this.errorService.handler);

  }

  public ngOnDestroy(): void {
    if (this.subscription) {
      this.subscription.unsubscribe();
    }
  }

  public save(): void {

    this.allors.context.save()
      .subscribe(() => {
        this.location.back();
      },
        (error: Error) => {
          this.errorService.handle(error);
        });
  }
}
