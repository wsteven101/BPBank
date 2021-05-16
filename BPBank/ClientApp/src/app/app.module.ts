import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AngMaterialRefModule } from './ang-material-ref/ang-material-ref.module';
import { AppRoutingModule } from './app-routing.module';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { HttpClient, HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { BalanceViewComponent } from './views/balance-view/balance-view.component';
import { MainViewComponent } from './views/main-view/main-view.component';

@NgModule({
  declarations: [
    AppComponent,
    MainViewComponent,
    BalanceViewComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AngMaterialRefModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
