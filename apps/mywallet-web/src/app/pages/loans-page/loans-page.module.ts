import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoansPageComponent } from './loans-page.component';
import { LoansModule } from 'src/app/features/loans/loans.module';
import { LoansPageRoutingModule } from './loans-page-routing.module';

@NgModule({
  declarations: [LoansPageComponent],
  imports: [CommonModule, LoansPageRoutingModule, LoansModule],
})
export class LoansPageModule {}
