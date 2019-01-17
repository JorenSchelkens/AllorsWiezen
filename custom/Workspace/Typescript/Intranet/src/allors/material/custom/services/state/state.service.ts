import { Observable } from 'rxjs';
import { SearchFactory } from '../../../../angular';

export abstract class StateService {
    public singletonId: string;

    public organisationId: string;
    public organisationId$: Observable<string>;

    public organisationsFilter: SearchFactory;
}
