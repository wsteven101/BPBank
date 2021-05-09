import { Component, OnInit } from '@angular/core';
import { AngMaterialRefModule } from '../../ang-material-ref/ang-material-ref.module';
import { MatToolbarModule } from '@angular/material/toolbar';


@Component({
  selector: 'app-main-view',
  templateUrl: './main-view.component.html',
  styleUrls: ['./main-view.component.css']
})
export class MainViewComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
