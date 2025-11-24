using LibrarySYS;
using System.Collections.Generic;

class Member : IMemberManager
{
    private static List<Member> members = new List<Member>();

    private string MemberID;
    private string Forename;
    private string Surname;
    private string Phone;
    private string Town;
    private string Eircode;
    private string Email;
    private bool IsActive;

    public Member(string memberID, string forname, string surname, string town, string eircode, string phone, string email)
    {
        MemberID = memberID;
        Forename = forname;
        Surname = surname;
        Town = town;
        Eircode = eircode;
        Phone = phone;
        Email = email;
        IsActive = true;
    }

    public void AddMember(Member member)
    {
        members.Add(member);
    }
    public List<Member> GetAllMembers()
    {
        return members;
    }
    public void UpdateMember(Member member) { }
    public void DeRegisterMember(string memberID) { }
    public Member FindMemberByID(string memberID) { return null; }
}
