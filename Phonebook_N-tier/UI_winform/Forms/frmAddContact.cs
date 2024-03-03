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
    public partial class frmAddContact : Form
    {
        private readonly ContactService contactService;
        public frmAddContact()
        {
            InitializeComponent();
            contactService = new ContactService();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = contactService.AddNewContact(new BLL.Dto.AddNewContactDto()
            {
                Company = txtCompany.Text,
                Name = txtName.Text,
                Lastname = txtLastname.Text,
                PhoneNumber = txtPhonenumber.Text,
                Description = txtDescription.Text,
            });
            if (result.IsSuccess)
            {
                MessageBox.Show(result.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
