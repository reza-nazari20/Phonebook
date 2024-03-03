using BLL.Services;

namespace UI_winform.Forms
{
    public partial class frmEditContact : Form
    {
        private readonly ContactService contactService;
        private readonly int contactId;
        public frmEditContact(int contactId)
        {
            InitializeComponent();
            contactService = new ContactService();
            this.contactId = contactId;
        }

        private void frmEditContact_Load(object sender, EventArgs e)
        {
            var contact = contactService.GetContactDetail(contactId);

            if (contact.IsSuccess == false)
            {
                MessageBox.Show(contact.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtName.Text = contact.Data.Name;
                txtLastname.Text = contact.Data.Lastname;
                txtPhonenumber.Text = contact.Data.PhoneNumber;
                txtCompany.Text = contact.Data.Company;
                txtDescription.Text = contact.Data.Description;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            var result = contactService.EditeContact(new BLL.Dto.EditeContactDto()
            {
                Name = txtName.Text,
                Lastname = txtLastname.Text,
                PhoneNumber = txtPhonenumber.Text,
                Company = txtCompany.Text,
                Description = txtDescription.Text,
            });

            if (result.IsSuccess)
            {
                MessageBox.Show(result.Message,"هشدار",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message,"هشدار",MessageBoxButtons.OK,MessageBoxIcon.Warning
                    
                    
                    );
            }
        }
    }
}
