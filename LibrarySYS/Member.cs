using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
    class Member : IMemberManager
    {
        private string MemberID;
        private string Name;
        private string Phone;
        private string Address;
        private string Email;
        private bool IsActive;

        public Member(string memberID, string name, string phone, string address, string email)
        {
            MemberID = memberID;
            Name = name;
            Phone = phone;
            Address = address;
            Email = email;
            IsActive = true;
        }
        public string memberID
        {
            get { return MemberID; }
            set { MemberID = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string phone
        {
            get { return Phone; }
            set { Phone = value; }
        }
        public string address
        {
            get { return Address; }
            set { Address = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        public void AddMember(Member member)
        {
            throw new NotImplementedException();
        }
        public void UpdateMember(Member member)
        {
            throw new NotImplementedException();
        }
        public void DeRegisterMember(string memberID)
        {
            throw new NotImplementedException();
        }
        public Member FindMemberByID(string memberID)
        {
            throw new NotImplementedException();
        }
        public List<Member> GetAllMembers()
        {
            throw new NotImplementedException();
        }

}
}
