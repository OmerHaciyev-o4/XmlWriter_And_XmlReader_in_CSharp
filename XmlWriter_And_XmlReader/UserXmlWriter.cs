using System.IO;
using System.Xml.Serialization;

namespace XmlWriter_And_XmlReader
{
    public class UserXmlWriter
    {
        public static void WriteToXml(User[] users)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute();
            xmlRoot.ElementName = "User";
            xmlRoot.IsNullable = true;

            XmlSerializer xml = new XmlSerializer(users.GetType());
            using (StreamWriter sw = new StreamWriter("test1.xml"))
            {
                xml.Serialize(sw, users);
            }
        }
    }
}