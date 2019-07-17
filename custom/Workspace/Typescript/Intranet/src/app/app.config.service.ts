import { Injectable, Self } from '@angular/core';
import { Observable } from 'rxjs';

import { ContextService, MetaService, SingletonId} from '../allors/angular';
import { Singleton } from '../allors/domain';
import { PullRequest } from '../allors/framework';
import { Loaded } from '../allors/angular';
import { tap } from 'rxjs/operators';

@Injectable()
export class ConfigService {

    constructor(
        @Self() private allors: ContextService,
        public metaService: MetaService,
        private singletonId: SingletonId,
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
                    this.singletonId.value = singletons[0].id;
                })
            );
    }
}
