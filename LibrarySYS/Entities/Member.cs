using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySYS.Enums;


namespace LibrarySystem.Entities
{
    public class Member
    {
        private string _memberId;
        private string _forename;
        private string _surname;
        private County _town;
        private string _eircode;
        private string _email;
        private string _phone;
        private bool _isActive;

        public string MemberId
        {
            get { return _memberId; }
            set { _memberId = value; }
        }

        public string Forename
        {
            get { return _forename; }
            set { _forename = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public County Town
        {
            get { return _town; }
            set { _town = value; }
        }

        public string Eircode
        {
            get { return _eircode; }
            set { _eircode = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public Member()
        {
            IsActive = true;
        }
    }
}

