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

    public string GetMemberID() { return MemberID; }
    public string GetForename() { return Forename; }
    public string GetSurname() { return Surname; }
    public string GetTown() { return Town; }
    public string GetEircode() { return Eircode; }
    public string GetPhone() { return Phone; }
    public string GetEmail() { return Email; }
    public bool GetIsActive() { return IsActive; }

    public void SetMemberID(string id) { MemberID = id; }
    public void SetForename(string forename) { Forename = forename; }
    public void SetSurname(string surname) { Surname = surname; }
    public void SetTown(string town) { Town = town; }
    public void SetEircode(string eircode) { Eircode = eircode; }
    public void SetPhone(string phone) { Phone = phone; }
    public void SetEmail(string email) { Email = email; }
    public void SetIsActive(bool active) { IsActive = active; }


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
    public void UpdateMember(Member member) {
        for (int i = 0; i < members.Count; i++)
        {
            if (members[i].MemberID == member.MemberID)
            {
                members[i].SetForename(member.Forename);
                members[i].SetSurname(member.Surname);
                members[i].SetTown(member.Town);
                members[i].SetEircode(member.Eircode);
                members[i].SetPhone(member.Phone);
                members[i].SetEmail(member.Email);
                members[i].SetIsActive(member.IsActive);

                break;
            }
        }

    }

    public void DeRegisterMember(string memberID)
    {
        Member m = FindMemberByID(memberID);

        if (m != null)
        {
            m.SetIsActive(false);
        }
    }

    public Member FindMemberByID(string memberID)
    {
        foreach (Member m in members)
        {
            if (m.GetMemberID() == memberID)
            {
                return m;
            }
        }
        return null;
    }

}
