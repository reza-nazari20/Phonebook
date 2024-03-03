namespace UI_winform.Forms
{
    partial class frmEditContact
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
            btnBack = new Button();
            btnSaveEdit = new Button();
            txtDescription = new TextBox();
            txtPhonenumber = new TextBox();
            txtCompany = new TextBox();
            txtLastname = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightCoral;
            btnBack.Font = new Font("B Zar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnBack.Location = new Point(43, 509);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(149, 54);
            btnBack.TabIndex = 23;
            btnBack.Text = "بازگشت";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.BackColor = Color.LightGreen;
            btnSaveEdit.Font = new Font("B Zar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnSaveEdit.Location = new Point(393, 509);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new Size(321, 54);
            btnSaveEdit.TabIndex = 22;
            btnSaveEdit.Text = "ثبت تغییرات";
            btnSaveEdit.UseVisualStyleBackColor = false;
            btnSaveEdit.Click += btnSaveEdit_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 302);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(520, 137);
            txtDescription.TabIndex = 21;
            // 
            // txtPhonenumber
            // 
            txtPhonenumber.Location = new Point(12, 236);
            txtPhonenumber.Name = "txtPhonenumber";
            txtPhonenumber.Size = new Size(520, 37);
            txtPhonenumber.TabIndex = 20;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(12, 169);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(520, 37);
            txtCompany.TabIndex = 19;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(12, 91);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(520, 37);
            txtLastname.TabIndex = 18;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(520, 37);
            txtName.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(671, 309);
            label5.Name = "label5";
            label5.Size = new Size(75, 30);
            label5.TabIndex = 16;
            label5.Text = "توضیحات :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(665, 239);
            label4.Name = "label4";
            label4.Size = new Size(79, 30);
            label4.TabIndex = 15;
            label4.Text = "شماره تلفن :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(670, 172);
            label3.Name = "label3";
            label3.Size = new Size(58, 30);
            label3.TabIndex = 14;
            label3.Text = "شرکت :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(652, 94);
            label2.Name = "label2";
            label2.Size = new Size(92, 30);
            label2.TabIndex = 13;
            label2.Text = "نام خانوادگی :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(696, 26);
            label1.Name = "label1";
            label1.Size = new Size(34, 30);
            label1.TabIndex = 12;
            label1.Text = "نام :";
            // 
            // frmEditContact
            // 
            AutoScaleDimensions = new SizeF(10F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 602);
            Controls.Add(btnBack);
            Controls.Add(btnSaveEdit);
            Controls.Add(txtDescription);
            Controls.Add(txtPhonenumber);
            Controls.Add(txtCompany);
            Controls.Add(txtLastname);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("B Zar", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Margin = new Padding(4);
            Name = "frmEditContact";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmEditContact";
            Load += frmEditContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnSaveEdit;
        private TextBox txtDescription;
        private TextBox txtPhonenumber;
        private TextBox txtCompany;
        private TextBox txtLastname;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}