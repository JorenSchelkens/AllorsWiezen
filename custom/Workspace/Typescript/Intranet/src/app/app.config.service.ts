import { Injectable, Self } from '@angular/core';
import { Observable } from 'rxjs';

import { ContextService, MetaService } from '../allors/angular';
import { Organisation, Singleton } from '../allors/domain';
import { PullRequest, Equals } from '../allors/framework';
import { Loaded } from '../allors/angular';
import { StateService } from '../allors/material';
import { tap } from 'rxjs/operators';

@Injectable()
export class ConfigService {

    constructor(
        @Self() private allors: ContextService,
        public metaService: MetaService,
        private stateService: StateService
    ) { }

    public setup(): Observable<any> {

        const { m, pull, x } = this.metaService;

        const pulls = [
            pull.Singleton()
        ];

        return this.allors.context
            .load('Pull', new PullRequest({ pulls }))
            .pipe(
                tap((loaded: Loaded) => {
                    const singletons = loaded.collections.Singletons as Singleton[];
                    this.stateService.singletonId = singletons[0].id;
                })
            );
    }
}
