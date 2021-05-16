export class AccountBalance {

  //public constructor()
  public constructor(
    public id: number,
    public userId: number,
    public accNumber: string,
    public balance: number,
    public baseCcyId: number,
    public baseCcy: string
  ) { }

}
