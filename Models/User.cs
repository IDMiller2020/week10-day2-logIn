namespace logIn.Modesls
{
  public class User
  {
    private string Name { get; set; }
    private string Password { get; set; }

    public bool ValidatePassword(string input)
    {
      return input == Password;
    }
    public User(string name, string password)
    {
      Name = name;
      Password = password;
    }

  }
}