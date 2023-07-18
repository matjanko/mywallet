import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateLoanFormComponent } from './components/create-loan-form/create-loan-form.component';
import { ReactiveFormsModule } from '@angular/forms';
import { LoansListComponent } from './components/loans-list/loans-list.component';
import { LoanItemComponent } from './components/loan-item/loan-item.component';
import { LoanDetailComponent } from './components/loan-detail/loan-detail.component';

@NgModule({
  declarations: [CreateLoanFormComponent, LoansListComponent, LoanItemComponent, LoanDetailComponent],
  imports: [CommonModule, ReactiveFormsModule],
  exports: [CreateLoanFormComponent, LoansListComponent],
})
export class LoansModule {}
