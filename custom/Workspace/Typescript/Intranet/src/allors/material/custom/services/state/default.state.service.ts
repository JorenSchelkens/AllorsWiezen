import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { SearchFactory, WorkspaceService } from '../../../../angular';
import { Meta } from '../../../../meta';
import { StateService } from './state.service';

@Injectable()
export class DefaultStateService extends StateService {
  private static readonly organisationIdKey = 'StateService$OrganisationId';
  private static readonly singletonIdKey = 'StateService$SingletonId';

  private organisationIdSubject: BehaviorSubject<string>;

  constructor(private workspaceService: WorkspaceService) {
    super();

    const sessionOrganisationId = sessionStorage.getItem(DefaultStateService.organisationIdKey);
    this.organisationIdSubject = new BehaviorSubject(sessionOrganisationId);
    this.organisationId$ = this.organisationIdSubject;

    const m = this.workspaceService.metaPopulation as Meta;

    this.organisationsFilter = new SearchFactory({
      objectType: m.Organisation,
      roleTypes: [m.Organisation.Name],
    });

    this.peopleFilter = new SearchFactory({
      objectType: m.Person,
      roleTypes: [m.Person.FirstName, m.Person.LastName],
    });
  }

  public get singletonId(): string {
    const key = DefaultStateService.singletonIdKey;
    return sessionStorage.getItem(key);
  }

  public set singletonId(value: string) {
    const key = DefaultStateService.singletonIdKey;
    sessionStorage.setItem(key, value);
  }

  public get organisationId(): string {
    return this.organisationIdSubject.value;
  }

  public set organisationId(value: string) {
    sessionStorage.setItem(DefaultStateService.organisationIdKey, value);
    this.organisationIdSubject.next(value);
  }
}
