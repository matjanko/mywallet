import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './core/components/navbar/navbar.component';
import { SidebarComponent } from './core/components/sidebar/sidebar.component';
import { MainLayoutComponent } from './core/components/layout/main-layout/main-layout.component';
import { SidebarItemComponent } from './core/components/sidebar-item/sidebar-item.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    SidebarComponent,
    MainLayoutComponent,
    SidebarItemComponent,
  ],
  imports: [BrowserModule, AppRoutingModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
