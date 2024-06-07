using BusinessObject;

namespace Repository
{
    public interface IAccountRepository
    {
        AccountMember? GetAccountById(string accountId);
    }
}
