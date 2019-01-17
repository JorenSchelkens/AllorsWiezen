import { ids } from '../../allors/meta/generated';

export interface MenuItem {
  id?: string;
  link?: string;
  title?: string;
  icon?: string;
  children?: MenuItem[];
}

export const menu: MenuItem[] = [
  { title: 'Home', icon: 'home', link: '/' },
  {
    title: 'Contacts', icon: 'group',
    children: [
      { id: ids.Person },
      { id: ids.Organisation },
    ]
  },
];
