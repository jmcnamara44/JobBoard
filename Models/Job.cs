using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Contact
  {
    private string _name;
    private string _email;
    private string _phoneNumber;

    public Contact(string name, string email, string phoneNumber)
    {
      _name = name;
      _email = email;
      _phoneNumber = phoneNumber;
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name=newName;
    }
    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(string newEmail)
    {
      _email=newEmail;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber=newPhoneNumber;
    }
  }


  public class Job
  {
    private string _title;
    private string _description;
    private Contact _contactInfo;

    private static List<Job> _jobs = new List<Job> {};


    public Job (string title, string description, Contact contactInfo)
    {
      _title=title;
      _description=description;
      _contactInfo=contactInfo;
    }

    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string newTitle)
    {
      _title=newTitle;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description=newDescription;
    }
    public Contact GetContactInfo()
    {
      return _contactInfo;
    }
    public void SetContactInfo(Contact newContactInfo)
    {
      _contactInfo=newContactInfo;
    }
    public static List<Job> GetAll()
    {
      return _jobs;
    }
    public void Save()
    {
      _jobs.Add(this);
    }
    public static void ClearAll()
    {
      _jobs.Clear();
    }
  }
}
