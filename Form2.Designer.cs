namespace Second
{
    partial class Form2
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
            NameTb = new TextBox();
            DescTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            PriceNum = new NumericUpDown();
            SaveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PriceNum).BeginInit();
            SuspendLayout();
            // 
            // NameTb
            // 
            NameTb.Location = new Point(12, 46);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(100, 23);
            NameTb.TabIndex = 0;
            NameTb.TextChanged += textBox1_TextChanged;
            // 
            // DescTb
            // 
            DescTb.Location = new Point(118, 46);
            DescTb.Name = "DescTb";
            DescTb.Size = new Size(100, 23);
            DescTb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(1829, 547);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 22);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(118, 22);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 5;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(224, 22);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 6;
            label4.Text = "Price";
            // 
            // PriceNum
            // 
            PriceNum.Location = new Point(224, 47);
            PriceNum.Name = "PriceNum";
            PriceNum.Size = new Size(120, 23);
            PriceNum.TabIndex = 7;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(247, 86);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(97, 23);
            SaveBtn.TabIndex = 8;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 121);
            Controls.Add(SaveBtn);
            Controls.Add(PriceNum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DescTb);
            Controls.Add(NameTb);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)PriceNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTb;
        private TextBox DescTb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown PriceNum;
        private Button SaveBtn;
    }
}