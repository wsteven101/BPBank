import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AccountBalance } from '../../entities/accountbalance';
import { AccountBalanceService } from '../../services/account-balance-service/account-balance-service.component';

@Component({
  selector: 'app-balance-view',
  templateUrl: './balance-view.component.html',
  styleUrls: ['./balance-view.component.css']
})
export class BalanceViewComponent implements OnInit {

  accountBalances: Observable<AccountBalance[]>;

  constructor(private router: Router,
    private routes: ActivatedRoute,
    private fb: FormBuilder,
    private accountBalancesService: AccountBalanceService  )
  {
  }

  ngOnInit(): void {
    let userId = 'Fred';   // to be replaced by logged in user id
    this.accountBalances = this.accountBalancesService.getByUserId(userId);
    let a = 5;
  }


}
