namespace reminderthing
{
    partial class Reminderer
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
            aa = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // aa
            // 
            aa.AutoSize = true;
            aa.Font = new Font("Segoe UI", 28F);
            aa.Location = new Point(22, 9);
            aa.Name = "aa";
            aa.Size = new Size(293, 51);
            aa.TabIndex = 0;
            aa.Text = "Add a reminder!";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 100);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(303, 42);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(40, 177);
            button1.Name = "button1";
            button1.Size = new Size(231, 23);
            button1.TabIndex = 2;
            button1.Text = "Add a reminder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Reminderer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 224);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(aa);
            Name = "Reminderer";
            Text = "Reminderer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label aa;
        private RichTextBox richTextBox1;
        private Button button1;
    }
}
