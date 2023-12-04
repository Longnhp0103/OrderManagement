using OrderManagement.Repository.Model;

namespace OrderManagement.Repository.Repositories
{
    public interface IMemberRepository : IGenericRepository<Member>
    {
        bool CheckLogin(string email, string password);
    }
}
