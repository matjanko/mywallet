import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: '/loans',
    pathMatch: 'full',
  },
  {
    path: 'loans',
    loadChildren: () =>
      import('./pages/loans-page/loans-page.module').then(
        (m) => m.LoansPageModule
      ),
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
