using LibrarySYS;
using System;
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
    public override string ToString()
    {
        return $"ID: {MemberID}, Name: {Forename} {Surname}, Town: {Town}, " +
               $"Eircode: {Eircode}, Phone: {Phone}, Email: {Email}, Active: {IsActive}";
    }

    public string memberID
    {
        get { return memberID; }
        set { memberID = value; }
    }

    public string forename
    {
        get { return forename; }
        set { forename = value; }
    }

    public string surname
    {
        get { return surname; }
        set { surname = value; }
    }

    public string town
    {
        get { return town; }
        set { town = value; }
    }

    public string eircode
    {
        get { return eircode; }
        set { eircode = value; }
    }

    public string phone
    {
        get { return phone; }
        set { phone = value; }
    }

    public string email
    {
        get { return email; }
        set { email = value; }
    }

    public void AddMember(Member member)
    {
        members.Add(member);
        foreach (var v in members)
        {
            Console.WriteLine("Member = {0}", v);
        }
    }
    public List<Member> GetAllMembers()
    {
        return members;
    }
    public void UpdateMember(Member member) { }

    public void DeRegisterMember(string memberID)
    {
        Member m = FindMemberByID(memberID);

        if (m != null)
        {
            m.IsActive = false;
        }
    }
    public Member FindMemberByID(string memberID)
    {
        foreach (Member m in members)
        {
            if (m.MemberID == memberID)
            {
                return m;
            }
        }
        return null;
    }
}
