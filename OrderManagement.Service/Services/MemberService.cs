using OrderManagement.Repository.Model;
using OrderManagement.Repository.Repositories;

namespace OrderManagement.Service.Services
{
    public class MemberService : IMemberService
    {
        private IMemberRepository MemberRepository;
        public MemberService(IMemberRepository memberRepository)
        {
            this.MemberRepository = memberRepository;
        }

        public bool CheckLogin(string email, string password)
        {
            return MemberRepository.CheckLogin(email, password);
        }

        public void CreateMember(Member member)
        {
            MemberRepository.Insert(member);
        }

        public void DeleteMember(int memberId)
        {
            MemberRepository.Delete(memberId);
        }

        public Member GetMember(int memberId)
        {
            return MemberRepository.GetById(memberId);
        }

        public List<Member> GetMembers()
        {
            return (List<Member>)MemberRepository.GetAll();
        }

        public void UpdateMember(Member member)
        {
            MemberRepository.Update(member);
        }
    }
}
