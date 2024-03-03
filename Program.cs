using System;

namespace ClubInterface
{
    // Define the IClub interface
    interface IClub
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method
        public string Fullname();
    }

    // Implement the IClub interface using a class
    class ClubMember : IClub
    {
        // Properties implementation
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // Default constructor
        public ClubMember()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
            Email = "";
        }

        // Parameterized constructor
        public ClubMember(int id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        // Method to display member information
        public void DisplayMemberInfo()
        {
            Console.WriteLine($"Member ID: {Id}");
            Console.WriteLine($"Name: {Fullname()}");
            Console.WriteLine($"Email: {Email}");
        }

        // Implement the Fullname method from the interface
        public string Fullname()
        {
            return $"{FirstName} {LastName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a ClubMember object and initialize it
            ClubMember member1 = new ClubMember(1, "John", "Doe", "abc@xyz.com");

            // Display the member information
            member1.DisplayMemberInfo();
        }
    }
}
