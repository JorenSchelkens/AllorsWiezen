import { NgModule, Optional, SkipSelf } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatDialogModule } from '@angular/material';

import { ids } from '../allors/meta/generated';

import { OrganisationCreateModule, OrganisationCreateComponent } from '../allors/material/custom/objects/organisation/create/organisation-create.module';
import { PersonCreateModule, PersonCreateComponent } from '../allors/material/custom/objects/person/create/person-create.module';
import { EmploymentEditComponent, EmploymentEditModule } from '../allors/material/custom/objects/employment/edit/employment-edit.module';

import { ObjectService, OBJECT_CREATE_TOKEN, OBJECT_EDIT_TOKEN } from '../allors/material/base/services/object';

export const create = {
  [ids.Organisation]: OrganisationCreateComponent,
  [ids.Person]: PersonCreateComponent,
  [ids.Employment]: EmploymentEditComponent,
};

export const edit = {
  [ids.Employment]: EmploymentEditComponent,
};

@NgModule({
  imports: [
    CommonModule,
    MatDialogModule,

    OrganisationCreateModule,
    PersonCreateModule,
    EmploymentEditModule,
  ],
  entryComponents: [
    OrganisationCreateComponent,
    PersonCreateComponent,
    EmploymentEditComponent,
  ],
  providers: [
    ObjectService,
    { provide: OBJECT_CREATE_TOKEN, useValue: create },
    { provide: OBJECT_EDIT_TOKEN, useValue: edit },
  ]
})
export class AppDialogModule {

  constructor(@Optional() @SkipSelf() core: AppDialogModule) {
    if (core) {
      throw new Error('Use FactoryModule from AppModule');
    }
  }
}
