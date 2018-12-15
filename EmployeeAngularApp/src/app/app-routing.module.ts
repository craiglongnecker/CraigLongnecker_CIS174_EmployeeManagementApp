import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllEmployeesComponent } from './allemployees/allemployees.component';
import { GetSingleEmployeeComponent } from './getsingleemployee/getsingleemployee.component';

const routes: Routes = [
  { path: 'employees', component: AllEmployeesComponent },
  { path: 'details', component: GetSingleEmployeeComponent }
  ]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule ]
})

export class AppRoutingModule { }
