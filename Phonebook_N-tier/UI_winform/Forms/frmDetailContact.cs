using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_winform.Forms
{
    public partial class frmDetailContact : Form
    {
        private readonly ContactService contactService;
        private readonly int ContactId;
        public frmDetailContact(int ContactId)
        {
            InitializeComponent();
            contactService = new ContactService();
            this.ContactId = ContactId;
        }

        private void frmDetailContact_Load(object sender, EventArgs e)
        {
            var contact = contactService.GetContactDetail(ContactId);
            if (contact.IsSuccess == false)
            {
                MessageBox.Show(contact.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblID.Text = contact.Data.ID.ToString();
            lblName.Text = contact.Data.Name;
            lblLastname.Text = contact.Data.Lastname;
            lblCompany.Text = contact.Data.Company;
            lblPhonenumber.Text = contact.Data.PhoneNumber;
            lblDescription.Text = contact.Data.Description;
            lblCreateAt.Text = contact.Data.CreateAt.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
