using LibrarySYS.Entities;
using LibrarySYS.Enums;
using LibrarySYS.Helpers;
using LibrarySYS.Interfaces;
using LibrarySystem.Entities;
using System.Collections.Generic;

namespace LibrarySYS.Managers
{
    public class MemberManager : IMemberManager
    {
        private List<Member> _members;

        public MemberManager()
        {
            _members = new List<Member>();
        }

        public void AddMember(Member member)
        {
            member.MemberId = IdGenerator.GenerateMemberId();
            _members.Add(member);
        }

        public void UpdateMember(Member member)
        {
            foreach (Member m in _members)
            {
                if (m.MemberId == member.MemberId)
                {
                    m.Forename = member.Forename;
                    m.Surname = member.Surname;
                    m.Town = member.Town;
                    m.Eircode = member.Eircode;
                    m.Email = member.Email;
                    m.IsActive = member.IsActive;
                    break;
                }
            }
        }

        public void DeregisterMember(string memberId)
        {
            foreach (Member m in _members)
            {
                if (m.MemberId == memberId)
                {
                    m.IsActive = false;
                    break;
                }
            }
        }

        public Member FindMemberById(string memberId)
        {
            foreach (Member m in _members)
            {
                if (m.MemberId == memberId)
                    return m;
            }
            return null;
        }
        public List<Member> GetAllMembers()
        {
            return _members;
        }
    }
}
