import { Component, OnDestroy, OnInit, Self } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Subscription } from 'rxjs';

import { PullRequest } from '../../allors/framework';
import { MediaService, ContextService, MetaService, TestScope } from '../../allors/angular';
import { ObjectService } from '../../allors/material/base/services/object';

import { Scoreboard } from '../../allors/domain';

@Component({
  templateUrl: './dashboard.component.html',
  providers: [ContextService]
})
export class DashboardComponent extends TestScope implements OnInit, OnDestroy {

  scoreboard: Scoreboard;

  private subscription: Subscription;

  constructor(
    @Self() public allors: ContextService,
    public metaService: MetaService,
    public factoryService: ObjectService,
    public mediaService: MediaService,
    titleService: Title
  ) {
    super();

    titleService.setTitle('Dashboard');
  }

  public ngOnInit(): void {

    const { pull, x } = this.metaService;

    const pulls = [
      pull.Scoreboard({
        include: {
          Games: x,
          Players: x
        }
      })
    ];

    this.allors.context.load('Pull', new PullRequest({ pulls }))
      .subscribe((loaded) => {
        this.allors.context.reset();

        const scoreboards = loaded.collections.Scoreboards as Scoreboard[];
        this.scoreboard = scoreboards[0];
      });
  }

  public ngOnDestroy(): void {
    if (this.subscription) {
      this.subscription.unsubscribe();
    }
  }
}
