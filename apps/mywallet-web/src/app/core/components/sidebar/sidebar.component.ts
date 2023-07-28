import { Component, Input, OnInit } from '@angular/core';
import { SidebarCategory } from './sidebar.interface';

@Component({
  selector: 'app-menubar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.less'],
})
export class SidebarComponent implements OnInit {
  @Input() elements!: SidebarCategory[];

  constructor() {}

  ngOnInit(): void {}
}
