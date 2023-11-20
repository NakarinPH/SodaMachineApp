using SodaMachineLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineLibrary
{
    public interface ISodaMachineLogic
    {
        List<SodaModel> ListTypeOfSoda();

        // Takes in an amount and returns the total deposited so far
        decimal MoneyInserted(decimal moneytaryAmount);

        // gets the overall price for sodas - there is no individual pricing
        decimal GetSodaPrice();

        // SodaModel (or null), List<Coin> Change, string ErrorMessage
        (SodaModel soda, List<CoinModel> change, string errorMessage) RequestSoda(SodaModel soda);

        void IssueFullRefund();

        decimal GetMoneyInsertedTotal();

        void AddtoInventory(List<SodaModel> sodas);

        List<SodaModel> GetSodaInventory();

        decimal EmptyMoneyFromMachine();

        List<CoinModel> GetCoinInventory();

        void AddToCoinInventory(List<CoinModel> coins);

        decimal GetCurrentIncome();

        decimal GetTotalIncome();

    }
}
