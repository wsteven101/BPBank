import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatMenuModule } from '@angular/material/menu';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatSidenavModule } from '@angular/material/sidenav';
//import { MatNativeDateModule } from '@angular/material/core';
//import { MatMomentDateModule, MAT_MOMENT_DATE_ADAPTER_OPTIONS } from '@angular/material-moment-adapter';
import { MAT_DATE_LOCALE, MAT_DATE_FORMATS, MatNativeDateModule } from '@angular/material/core';
import { MatListModule } from '@angular/material/list';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatTableModule } from '@angular/material/table';
import { MatDialogModule } from "@angular/material/dialog";


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MatDatepickerModule, MatIconModule,
    MatToolbarModule, MatListModule, MatDialogModule
  ],
  exports: [
    MatToolbarModule, MatButtonModule, MatMenuModule,
    MatIconModule, MatInputModule, MatSelectModule,
    MatCardModule, MatFormFieldModule, BrowserAnimationsModule,
    MatDatepickerModule,  MatNativeDateModule,
    MatSidenavModule, MatListModule, MatGridListModule,
    MatTableModule
  ]
})
export class AngMaterialRefModule { }

