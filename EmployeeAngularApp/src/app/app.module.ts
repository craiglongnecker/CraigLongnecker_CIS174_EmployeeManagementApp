import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { AllEmployeesComponent } from './allemployees/allemployees.component';
import { GetSingleEmployeeComponent } from './getsingleemployee/getsingleemployee.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module'
const routes: Routes = [
  { path: 'employees', component: AllEmployeesComponent },
  { path: 'details', component: GetSingleEmployeeComponent }
]

@NgModule({
  declarations: [
    AppComponent,
    AllEmployeesComponent,
    GetSingleEmployeeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],

  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
