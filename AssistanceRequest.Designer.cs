namespace SkProjectEdP
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
            label1 = new Label();
            button1 = new Button();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 102);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 3;
            label1.Text = "Send A Reqest:";
            label1.Click += this.label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(207, 136);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Send Request ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "Financial";
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Financial ", "Educational ", "Medical ", "Sports ", "Other" });
            comboBox2.Location = new Point(207, 102);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 6;
            comboBox2.ValueMember = "5";
            comboBox2.SelectedIndexChanged += this.comboBox2_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private ComboBox comboBox2;
    }
}