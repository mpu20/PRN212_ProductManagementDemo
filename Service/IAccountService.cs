using BusinessObject;

namespace Service
{
    public interface IAccountService
    {
        AccountMember? GetAccountById(string accountId);
    }
}
