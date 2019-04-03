namespace csharp_xml_contact
{
    partial class FormBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.groupBox_contacts = new System.Windows.Forms.GroupBox();
            this.listBox_contactList = new System.Windows.Forms.ListBox();
            this.groupBox_information = new System.Windows.Forms.GroupBox();
            this.button_new = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.textBox_notes = new System.Windows.Forms.TextBox();
            this.label_notes = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.textBox_webAddress = new System.Windows.Forms.TextBox();
            this.label_webAddress = new System.Windows.Forms.Label();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.label_phoneNumber = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.label_lastName = new System.Windows.Forms.Label();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.label_firstName = new System.Windows.Forms.Label();
            this.groupBox_contacts.SuspendLayout();
            this.groupBox_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_contacts
            // 
            this.groupBox_contacts.Controls.Add(this.listBox_contactList);
            this.groupBox_contacts.Location = new System.Drawing.Point(10, 5);
            this.groupBox_contacts.Name = "groupBox_contacts";
            this.groupBox_contacts.Size = new System.Drawing.Size(150, 300);
            this.groupBox_contacts.TabIndex = 1;
            this.groupBox_contacts.TabStop = false;
            this.groupBox_contacts.Text = "Contacts";
            // 
            // listBox_contactList
            // 
            this.listBox_contactList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_contactList.FormattingEnabled = true;
            this.listBox_contactList.Location = new System.Drawing.Point(3, 16);
            this.listBox_contactList.Name = "listBox_contactList";
            this.listBox_contactList.Size = new System.Drawing.Size(144, 281);
            this.listBox_contactList.TabIndex = 0;
            this.listBox_contactList.SelectedIndexChanged += new System.EventHandler(this.ChangeContact);
            // 
            // groupBox_information
            // 
            this.groupBox_information.Controls.Add(this.button_new);
            this.groupBox_information.Controls.Add(this.button_update);
            this.groupBox_information.Controls.Add(this.button_remove);
            this.groupBox_information.Controls.Add(this.textBox_notes);
            this.groupBox_information.Controls.Add(this.label_notes);
            this.groupBox_information.Controls.Add(this.textBox_address);
            this.groupBox_information.Controls.Add(this.label_address);
            this.groupBox_information.Controls.Add(this.textBox_webAddress);
            this.groupBox_information.Controls.Add(this.label_webAddress);
            this.groupBox_information.Controls.Add(this.textBox_phoneNumber);
            this.groupBox_information.Controls.Add(this.label_phoneNumber);
            this.groupBox_information.Controls.Add(this.textBox_email);
            this.groupBox_information.Controls.Add(this.label_email);
            this.groupBox_information.Controls.Add(this.textBox_lastName);
            this.groupBox_information.Controls.Add(this.label_lastName);
            this.groupBox_information.Controls.Add(this.textBox_firstName);
            this.groupBox_information.Controls.Add(this.label_firstName);
            this.groupBox_information.Location = new System.Drawing.Point(170, 5);
            this.groupBox_information.Name = "groupBox_information";
            this.groupBox_information.Size = new System.Drawing.Size(300, 300);
            this.groupBox_information.TabIndex = 0;
            this.groupBox_information.TabStop = false;
            this.groupBox_information.Text = "Contact Information";
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(57, 265);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(75, 23);
            this.button_new.TabIndex = 7;
            this.button_new.Text = "Add";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.AddContact);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(138, 264);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 8;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.UpdateContact);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(219, 264);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 9;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.RemoveContact);
            // 
            // textBox_notes
            // 
            this.textBox_notes.Location = new System.Drawing.Point(94, 209);
            this.textBox_notes.Multiline = true;
            this.textBox_notes.Name = "textBox_notes";
            this.textBox_notes.Size = new System.Drawing.Size(200, 50);
            this.textBox_notes.TabIndex = 6;
            // 
            // label_notes
            // 
            this.label_notes.AutoSize = true;
            this.label_notes.Location = new System.Drawing.Point(49, 209);
            this.label_notes.Name = "label_notes";
            this.label_notes.Size = new System.Drawing.Size(38, 13);
            this.label_notes.TabIndex = 0;
            this.label_notes.Text = "Notes:";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(94, 153);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(200, 50);
            this.textBox_address.TabIndex = 5;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(39, 153);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(48, 13);
            this.label_address.TabIndex = 0;
            this.label_address.Text = "Address:";
            // 
            // textBox_webAddress
            // 
            this.textBox_webAddress.Location = new System.Drawing.Point(94, 127);
            this.textBox_webAddress.Name = "textBox_webAddress";
            this.textBox_webAddress.Size = new System.Drawing.Size(200, 20);
            this.textBox_webAddress.TabIndex = 4;
            // 
            // label_webAddress
            // 
            this.label_webAddress.AutoSize = true;
            this.label_webAddress.Location = new System.Drawing.Point(13, 131);
            this.label_webAddress.Name = "label_webAddress";
            this.label_webAddress.Size = new System.Drawing.Size(74, 13);
            this.label_webAddress.TabIndex = 0;
            this.label_webAddress.Text = "Web Address:";
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(94, 101);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(200, 20);
            this.textBox_phoneNumber.TabIndex = 3;
            // 
            // label_phoneNumber
            // 
            this.label_phoneNumber.AutoSize = true;
            this.label_phoneNumber.Location = new System.Drawing.Point(6, 105);
            this.label_phoneNumber.Name = "label_phoneNumber";
            this.label_phoneNumber.Size = new System.Drawing.Size(81, 13);
            this.label_phoneNumber.TabIndex = 0;
            this.label_phoneNumber.Text = "Phone Number:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(94, 75);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(200, 20);
            this.textBox_email.TabIndex = 2;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(49, 79);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(38, 13);
            this.label_email.TabIndex = 0;
            this.label_email.Text = "E-mail:";
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(94, 49);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(200, 20);
            this.textBox_lastName.TabIndex = 1;
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(26, 53);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(61, 13);
            this.label_lastName.TabIndex = 0;
            this.label_lastName.Text = "Last Name:";
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(94, 23);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(200, 20);
            this.textBox_firstName.TabIndex = 0;
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(27, 27);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(60, 13);
            this.label_firstName.TabIndex = 0;
            this.label_firstName.Text = "First Name:";
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.groupBox_information);
            this.Controls.Add(this.groupBox_contacts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBase";
            this.Text = "XML Contact";
            this.groupBox_contacts.ResumeLayout(false);
            this.groupBox_information.ResumeLayout(false);
            this.groupBox_information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_contacts;
        private System.Windows.Forms.GroupBox groupBox_information;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.Label label_phoneNumber;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.TextBox textBox_notes;
        private System.Windows.Forms.Label label_notes;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.TextBox textBox_webAddress;
        private System.Windows.Forms.Label label_webAddress;
        private System.Windows.Forms.ListBox listBox_contactList;
    }
}

