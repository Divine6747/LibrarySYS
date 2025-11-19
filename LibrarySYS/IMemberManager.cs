using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
    internal interface IMemberManager
    {
        void AddMember(Member member);
        void UpdateMember(Member member);
        void DeRegisterMember(string memberID);
        Member FindMemberByID(string memberID);
        List<Member> GetAllMembers();
    }
}
