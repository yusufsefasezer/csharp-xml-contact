using System;
using System.Xml;

namespace csharp_xml_contact
{
    class FormXmlWriterReader : FormBase
    {
        protected override void CreateXmlFile(string filePath)
        {
            using (XmlWriter xmlWriter = XmlWriter.Create(filePath, new XmlWriterSettings
            {
                Indent = true
            }))
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Contacts");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }
        }

        protected override void LoadData(string filePath)
        {
            using (XmlReader xmlReader = XmlReader.Create(xmlFile))
            {
                while (xmlReader.ReadToFollowing("Contact"))
                {
                    XmlReader childElement = xmlReader.ReadSubtree();
                    childElement.Read();
                    Contact tmpContact = new Contact();
                    while (childElement.Read())
                    {
                        if (childElement.NodeType == XmlNodeType.Element)
                        {
                            switch (childElement.Name)
                            {
                                case "FirstName":
                                    tmpContact.FirstName = childElement.ReadElementContentAsString();
                                    break;
                                case "LastName":
                                    tmpContact.LastName = childElement.ReadElementContentAsString();
                                    break;
                                case "Email":
                                    tmpContact.Email = childElement.ReadElementContentAsString();
                                    break;
                                case "PhoneNumber":
                                    tmpContact.PhoneNumber = childElement.ReadElementContentAsString();
                                    break;
                                case "Address":
                                    tmpContact.Address = childElement.ReadElementContentAsString();
                                    break;
                                case "WebAddress":
                                    tmpContact.WebAddress = childElement.ReadElementContentAsString();
                                    break;
                                case "Notes":
                                    tmpContact.Notes = childElement.ReadElementContentAsString();
                                    break;
                                default:
                                    Console.WriteLine("Grrr.");
                                    break;
                            }
                        }
                    }
                    contactList.Add(tmpContact);
                }
            }
            base.FillContactList();
        }

        protected override void SaveData(string filePath)
        {
            using (XmlWriter xmlWriter = XmlWriter.Create(filePath, new XmlWriterSettings { Indent = true }))
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Contacts");

                foreach (Contact currentContact in contactList)
                {
                    xmlWriter.WriteStartElement("Contact");

                    xmlWriter.WriteStartElement("FirstName");
                    xmlWriter.WriteString(currentContact.FirstName);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("LastName");
                    xmlWriter.WriteString(currentContact.LastName);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Email");
                    xmlWriter.WriteString(currentContact.Email);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("PhoneNumber");
                    xmlWriter.WriteString(currentContact.PhoneNumber);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Address");
                    xmlWriter.WriteString(currentContact.Address);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("WebAddress");
                    xmlWriter.WriteString(currentContact.WebAddress);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Notes");
                    xmlWriter.WriteString(currentContact.Notes);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }
        }
    }
}
