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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(507, 356);
            dataGridView1.TabIndex = 0;
            // 
            // btnsearch
            // 
            btnsearch.Font = new Font("B Zar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnsearch.Location = new Point(355, 61);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(129, 53);
            btnsearch.TabIndex = 1;
            btnsearch.Text = "جستوجو";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtsearchkey
            // 
            txtsearchkey.Location = new Point(38, 70);
            txtsearchkey.Name = "txtsearchkey";
            txtsearchkey.Size = new Size(265, 37);
            txtsearchkey.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 570);
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
    }
}