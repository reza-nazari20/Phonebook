namespace UI_winform.Forms
{
    partial class frmAddContact
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtLastname = new TextBox();
            txtCompany = new TextBox();
            txtPhonenumber = new TextBox();
            txtDescription = new TextBox();
            btnAdd = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(710, 29);
            label1.Name = "label1";
            label1.Size = new Size(38, 34);
            label1.TabIndex = 0;
            label1.Text = "نام :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(666, 97);
            label2.Name = "label2";
            label2.Size = new Size(101, 34);
            label2.TabIndex = 1;
            label2.Text = "نام خانوادگی :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(684, 175);
            label3.Name = "label3";
            label3.Size = new Size(65, 34);
            label3.TabIndex = 2;
            label3.Text = "شرکت :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(679, 242);
            label4.Name = "label4";
            label4.Size = new Size(88, 34);
            label4.TabIndex = 3;
            label4.Text = "شماره تلفن :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(685, 312);
            label5.Name = "label5";
            label5.Size = new Size(83, 34);
            label5.TabIndex = 4;
            label5.Text = "توضیحات :";
            // 
            // txtName
            // 
            txtName.Location = new Point(26, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(520, 41);
            txtName.TabIndex = 5;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(26, 94);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(520, 41);
            txtLastname.TabIndex = 6;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(26, 172);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(520, 41);
            txtCompany.TabIndex = 7;
            // 
            // txtPhonenumber
            // 
            txtPhonenumber.Location = new Point(26, 239);
            txtPhonenumber.Name = "txtPhonenumber";
            txtPhonenumber.Size = new Size(520, 41);
            txtPhonenumber.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(26, 305);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(520, 137);
            txtDescription.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Font = new Font("B Zar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnAdd.Location = new Point(407, 512);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(321, 54);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "ثبت مخاطب";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightCoral;
            btnBack.Font = new Font("B Zar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnBack.Location = new Point(57, 512);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(149, 54);
            btnBack.TabIndex = 11;
            btnBack.Text = "بازگشت";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmAddContact
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 588);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
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
            Font = new Font("B Zar", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAddContact";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "اضافه کردن مخاطب";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtLastname;
        private TextBox txtCompany;
        private TextBox txtPhonenumber;
        private TextBox txtDescription;
        private Button btnAdd;
        private Button btnBack;
    }
}