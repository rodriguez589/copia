namespace Parcial02.Entities.Users
{
    public class User
    {
        public string Id { get; set; } //Carnet => llave primaria
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Question_Security { get; set; }
        public string Answer_Security { get; set; }

        public User()
        { }

        public User(string id, string fullName, string password, string questionSecurity, string answerSecurity)
        {
            Id = id;
            FullName = fullName;
            Password = password;
            Question_Security = questionSecurity;
            Answer_Security = answerSecurity;
        }

       
    }
}