using BLL.Dto;
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
    public partial class frmMain : Form
    {
        private readonly ContactService contactService;
        public frmMain()
        {
            InitializeComponent();
            contactService = new ContactService();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var Listcontact = contactService.GetContactLists();
            SettingGridveiw(Listcontact);

            this.Cursor = Cursors.Default;
        }

        private void SettingGridveiw(List<ContactListDto> Listcontact)
        {
            dataGridView1.DataSource = Listcontact;

            dataGridView1.Columns[0].HeaderText = "شناسه";
            dataGridView1.Columns[1].HeaderText = "نام مخاطب";
            dataGridView1.Columns[2].HeaderText = "شماره تلفن";

            dataGridView1.Columns[1].Width = 165;
            dataGridView1.Columns[2].Width = 164;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var listContact = contactService.SearchContact(txtsearchkey.Text);

            SettingGridveiw(listContact);

            this.Cursor = Cursors.Default;
        }
    }
}
