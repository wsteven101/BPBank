import { HttpClient, HttpParams } from '@angular/common/http';
import { Component, Injectable, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { AccountBalance } from '../../entities/accountbalance';


@Injectable({
  providedIn: 'root',
})
export class AccountBalanceService  {

  constructor(private httpClient: HttpClient) { }

  public getByUserId(userId: string): Observable<AccountBalance[]> {

    const options = userId ? {
      params: new HttpParams().set('id', userId)
    } : {};

    let urlStr: string = 'api/account/user/' + userId;

    console.log("account balances service " + urlStr);

    return this.httpClient.get<AccountBalance[]>(urlStr, options);

  }

}
