import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthorizationService } from './auth/authorization.service';
import { LoginComponent } from './auth/login.component';
import { MainComponent } from './main/main.component';
import { DashboardComponent } from './dashboard/dashboard.component';

import * as PersonList from 'src/allors/material/custom/objects/person/list/person-list.module';
import * as PersonOverview from 'src/allors/material/custom/objects/person/overview/person-overview.module';
import { ErrorComponent } from './error/error.component';

const modules = [

  PersonList.PersonListModule,
  PersonOverview.PersonOverviewModule,
];

export const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'error', component: ErrorComponent },
  {
    canActivate: [AuthorizationService],
    path: '', component: MainComponent,
    children: [
      {
        path: '', component: DashboardComponent,
      },
      // Relations
      {
        path: 'contacts',
        children: [
          { path: 'people', component: PersonList.PersonListComponent, },
          { path: 'person/:id', component: PersonOverview.PersonOverviewComponent },
        ],
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule, modules],
})
export class AppRoutingModule { }
