using System;

class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Enter company data:");
        Console.Write("Name: ");
        string companyName = Console.ReadLine();
        Console.Write("Address: ");
        string companyAddr = Console.ReadLine();
        Console.Write("Phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Fax number: ");
        string companyFax = Console.ReadLine();
        Console.Write("Web site: ");
        string companyWeb = Console.ReadLine();
        Console.Write("Manager: ");
        string companyManager = Console.ReadLine();
       
        Console.Write("\nEnter manager data:");
        Console.Write("First name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Age: ");
        string Age = Console.ReadLine();
        Console.Write("Phone number: ");
        string Phone = Console.ReadLine();

        Console.WriteLine("Company data:");
        Console.WriteLine("Name: " + companyName);
        Console.WriteLine("Address: " + companyAddr);
        Console.WriteLine("Phone number: "+companyPhone);
        Console.WriteLine("Fax number: "+companyFax);
        Console.WriteLine("Web site: "+companyWeb);
        Console.WriteLine("Manager: "+companyManager);

        Console.WriteLine("\nManager data:");
        Console.WriteLine("First name: "+firstName);
        Console.WriteLine("Last name: "+lastName);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Phone number: "+Phone);
    }
}
