using System.IO;
using System.Xml.Serialization;

namespace XmlWriter_And_XmlReader
{
    public class UserXmlReader
    {
        public static User[] ReadFromXml(string filePath)
        {
            User[] users = new User[] { };
            XmlSerializer xml = new XmlSerializer(users.GetType());
            using (StreamReader sr = new StreamReader(filePath))
            {
                User[] obj = (User[])xml.Deserialize(sr);
                return obj;
            }
        }
    }
}