using OrderManagement.Repository.Model;

namespace OrderManagement.Service.Services
{
    public interface IMemberService
    {
        List<Member> GetMembers();
        Member GetMember(int memberId);
        void CreateMember(Member member);
        void DeleteMember(int memberId);
        void UpdateMember(Member member);

        bool CheckLogin(string email, string password);

    }
}
