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
            this.logtextbox = new System.Windows.Forms.RichTextBox();
            this.startvoicebtn = new System.Windows.Forms.Button();
            this.endvoicebtn = new System.Windows.Forms.Button();
            this.cmdlabel = new System.Windows.Forms.Label();
            this.forecastbtn = new System.Windows.Forms.Button();
            this.loctextbox = new System.Windows.Forms.TextBox();
            this.forecastresultsbox = new System.Windows.Forms.RichTextBox();
            this.ziplabel = new System.Windows.Forms.Label();
            this.citynamebox = new System.Windows.Forms.TextBox();
            this.citynamelabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logtextbox
            // 
            this.logtextbox.Location = new System.Drawing.Point(207, 14);
            this.logtextbox.Name = "logtextbox";
            this.logtextbox.ReadOnly = true;
            this.logtextbox.Size = new System.Drawing.Size(143, 118);
            this.logtextbox.TabIndex = 0;
            this.logtextbox.Text = "";
            // 
            // startvoicebtn
            // 
            this.startvoicebtn.Location = new System.Drawing.Point(11, 347);
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
            this.endvoicebtn.Location = new System.Drawing.Point(239, 347);
            this.endvoicebtn.Name = "endvoicebtn";
            this.endvoicebtn.Size = new System.Drawing.Size(111, 23);
            this.endvoicebtn.TabIndex = 2;
            this.endvoicebtn.Text = "End Voice Control";
            this.endvoicebtn.UseVisualStyleBackColor = true;
            this.endvoicebtn.Click += new System.EventHandler(this.endvoicebtn_Click);
            // 
            // cmdlabel
            // 
            this.cmdlabel.AutoSize = true;
            this.cmdlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdlabel.ForeColor = System.Drawing.Color.Navy;
            this.cmdlabel.Location = new System.Drawing.Point(291, 317);
            this.cmdlabel.Name = "cmdlabel";
            this.cmdlabel.Size = new System.Drawing.Size(59, 13);
            this.cmdlabel.TabIndex = 3;
            this.cmdlabel.Text = "Commands";
            this.cmdlabel.Click += new System.EventHandler(this.cmdlabel_Click);
            // 
            // forecastbtn
            // 
            this.forecastbtn.Location = new System.Drawing.Point(12, 51);
            this.forecastbtn.Name = "forecastbtn";
            this.forecastbtn.Size = new System.Drawing.Size(111, 23);
            this.forecastbtn.TabIndex = 4;
            this.forecastbtn.Text = "Get Forecast";
            this.forecastbtn.UseVisualStyleBackColor = true;
            this.forecastbtn.Click += new System.EventHandler(this.forecastbtn_Click);
            // 
            // loctextbox
            // 
            this.loctextbox.Location = new System.Drawing.Point(11, 25);
            this.loctextbox.Name = "loctextbox";
            this.loctextbox.Size = new System.Drawing.Size(121, 20);
            this.loctextbox.TabIndex = 5;
            // 
            // forecastresultsbox
            // 
            this.forecastresultsbox.Location = new System.Drawing.Point(12, 182);
            this.forecastresultsbox.Name = "forecastresultsbox";
            this.forecastresultsbox.ReadOnly = true;
            this.forecastresultsbox.Size = new System.Drawing.Size(186, 159);
            this.forecastresultsbox.TabIndex = 6;
            this.forecastresultsbox.Text = "";
            // 
            // ziplabel
            // 
            this.ziplabel.AutoSize = true;
            this.ziplabel.Location = new System.Drawing.Point(10, 9);
            this.ziplabel.Name = "ziplabel";
            this.ziplabel.Size = new System.Drawing.Size(52, 13);
            this.ziplabel.TabIndex = 7;
            this.ziplabel.Text = "Enter ZIP";
            // 
            // citynamebox
            // 
            this.citynamebox.Location = new System.Drawing.Point(13, 100);
            this.citynamebox.Name = "citynamebox";
            this.citynamebox.Size = new System.Drawing.Size(120, 20);
            this.citynamebox.TabIndex = 8;
            // 
            // citynamelabel
            // 
            this.citynamelabel.AutoSize = true;
            this.citynamelabel.Location = new System.Drawing.Point(13, 81);
            this.citynamelabel.Name = "citynamelabel";
            this.citynamelabel.Size = new System.Drawing.Size(55, 13);
            this.citynamelabel.TabIndex = 9;
            this.citynamelabel.Text = "City Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Temp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.citynamelabel);
            this.Controls.Add(this.citynamebox);
            this.Controls.Add(this.ziplabel);
            this.Controls.Add(this.forecastresultsbox);
            this.Controls.Add(this.loctextbox);
            this.Controls.Add(this.forecastbtn);
            this.Controls.Add(this.cmdlabel);
            this.Controls.Add(this.endvoicebtn);
            this.Controls.Add(this.startvoicebtn);
            this.Controls.Add(this.logtextbox);
            this.Name = "Form1";
            this.Text = "DVA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox logtextbox;
        private System.Windows.Forms.Button startvoicebtn;
        private System.Windows.Forms.Button endvoicebtn;
        private System.Windows.Forms.Label cmdlabel;
        private System.Windows.Forms.Button forecastbtn;
        private System.Windows.Forms.TextBox loctextbox;
        private System.Windows.Forms.RichTextBox forecastresultsbox;
        private System.Windows.Forms.Label ziplabel;
        private System.Windows.Forms.TextBox citynamebox;
        private System.Windows.Forms.Label citynamelabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

