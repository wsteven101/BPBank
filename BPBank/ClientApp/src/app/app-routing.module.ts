import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BalanceViewComponent } from './views/balance-view/balance-view.component';
import { MainViewComponent } from './views/main-view/main-view.component';

const routes: Routes = [
  {
    path: 'bpbank', component: MainViewComponent, children: [
      { path: 'balance', component: BalanceViewComponent }
    ]
  },
  { path: '', redirectTo: 'bpbank', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
