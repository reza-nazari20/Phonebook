namespace UI_winform.Forms
{
    partial class frmMain
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
            dataGridView1 = new DataGridView();
            btnsearch = new Button();
            txtsearchkey = new TextBox();
            btndelete = new Button();
            btnDetail = new Button();
            btnAddnewContact = new Button();
            label1 = new Label();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 340);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(544, 368);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // btnsearch
            // 
            btnsearch.Font = new Font("B Zar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnsearch.Location = new Point(12, 187);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(265, 53);
            btnsearch.TabIndex = 1;
            btnsearch.Text = "جستوجو";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtsearchkey
            // 
            txtsearchkey.Location = new Point(12, 126);
            txtsearchkey.Name = "txtsearchkey";
            txtsearchkey.Size = new Size(265, 37);
            txtsearchkey.TabIndex = 2;
            // 
            // btndelete
            // 
            btndelete.Font = new Font("B Zar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btndelete.Location = new Point(352, 164);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(180, 53);
            btndelete.TabIndex = 3;
            btndelete.Text = "حذف";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnDetail
            // 
            btnDetail.Font = new Font("B Zar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnDetail.Location = new Point(352, 239);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(180, 53);
            btnDetail.TabIndex = 4;
            btnDetail.Text = "نمایش جزئیات";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnAddnewContact
            // 
            btnAddnewContact.Font = new Font("B Zar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnAddnewContact.Location = new Point(352, 21);
            btnAddnewContact.Name = "btnAddnewContact";
            btnAddnewContact.Size = new Size(180, 53);
            btnAddnewContact.TabIndex = 5;
            btnAddnewContact.Text = "اضافه کردن مخاطب";
            btnAddnewContact.UseVisualStyleBackColor = true;
            btnAddnewContact.Click += btnAddnewContact_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Zar", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label1.Location = new Point(106, 62);
            label1.Name = "label1";
            label1.Size = new Size(92, 47);
            label1.TabIndex = 6;
            label1.Text = "جستوجو";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("B Zar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnEdit.Location = new Point(352, 89);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(180, 53);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 708);
            Controls.Add(btnEdit);
            Controls.Add(label1);
            Controls.Add(btnAddnewContact);
            Controls.Add(btnDetail);
            Controls.Add(btndelete);
            Controls.Add(txtsearchkey);
            Controls.Add(btnsearch);
            Controls.Add(dataGridView1);
            Font = new Font("B Zar", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "frmMain";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "لیست مخاطبین";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnsearch;
        private TextBox txtsearchkey;
        private Button btndelete;
        private Button btnDetail;
        private Button btnAddnewContact;
        private Label label1;
        private Button btnEdit;
    }
}