"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.AccountBalance = void 0;
var AccountBalance = /** @class */ (function () {
    //public constructor()
    function AccountBalance(id, userId, accNumber, balance, baseCcyId, baseCcy) {
        this.id = id;
        this.userId = userId;
        this.accNumber = accNumber;
        this.balance = balance;
        this.baseCcyId = baseCcyId;
        this.baseCcy = baseCcy;
    }
    return AccountBalance;
}());
exports.AccountBalance = AccountBalance;
//# sourceMappingURL=accountbalance.js.map