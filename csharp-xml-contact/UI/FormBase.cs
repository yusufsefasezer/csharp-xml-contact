using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace csharp_xml_contact
{
    public partial class FormBase : Form
    {
        public List<Contact> contactList = null;
        public string xmlFile = null;

        protected FormBase()
        {
            InitializeComponent();
            contactList = new List<Contact>();
            xmlFile = @"contact-list.xml";
            CheckFile(xmlFile);
            LoadData(xmlFile);
        }

        private void CheckFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                CreateXmlFile(filePath);
            }
        }

        protected virtual void CreateXmlFile(string filePath)
        {
            // Create XML file
        }

        protected virtual void LoadData(string filePath)
        {
            // Load XML file
        }

        protected virtual void SaveData(string filePath)
        {
            // Save XML file
        }

        protected void FillContactList()
        {
            foreach (Contact currentContact in contactList)
            {
                string FullName = currentContact.FirstName + " " + currentContact.LastName;
                listBox_contactList.Items.Add(FullName);
            }
        }

        private void AddContact(object sender, EventArgs e)
        {
            contactList.Add(new Contact
            {
                FirstName = textBox_firstName.Text,
                LastName = textBox_lastName.Text,
                Email = textBox_email.Text,
                PhoneNumber = textBox_phoneNumber.Text,
                Address = textBox_address.Text,
                WebAddress = textBox_webAddress.Text,
                Notes = textBox_notes.Text
            });
            string FullName = textBox_firstName.Text + " " + textBox_lastName.Text;
            listBox_contactList.Items.Add(FullName);
            ResetInput();
        }

        private void ResetInput()
        {
            textBox_firstName.Clear();
            textBox_lastName.Clear();
            textBox_email.Clear();
            textBox_phoneNumber.Clear();
            textBox_webAddress.Clear();
            textBox_address.Clear();
            textBox_notes.Clear();
        }

        private void UpdateContact(object sender, EventArgs e)
        {
            if (listBox_contactList.SelectedItems.Count == 0) return;
            int selectedIndex = listBox_contactList.SelectedIndex;
            Contact selectedContact = contactList[selectedIndex];
            selectedContact.FirstName = textBox_firstName.Text;
            selectedContact.LastName = textBox_lastName.Text;
            selectedContact.Email = textBox_email.Text;
            selectedContact.PhoneNumber = textBox_phoneNumber.Text;
            selectedContact.WebAddress = textBox_webAddress.Text;
            selectedContact.Address = textBox_address.Text;
            selectedContact.Notes = textBox_notes.Text;
            string FullName = textBox_firstName.Text + " " + textBox_lastName.Text;
            listBox_contactList.Items[selectedIndex] = FullName;
        }

        private void RemoveContact(object sender, EventArgs e)
        {
            if (listBox_contactList.SelectedItems.Count == 0) return;
            int selectedIndex = listBox_contactList.SelectedIndex;
            listBox_contactList.Items.RemoveAt(selectedIndex);
            contactList.RemoveAt(selectedIndex);
            ResetInput();
        }

        private void ChangeContact(object sender, EventArgs e)
        {
            if (listBox_contactList.SelectedItems.Count == 0) return;
            Contact selectedContact = contactList[listBox_contactList.SelectedIndex];
            textBox_firstName.Text = selectedContact.FirstName;
            textBox_lastName.Text = selectedContact.LastName;
            textBox_email.Text = selectedContact.Email;
            textBox_phoneNumber.Text = selectedContact.PhoneNumber;
            textBox_webAddress.Text = selectedContact.WebAddress;
            textBox_address.Text = selectedContact.Address;
            textBox_notes.Text = selectedContact.Notes;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveData(xmlFile);
            base.OnFormClosing(e);
        }
    }
}
