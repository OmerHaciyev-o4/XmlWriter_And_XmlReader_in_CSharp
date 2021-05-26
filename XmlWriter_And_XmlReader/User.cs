using System;
using System.Xml.Serialization;

namespace XmlWriter_And_XmlReader
{
    [XmlRoot("User")]
    public class User
    {
        [XmlElement("UserName")]
        public string UserName { get; set; }
        [XmlElement("Password")]
        public string Password { get; set; }
        [XmlElement("AccountCreationDate")]
        public DateTime AccountCreationDate { get; set; }


        public User()
        {
        }
    }
}