namespace DesktopVoiceAssistant
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.startvoicebtn = new System.Windows.Forms.Button();
            this.endvoicebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(220, 118);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // startvoicebtn
            // 
            this.startvoicebtn.Location = new System.Drawing.Point(12, 227);
            this.startvoicebtn.Name = "startvoicebtn";
            this.startvoicebtn.Size = new System.Drawing.Size(121, 23);
            this.startvoicebtn.TabIndex = 1;
            this.startvoicebtn.Text = "Start Voice Control";
            this.startvoicebtn.UseVisualStyleBackColor = true;
            this.startvoicebtn.Click += new System.EventHandler(this.startvoicebtn_Click);
            // 
            // endvoicebtn
            // 
            this.endvoicebtn.Enabled = false;
            this.endvoicebtn.Location = new System.Drawing.Point(161, 227);
            this.endvoicebtn.Name = "endvoicebtn";
            this.endvoicebtn.Size = new System.Drawing.Size(111, 23);
            this.endvoicebtn.TabIndex = 2;
            this.endvoicebtn.Text = "End Voice Control";
            this.endvoicebtn.UseVisualStyleBackColor = true;
            this.endvoicebtn.Click += new System.EventHandler(this.endvoicebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.endvoicebtn);
            this.Controls.Add(this.startvoicebtn);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button startvoicebtn;
        private System.Windows.Forms.Button endvoicebtn;
    }
}

