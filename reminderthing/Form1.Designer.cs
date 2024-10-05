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
            button2 = new Button();
            listView2 = new ListView();
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
            richTextBox1.Location = new Point(12, 279);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(240, 45);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(383, 9);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 2;
            button1.Text = "Add a new reminder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(594, 9);
            button2.Name = "button2";
            button2.Size = new Size(65, 23);
            button2.TabIndex = 4;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView2
            // 
            listView2.Location = new Point(383, 38);
            listView2.Name = "listView2";
            listView2.Size = new Size(276, 286);
            listView2.TabIndex = 5;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // Reminderer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 327);
            Controls.Add(listView2);
            Controls.Add(button2);
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
        private Button button2;
        private ListView listView2;
    }
}
