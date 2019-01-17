import { Pull } from '../../../framework';
import { StateService } from '../services/state';
import { PullFactory } from '../../../meta';

const x = {};

export class Fetcher {

  constructor(private stateService: StateService, private pull: PullFactory) {
  }

  public get locales(): Pull {

    return this.pull.Singleton({
      object: this.stateService.singletonId,
      fetch: {
        AdditionalLocales: {
          include: {
            Language: x,
            Country: x
          }
        }
      },
    });
  }

  public get Settings(): Pull {

    return this.pull.Singleton({
      object: this.stateService.singletonId,
      fetch: {
        Settings: {
        }
      },
    });
  }
}
