import { Component, OnDestroy, OnInit, Self } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Subscription, combineLatest } from 'rxjs';

import { PullRequest } from '../../allors/framework';
import { MediaService, ContextService, MetaService, TestScope, Saved, RefreshService } from '../../allors/angular';
import { ObjectService, ObjectData } from '../../allors/material/base/services/object';
import { Meta, PullFactory, FetchFactory, TreeFactory } from '../../allors/meta';

import { Scoreboard, Game, GameType } from '../../allors/domain';
import { SaveService } from 'src/allors/material';
import { scan, switchMap } from 'rxjs/operators';
import * as moment from 'moment';

@Component({
  templateUrl: './dashboard.component.html',
  providers: [ContextService]
})
export class DashboardComponent extends TestScope implements OnInit, OnDestroy {

  scoreboard: Scoreboard;
  gameTypes: GameType[];
  game: Game;
  m: Meta;

  private subscription: Subscription;

  get isRunning(): boolean {
    return !!this.game && this.game.StartDate && !this.game.EndDate;
  }

  constructor(
    @Self() public allors: ContextService,
    public metaService: MetaService,
    public factoryService: ObjectService,
    public mediaService: MediaService,
    public saveService: SaveService,
    public refreshService: RefreshService,
    titleService: Title
  ) {
    super();

    titleService.setTitle('Dashboard');
    this.m = this.metaService.m;
  }

  public ngOnInit(): void {

    this.subscription = combineLatest(this.refreshService.refresh$)
      .pipe(
        switchMap(([refresh]) => {
          const { pull, x } = this.metaService;

          const pulls = [
            pull.Scoreboard({
              include: {
                Games: x,
                Players: x
              }
            }),
            pull.GameType({
            })
          ];

          return this.allors.context.load('Pull', new PullRequest({ pulls }))
        })
      )
      .subscribe((loaded) => {
        this.allors.context.reset();

        const scoreboards = loaded.collections.Scoreboards as Scoreboard[];
        this.scoreboard = scoreboards[0];
        this.game = this.scoreboard.Games.find(v => v.EndDate == null);

        this.gameTypes = loaded.collections.GameTypes as GameType[];
      });
  }

  gameTypeChanged(gameType: GameType): void {
    this.game.GameType = gameType;
    this.save();
  }

  createGame(): void {
    const { m } = this.metaService;
    const game = this.allors.context.create(m.Game) as Game;

    this.scoreboard.AddGame(game);
    this.save();
  }

  startGame(): void {
    this.game.StartDate = moment().utc().toISOString();
    this.save();
  }

  stopGame(): void {
    this.game.EndDate = moment().utc().toISOString();
    this.save();
  }



  ngOnDestroy(): void {
    if (this.subscription) {
      this.subscription.unsubscribe();
    }
  }

  private save(): void {
    this.allors.context
      .save()
      .subscribe((saved: Saved) => {
        this.refreshService.refresh();
      },
        this.saveService.errorHandler);
  }
}
