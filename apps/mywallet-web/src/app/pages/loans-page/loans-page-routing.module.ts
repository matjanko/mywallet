import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoansPageComponent } from './loans-page.component';
import { CreateLoanFormComponent } from 'src/app/features/loans/components/create-loan-form/create-loan-form.component';
import { LoanDetailComponent } from 'src/app/features/loans/components/loan-detail/loan-detail.component';

const routes: Routes = [
  {
    path: '',
    component: LoansPageComponent,
    children: [
      {
        path: 'create',
        component: CreateLoanFormComponent,
      },
      {
        path: ':loanId',
        component: LoanDetailComponent,
      },
    ],
  },
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class LoansPageRoutingModule {}
