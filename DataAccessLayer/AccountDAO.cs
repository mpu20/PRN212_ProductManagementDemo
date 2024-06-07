using BusinessObject;

namespace DataAccessLayer
{
    public class AccountDAO
    {
        public static AccountMember? GetAccountById(string accountId)
        {
            using var db = new MyStoreContext();
            return db.AccountMembers.FirstOrDefault(am => am.MemberId.Equals(accountId));
        }
    }
}
