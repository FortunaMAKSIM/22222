namespace Second
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
            dataGridView1 = new DataGridView();
            AddBtn = new Button();
            SortBtn = new Button();
            Sort2Btn = new Button();
            Sort3Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(534, 426);
            dataGridView1.TabIndex = 0;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(672, 12);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(116, 42);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // SortBtn
            // 
            SortBtn.Location = new Point(672, 60);
            SortBtn.Name = "SortBtn";
            SortBtn.Size = new Size(116, 42);
            SortBtn.TabIndex = 2;
            SortBtn.Text = "Sort by Name";
            SortBtn.UseVisualStyleBackColor = true;
            SortBtn.Click += SortBtn_Click;
            // 
            // Sort2Btn
            // 
            Sort2Btn.Location = new Point(672, 108);
            Sort2Btn.Name = "Sort2Btn";
            Sort2Btn.Size = new Size(116, 42);
            Sort2Btn.TabIndex = 3;
            Sort2Btn.Text = "Sort by price";
            Sort2Btn.UseVisualStyleBackColor = true;
            Sort2Btn.Click += Sort2Btn_Click;
            // 
            // Sort3Btn
            // 
            Sort3Btn.Location = new Point(672, 156);
            Sort3Btn.Name = "Sort3Btn";
            Sort3Btn.Size = new Size(116, 42);
            Sort3Btn.TabIndex = 4;
            Sort3Btn.Text = "Non sorted";
            Sort3Btn.UseVisualStyleBackColor = true;
            Sort3Btn.Click += Sort3Btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sort3Btn);
            Controls.Add(Sort2Btn);
            Controls.Add(SortBtn);
            Controls.Add(AddBtn);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddBtn;
        private Button SortBtn;
        private Button Sort2Btn;
        private Button Sort3Btn;
    }
}
