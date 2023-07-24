import { Component } from '@angular/core';
import { SidebarCategory } from 'src/app/components/sidebar/sidebar.interface';

@Component({
  selector: 'app-main-layout',
  templateUrl: './main-layout.component.html',
  styleUrls: ['./main-layout.component.less'],
})
export class MainLayoutComponent {
  menuElements: SidebarCategory[];

  constructor() {
    this.menuElements = [
      {
        items: [
          {
            name: 'Dzisiaj',
            icon: { name: 'pi-calendar-times', color: 'green' },
            link: '/',
          },
          { name: 'Saldo', icon: { name: 'pi-wallet', color: 'orange' } },
          { name: 'Samochody', icon: { name: 'pi-car', color: 'pink' } },
        ],
      },
      {
        header: 'Wydatki',
        items: [
          {
            name: 'Kredyty',
            icon: { name: 'pi-percentage', color: 'red' },
            link: '/loans',
          },
          {
            name: 'Rachunki stałe',
            icon: { name: 'pi-money-bill', color: 'purple' },
          },
          {
            name: 'Paragony',
            icon: { name: 'pi-shopping-bag', color: 'gray' },
          },
        ],
      },
      {
        header: 'Przychody',
        items: [
          {
            name: 'Wynagrodzenia',
            icon: { name: 'pi-dollar', color: 'brown' },
          },
        ],
      },
    ];
  }
}
