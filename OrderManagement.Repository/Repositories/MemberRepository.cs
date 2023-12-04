using OrderManagement.Repository.Model;

namespace OrderManagement.Repository.Repositories
{
    public class MemberRepository : GenericRepository<Member>, IMemberRepository
    {
        public MemberRepository(Assignment1Context dbContext) : base(dbContext)
        {
        }

        public bool CheckLogin(string email, string password)
        {
            var member = _dbContext.Members.FirstOrDefault(m => m.Email == email && m.Password == password);
            if (member == null)
            {
                return false;
            }
            return true;
        }
    }
}
