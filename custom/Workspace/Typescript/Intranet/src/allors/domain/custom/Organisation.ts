import { domain } from '../domain';
import { Organisation } from '../generated/Organisation.g';

declare module '../generated/Organisation.g' {
    interface Organisation {
        displayName: string;
    }
}

domain.extend((workspace) => {

    const obj: Organisation = workspace.prototypeByName['Organisation'];

    Object.defineProperties(obj, {
        displayName: {
            get(this: Organisation): string {
                return this.Name || 'N/A';
            },
        },
    });

});
