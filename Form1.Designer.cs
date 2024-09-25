namespace WinFormsApp9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            AddBtn = new Button();
            NameTb = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            QuaTb = new TextBox();
            PriceTb = new TextBox();
            label5 = new Label();
            ManTb = new TextBox();
            UpdateBtn = new Button();
            Dltbtn = new Button();
            CatCb = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 66);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Item Name";
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(133, 383);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(110, 54);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Add Item";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // NameTb
            // 
            NameTb.Location = new Point(52, 118);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(125, 27);
            NameTb.TabIndex = 2;
            NameTb.TextChanged += NameTb_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(68, 512);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(647, 188);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 66);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 66);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 5;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(603, 66);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 6;
            label4.Text = "Price";
            // 
            // QuaTb
            // 
            QuaTb.Location = new Point(406, 118);
            QuaTb.Name = "QuaTb";
            QuaTb.Size = new Size(125, 27);
            QuaTb.TabIndex = 8;
            // 
            // PriceTb
            // 
            PriceTb.Location = new Point(565, 118);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(125, 27);
            PriceTb.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 198);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 10;
            // 
            // ManTb
            // 
            ManTb.Location = new Point(265, 253);
            ManTb.Name = "ManTb";
            ManTb.Size = new Size(210, 27);
            ManTb.TabIndex = 11;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(324, 383);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(110, 54);
            UpdateBtn.TabIndex = 12;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // Dltbtn
            // 
            Dltbtn.Location = new Point(543, 383);
            Dltbtn.Name = "Dltbtn";
            Dltbtn.Size = new Size(110, 54);
            Dltbtn.TabIndex = 13;
            Dltbtn.Text = "Delete";
            Dltbtn.UseVisualStyleBackColor = true;
            Dltbtn.Click += Dltbtn_Click;
            // 
            // CatCb
            // 
            CatCb.FormattingEnabled = true;
            CatCb.Items.AddRange(new object[] { "Building ", "Electical", "Electronic" });
            CatCb.Location = new Point(225, 117);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(151, 28);
            CatCb.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(324, 218);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 15;
            label6.Text = "Manufacturer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 712);
            Controls.Add(label6);
            Controls.Add(CatCb);
            Controls.Add(Dltbtn);
            Controls.Add(UpdateBtn);
            Controls.Add(ManTb);
            Controls.Add(label5);
            Controls.Add(PriceTb);
            Controls.Add(QuaTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(NameTb);
            Controls.Add(AddBtn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddBtn;
        private TextBox NameTb;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox QuaTb;
        private TextBox PriceTb;
        private Label label5;
        private TextBox ManTb;
        private Button UpdateBtn;
        private Button Dltbtn;
        private ComboBox CatCb;
        private Label label6;
    }
}
