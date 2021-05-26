using System;

namespace XmlWriter_And_XmlReader
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users =
            {
                new User() {UserName = "Omer", Password = "13", AccountCreationDate = DateTime.Now},
                new User(){UserName = "Omer1", Password = "14", AccountCreationDate = DateTime.Now},
                new User() {UserName = "Omer2", Password = "15", AccountCreationDate = DateTime.Now},
                new User(){UserName = "Omer3", Password = "16", AccountCreationDate = DateTime.Now},
                new User() {UserName = "Omer4", Password = "17", AccountCreationDate = DateTime.Now}
            };
            UserXmlWriter.WriteToXml(users);
            Console.WriteLine("Successful");
            users = UserXmlReader.ReadFromXml(@"test1.xml");

            foreach (var user in users)
            {
                Console.WriteLine(user.UserName + "  " + user.Password + "  " + user.AccountCreationDate);
            }

        }
    }
}