import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    loadChildren: () =>
      import('./pages/home-page/home-page.module').then(
        (x) => x.HomePageModule
      ),
  },
  {
    path: 'loans',
    loadChildren: () =>
      import('./pages/loans-page/loans-page.module').then(
        (x) => x.LoansPageModule
      ),
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
