using SodaMachineLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<SodaModel> SodaInventoryGetTypes();
        SodaModel SodaInventory_GetSoda(SodaModel soda);
        void SodaInventory_AddSodas(List<SodaModel> sodas);
        List<SodaModel> SodaInventory_GetAll();
        void UserCredit_Insert(string UserId, decimal amount);
        void UserCredit_Clear(string UserId);
        decimal UserCredir_Total(string UserId);
        void UserCredit_Deposit(string UserId);
        decimal MachineInfo_SadaPrice();
        decimal MachineInfo_EmptyCash();
        decimal MachineInfo_CashOnHand();
        decimal MachineInfo_TotalIncome();
        List<CoinModel> CoinInventory_WithdrawCoins(decimal CoinValue, int quantity);
        List<CoinModel> CoinInventory_GetAll();
        void CoinInventory_AddCoins(List<CoinModel> coins);



    }
}
