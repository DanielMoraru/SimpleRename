namespace SimpleRename
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Bt_Browser = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bt_Umbennen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitte eine Datei auswählen";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.textBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox_DragOver);
            // 
            // Bt_Browser
            // 
            this.Bt_Browser.Location = new System.Drawing.Point(434, 25);
            this.Bt_Browser.Name = "Bt_Browser";
            this.Bt_Browser.Size = new System.Drawing.Size(120, 24);
            this.Bt_Browser.TabIndex = 2;
            this.Bt_Browser.Text = "Browser";
            this.Bt_Browser.UseVisualStyleBackColor = true;
            this.Bt_Browser.Click += new System.EventHandler(this.Bt_Browser_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 138);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(542, 203);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(416, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wie soll die Datei heißen";
            // 
            // Bt_Umbennen
            // 
            this.Bt_Umbennen.Location = new System.Drawing.Point(434, 89);
            this.Bt_Umbennen.Name = "Bt_Umbennen";
            this.Bt_Umbennen.Size = new System.Drawing.Size(120, 23);
            this.Bt_Umbennen.TabIndex = 6;
            this.Bt_Umbennen.Text = "Umbennen";
            this.Bt_Umbennen.UseVisualStyleBackColor = true;
            this.Bt_Umbennen.Click += new System.EventHandler(this.Bt_Umbennen_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 353);
            this.Controls.Add(this.Bt_Umbennen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Bt_Browser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Simple Renamer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button Bt_Browser;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private Label label2;
        private Button Bt_Umbennen;
    }
}