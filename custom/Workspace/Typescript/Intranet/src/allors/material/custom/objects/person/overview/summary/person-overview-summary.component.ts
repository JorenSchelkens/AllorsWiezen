import { Component, Self } from '@angular/core';
import { PanelService, NavigationService, MetaService } from '../../../../../../angular';
import { Person, Organisation } from '../../../../../../domain';
import { Meta } from '../../../../../../meta';

@Component({
  // tslint:disable-next-line:component-selector
  selector: 'person-overview-summary',
  templateUrl: './person-overview-summary.component.html',
  providers: [PanelService]
})
export class PersonOverviewSummaryComponent {

  m: Meta;

  person: Person;
  organisation: Organisation;

  constructor(
    @Self() public panel: PanelService,
    public metaService: MetaService,
    public navigation: NavigationService) {

    this.m = this.metaService.m;

    panel.name = 'summary';

    const personPullName = `${panel.name}_${this.m.Person.name}`;

    panel.onPull = (pulls) => {
      const { m, pull, tree, x } = this.metaService;

      const id = this.panel.manager.id;

      pulls.push(
        pull.Person({
          name: personPullName,
          object: id,
          include: {
          }
        }));
    };

    panel.onPulled = (loaded) => {
      this.person = loaded.objects[personPullName] as Person;
    };
  }
}
