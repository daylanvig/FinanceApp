using Microsoft.AspNetCore.Http;

namespace FinanceApp.ApplicationCore.DTOS
{
    public class AccountTransactionDTO
    {
        public int AccountID { get; set; }
        public IFormFile Transactions { get; set; }
    }
}
