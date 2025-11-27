using LibrarySystem.Entities;
using System.Collections.Generic;


namespace LibrarySYS.Interfaces
{
    internal interface IMemberManager
    {
        void AddMember(Member member);
        void UpdateMember(Member member);
        void DeregisterMember(string memberID);
        Member FindMemberById(string memberID);
        List<Member> GetAllMembers();
    }
}