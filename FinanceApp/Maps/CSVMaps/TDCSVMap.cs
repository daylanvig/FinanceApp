using FinanceApp.Models.DTOS;
using TinyCsvParser.Mapping;

namespace FinanceApp.Maps.CSVMaps
{
    public class TDCSVMap : CsvMapping<TDTransactionDTO>, ICsvMapping<TDTransactionDTO>
    {
        public TDCSVMap() : base()
        {
            MapProperty(0, t => t.Date);
            MapProperty(1, t => t.Description);
            MapProperty(2, t => t.WithdrawalAmount);
            MapProperty(3, t => t.DepositAmount);
            MapProperty(4, t => t.Balance);
        }
    }
}
