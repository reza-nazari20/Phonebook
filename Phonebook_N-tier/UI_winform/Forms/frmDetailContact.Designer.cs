namespace UI_winform.Forms
{
    partial class frmDetailContact
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
            label6 = new Label();
            label7 = new Label();
            lblID = new Label();
            lblName = new Label();
            lblLastname = new Label();
            lblCompany = new Label();
            lblPhonenumber = new Label();
            lblCreateAt = new Label();
            lblDescription = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(437, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 34);
            label1.TabIndex = 0;
            label1.Text = "شناسه :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 34);
            label2.TabIndex = 1;
            label2.Text = "نام :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 135);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 34);
            label3.TabIndex = 2;
            label3.Text = "نام خانوادگی :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 201);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 34);
            label4.TabIndex = 3;
            label4.Text = "شرکت :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 279);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 34);
            label5.TabIndex = 4;
            label5.Text = "شماره تلفن :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(411, 345);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 34);
            label6.TabIndex = 5;
            label6.Text = "تاریخ ثبت :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(411, 413);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(83, 34);
            label7.TabIndex = 6;
            label7.Text = "توضیحات :";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(119, 18);
            lblID.Margin = new Padding(4, 0, 4, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(64, 34);
            lblID.TabIndex = 7;
            lblID.Text = "label8";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(119, 70);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 34);
            lblName.TabIndex = 8;
            lblName.Text = "label9";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(111, 135);
            lblLastname.Margin = new Padding(4, 0, 4, 0);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(72, 34);
            lblLastname.TabIndex = 9;
            lblLastname.Text = "label10";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new Point(111, 201);
            lblCompany.Margin = new Padding(4, 0, 4, 0);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(72, 34);
            lblCompany.TabIndex = 10;
            lblCompany.Text = "label11";
            // 
            // lblPhonenumber
            // 
            lblPhonenumber.AutoSize = true;
            lblPhonenumber.Location = new Point(111, 279);
            lblPhonenumber.Margin = new Padding(4, 0, 4, 0);
            lblPhonenumber.Name = "lblPhonenumber";
            lblPhonenumber.Size = new Size(72, 34);
            lblPhonenumber.TabIndex = 11;
            lblPhonenumber.Text = "label12";
            // 
            // lblCreateAt
            // 
            lblCreateAt.AutoSize = true;
            lblCreateAt.Location = new Point(111, 345);
            lblCreateAt.Margin = new Padding(4, 0, 4, 0);
            lblCreateAt.Name = "lblCreateAt";
            lblCreateAt.Size = new Size(72, 34);
            lblCreateAt.TabIndex = 12;
            lblCreateAt.Text = "label13";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(111, 413);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(72, 34);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "label14";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("B Zar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnBack.Location = new Point(12, 477);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(490, 67);
            btnBack.TabIndex = 14;
            btnBack.Text = "بازگشت";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmDetailContact
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 561);
            Controls.Add(btnBack);
            Controls.Add(lblDescription);
            Controls.Add(lblCreateAt);
            Controls.Add(lblPhonenumber);
            Controls.Add(lblCompany);
            Controls.Add(lblLastname);
            Controls.Add(lblName);
            Controls.Add(lblID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("B Zar", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Margin = new Padding(5);
            Name = "frmDetailContact";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "مشخصات مخاطب";
            Load += frmDetailContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblID;
        private Label lblName;
        private Label lblLastname;
        private Label lblCompany;
        private Label lblPhonenumber;
        private Label lblCreateAt;
        private Label lblDescription;
        private Button btnBack;
    }
}