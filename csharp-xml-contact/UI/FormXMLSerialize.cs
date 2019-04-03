using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace csharp_xml_contact
{
    class FormXMLSerialize : FormXmlDocument
    {
        protected override void CreateXmlFile(string filePath)
        {
            base.CreateXmlFile(filePath);
        }

        protected override void LoadData(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(contactList.GetType(), new XmlRootAttribute
                {
                    ElementName = "Contacts"
                });
                contactList = (List<Contact>)xmlSerializer.Deserialize(fileStream);
            }
            base.FillContactList();
        }

        protected override void SaveData(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(contactList.GetType(), new XmlRootAttribute
                {
                    ElementName = "Contacts"
                });
                xmlSerializer.Serialize(fileStream, contactList);
            }
        }
    }
}
