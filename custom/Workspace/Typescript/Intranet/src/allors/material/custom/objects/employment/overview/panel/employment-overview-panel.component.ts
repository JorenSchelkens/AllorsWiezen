import { Component, Self, Input, OnInit, HostBinding } from '@angular/core';
import * as moment from 'moment';

import { ISessionObject, RoleType, Fetch, Pull } from '../../../../../../framework';
import { Meta } from '../../../../../../meta';
import { PanelService, MetaService, RefreshService, Action, ActionTarget } from '../../../../../../angular';
import { DeleteService, TableRow, Table, ObjectService, CreateData } from '../../../../..';

import { Employment } from '../../../../../../domain';

interface Row extends TableRow {
  object: Employment;
  employee: string;
  from: string;
  through: string;
}

@Component({
  // tslint:disable-next-line:component-selector
  selector: 'employment-overview-panel',
  templateUrl: './employment-overview-panel.component.html',
  providers: [PanelService]
})
export class EmployementOverviewPanelComponent implements OnInit {
  @Input() roleType: RoleType;

  @HostBinding('class.expanded-panel') get expandedPanelClass() {
    return this.panel.isExpanded;
  }

  m: Meta;

  objects: Employment[];
  table: Table<Row>;

  delete: Action;

  edit: Action = {
    name: (target: ActionTarget) => 'Edit',
    description: (target: ActionTarget) => 'Edit',
    disabled: (target: ActionTarget) => !this.objectService.hasEditControl(target as ISessionObject),
    execute: (target: ActionTarget) => this.objectService.edit(target as ISessionObject).subscribe((v) => this.refreshService.refresh()),
    result: null
  };

  get createData(): CreateData {
    return {
      associationId: this.panel.manager.id,
      associationObjectType: this.panel.manager.objectType,
      associationRoleType: this.roleType,
    };
  }
  constructor(
    @Self() public panel: PanelService,
    public metaService: MetaService,
    public objectService: ObjectService,
    public refreshService: RefreshService,
    public deleteService: DeleteService,
  ) {

    this.m = this.metaService.m;
  }

  ngOnInit() {

    this.delete = this.deleteService.delete(this.panel.manager.context);

    this.panel.name = 'employment';
    this.panel.title = 'Employement';
    this.panel.icon = 'account_box';
    this.panel.expandable = true;

    this.delete = this.deleteService.delete(this.panel.manager.context);

    const sort = true;
    this.table = new Table({
      selection: true,
      columns: [
        { name: 'employee', sort },
        { name: 'from', sort },
        { name: 'through', sort },
      ],
      actions: [
        this.edit,
        this.delete,
      ],
      defaultAction: this.edit,
      autoSort: true
    });

    const pullName = `${this.panel.name}_${this.m.Employment.name}`;

    this.panel.onPull = (pulls) => {
      const { x,  pull } = this.metaService;
      const { id } = this.panel.manager;

      pulls.push(
        pull.Organisation(
          {
            name: pullName,
            object: id,
            fetch: {
              EmploymentsWhereEmployer: {
                include: {
                  Employer: x,
                  Employee: x,
                }
              }
            }
          }
        )
      );

      this.panel.onPulled = (loaded) => {
        this.objects = loaded.collections[pullName] as Employment[];
        this.table.total = loaded.values[`${pullName}_total`] || this.objects.length;
        this.table.data = this.objects.map((v) => {
          return {
            object: v,
            employee: v.Employee && v.Employee.displayName,
            from: moment(v.From).format('L'),
            through: v.Through !== null ? moment(v.Through).format('L') : '',
          } as Row;
        });
      };
    };
  }
}
