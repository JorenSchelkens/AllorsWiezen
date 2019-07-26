import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import {MatButtonToggleModule} from '@angular/material/button-toggle';

import { DashboardComponent } from './dashboard.component';
import { AllorsMaterialAutoCompleteModule } from 'src/allors/material';


@NgModule({
  declarations: [
    DashboardComponent,
  ],
  exports: [
  ],
  imports: [
    CommonModule,
    MatIconModule,
    MatCardModule,
    MatButtonToggleModule,
    AllorsMaterialAutoCompleteModule,
    RouterModule,
  ],
})
export class DashboardModule {
}
