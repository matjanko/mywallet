import { NgModule } from '@angular/core';
import { MainLayoutComponent } from './main-layout/main-layout.component';
import { CommonModule } from '@angular/common';
import { NavbarModule } from 'src/app/components/navbar/navbar.module';
import { SidebarModule } from 'src/app/components/sidebar/sidebar.module';

@NgModule({
  declarations: [MainLayoutComponent],
  imports: [CommonModule, NavbarModule, SidebarModule],
  exports: [MainLayoutComponent],
})
export class LayoutModule {}
