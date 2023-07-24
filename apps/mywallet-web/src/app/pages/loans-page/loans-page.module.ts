import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LoansPageRoutingModule } from './loans-page-routing.module';
import { LoansPageComponent } from './loans-page.component';
import { LayoutModule } from 'src/app/features/layout/layout.module';

@NgModule({
  declarations: [LoansPageComponent],
  imports: [CommonModule, LoansPageRoutingModule, LayoutModule],
})
export class LoansPageModule {}
