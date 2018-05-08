namespace bai2_2
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
            this.label3 = new System.Windows.Forms.Label();
            this.panelweb = new System.Windows.Forms.Panel();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.textBoxmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email mới nhất:";
            // 
            // panelweb
            // 
            this.panelweb.Location = new System.Drawing.Point(15, 96);
            this.panelweb.Name = "panelweb";
            this.panelweb.Size = new System.Drawing.Size(773, 344);
            this.panelweb.TabIndex = 13;
            // 
            // textBoxpass
            // 
            this.textBoxpass.Location = new System.Drawing.Point(373, 15);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.PasswordChar = '*';
            this.textBoxpass.Size = new System.Drawing.Size(183, 20);
            this.textBoxpass.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password:";
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(572, 15);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(75, 23);
            this.buttonsearch.TabIndex = 10;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // textBoxmail
            // 
            this.textBoxmail.Location = new System.Drawing.Point(47, 11);
            this.textBoxmail.Name = "textBoxmail";
            this.textBoxmail.Size = new System.Drawing.Size(230, 20);
            this.textBoxmail.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mail:";
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Location = new System.Drawing.Point(18, 48);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(115, 13);
            this.labelcount.TabIndex = 15;
            this.labelcount.Text = "So tin nhan chua doc: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelcount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelweb);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.textBoxmail);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelweb;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.TextBox textBoxmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelcount;
    }
}

