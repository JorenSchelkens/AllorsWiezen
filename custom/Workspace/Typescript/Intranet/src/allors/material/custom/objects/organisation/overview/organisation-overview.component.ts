import { Component, OnDestroy, Self, Injector, AfterViewInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { ActivatedRoute } from '@angular/router';
import { Subscription, combineLatest } from 'rxjs';
import { switchMap } from 'rxjs/operators';

import {  NavigationService, NavigationActivatedRoute, PanelManagerService, RefreshService, MetaService, ContextService, TestScope } from '../../../../../angular';
import { Organisation } from '../../../../../domain';
import { PullRequest } from '../../../../../framework';

@Component({
  templateUrl: './organisation-overview.component.html',
  providers: [PanelManagerService, ContextService]
})
export class OrganisationOverviewComponent extends TestScope implements AfterViewInit, OnDestroy {

  title = 'Organisation';

  organisation: Organisation;

  subscription: Subscription;

  constructor(
    @Self() public panelManager: PanelManagerService,
    public metaService: MetaService,
    public refreshService: RefreshService,
    public navigation: NavigationService,
    private route: ActivatedRoute,
    public injector: Injector,
    titleService: Title,
  ) {
    super();

    titleService.setTitle(this.title);
  }

  public ngAfterViewInit(): void {

    this.subscription = combineLatest(this.route.url, this.route.queryParams, this.refreshService.refresh$)
      .pipe(
        switchMap(([urlSegments, queryParams, date]) => {

          const { m, pull, x } = this.metaService;

          const navRoute = new NavigationActivatedRoute(this.route);
          this.panelManager.objectType = m.Organisation;
          this.panelManager.id = navRoute.id();
          this.panelManager.expanded = navRoute.panel();

          this.panelManager.on();

          const pulls = [
            pull.Organisation({
              object: this.panelManager.id,
            })
          ];

          this.panelManager.onPull(pulls);

          return this.panelManager.context
            .load('Pull', new PullRequest({ pulls }));
        })
      )
      .subscribe((loaded) => {

        this.panelManager.context.session.reset();
        this.panelManager.onPulled(loaded);

        this.organisation = loaded.objects.Organisation as Organisation;
      });
  }

  public ngOnDestroy(): void {
    if (this.subscription) {
      this.subscription.unsubscribe();
    }
  }
}
