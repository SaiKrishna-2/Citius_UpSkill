import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CardviewComponent } from './cardview/cardview.component';
import { TableviewComponent } from './tableview/tableview.component';

const routes: Routes = [
  {
    path:"cardview",
    component:CardviewComponent
  },
  {
    path:"tableview",
    component:TableviewComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
