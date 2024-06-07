using BusinessObject;
using DataAccessLayer;

namespace Repository
{
    public class AccountRepository : IAccountRepository
    {
        public AccountMember? GetAccountById(string accountId) => AccountDAO.GetAccountById(accountId);
    }
}
