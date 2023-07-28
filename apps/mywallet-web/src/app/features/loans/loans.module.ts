import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { LoansPageComponent } from './pages/loans-page/loans-page.component';
import { LoansRoutingModule } from './loans-routing.module';

@NgModule({
  declarations: [LoansPageComponent],
  imports: [CommonModule, LoansRoutingModule],
  exports: [],
})
export class LoansModule {}
