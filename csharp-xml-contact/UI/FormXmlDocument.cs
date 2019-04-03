using System.Xml;

namespace csharp_xml_contact
{
    class FormXmlDocument : FormBase
    {
        protected override void CreateXmlFile(string filePath)
        {
            XmlDocument xmlDocument = new XmlDocument();

            XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", null);
            XmlElement rootElement = xmlDocument.DocumentElement;
            xmlDocument.InsertBefore(xmlDeclaration, rootElement);

            XmlElement bodyElement = xmlDocument.CreateElement("Contacts");
            xmlDocument.AppendChild(bodyElement);

            xmlDocument.Save(filePath);
        }

        protected override void LoadData(string filePath)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);
            XmlNodeList xmlNodeList = xmlDocument.SelectNodes("Contacts/Contact");

            foreach (XmlNode xmlNode in xmlNodeList)
            {
                var tmpContact = new Contact
                {
                    FirstName = xmlNode.SelectSingleNode("FirstName").InnerText,
                    LastName = xmlNode.SelectSingleNode("LastName").InnerText,
                    Email = xmlNode.SelectSingleNode("Email").InnerText,
                    PhoneNumber = xmlNode.SelectSingleNode("PhoneNumber").InnerText,
                    Address = xmlNode.SelectSingleNode("Address").InnerText,
                    WebAddress = xmlNode.SelectSingleNode("WebAddress").InnerText,
                    Notes = xmlNode.SelectSingleNode("Notes").InnerText,
                };
                contactList.Add(tmpContact);
            }
            base.FillContactList();
        }

        protected override void SaveData(string filePath)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);
            xmlDocument.DocumentElement.RemoveAll();

            foreach (Contact currentContact in contactList)
            {
                XmlNode xmlContact = xmlDocument.CreateElement("Contact");

                XmlNode xmlFirstName = xmlDocument.CreateElement("FirstName");
                xmlFirstName.InnerText = currentContact.FirstName;
                xmlContact.AppendChild(xmlFirstName);

                XmlNode xmlLastName = xmlDocument.CreateElement("LastName");
                xmlLastName.InnerText = currentContact.LastName;
                xmlContact.AppendChild(xmlLastName);

                XmlNode xmlEmail = xmlDocument.CreateElement("Email");
                xmlEmail.InnerText = currentContact.Email;
                xmlContact.AppendChild(xmlEmail);

                XmlNode xmlPhoneNumber = xmlDocument.CreateElement("PhoneNumber");
                xmlPhoneNumber.InnerText = currentContact.PhoneNumber;
                xmlContact.AppendChild(xmlPhoneNumber);

                XmlNode xmlAddress = xmlDocument.CreateElement("Address");
                xmlAddress.InnerText = currentContact.Address;
                xmlContact.AppendChild(xmlAddress);

                XmlNode xmlWebAddress = xmlDocument.CreateElement("WebAddress");
                xmlWebAddress.InnerText = currentContact.WebAddress;
                xmlContact.AppendChild(xmlWebAddress);

                XmlNode xmlNotes = xmlDocument.CreateElement("Notes");
                xmlNotes.InnerText = currentContact.Notes;
                xmlContact.AppendChild(xmlNotes);

                xmlDocument.DocumentElement.AppendChild(xmlContact);
            }
            xmlDocument.Save(filePath);
        }
    }
}
