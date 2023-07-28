import { Component, Input } from '@angular/core';
import { SidebarItem } from '../sidebar/sidebar.interface';

@Component({
  selector: 'app-sidebar-item',
  templateUrl: './sidebar-item.component.html',
  styleUrls: ['./sidebar-item.component.less'],
})
export class SidebarItemComponent {
  @Input() item!: SidebarItem;
}
