import { Component, OnInit } from '@angular/core';
import { AngMaterialRefModule } from '../../ang-material-ref/ang-material-ref.module';
import { MatToolbarModule } from '@angular/material/toolbar';
import { Router, ActivatedRoute, NavigationExtras } from '@angular/router';

@Component({
  selector: 'app-main-view',
  templateUrl: './main-view.component.html',
  styleUrls: ['./main-view.component.css']
})
export class MainViewComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private router: Router  ) { }

  ngOnInit(): void {
  }

  public onBalanceClick() {
    this.router.navigate(['/bpbank/balance']);
  }
}
