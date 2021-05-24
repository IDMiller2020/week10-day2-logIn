using System;
using System.Collections.Generic;
using logIn.Modesls;

namespace logIn
{
  class Program
  {
    static void Main(string[] args)
    {
        Dictionary<string, User> users = new Dictionary<string, User>();
        User jonesy = new User("Jonesy", "CricketLegs");
        User Justin = new User("Justin", "IHeartB3yBlade");


        users.Add(jonesy.Name, jonesy);
        users.Add(Justin.Name, Justin);




      Console.Clear();
      Console.WriteLine("Welcome, please login to continue");
      Console.Write("Username: ");
      string username = Console.ReadLine();
      Console.Write("Password: ");
      string password = Console.ReadLine();


      if(users.ContainsKey(username) && users[username].ValidatePassword(password))
      {
          System.Console.WriteLine("Successfully Logged in");
      }
      else
      {
          System.Console.WriteLine("Invalid Username or Passoword");
      }



      //   Console.Clear();
      //   Console.WriteLine("Choose login or create account (l or c):");
      //   char choice = Console.ReadKey().KeyChar;

      //   Console.WriteLine("LOGIN");
      //   Console.WriteLine("Please enter your username:");
    }
  }
}