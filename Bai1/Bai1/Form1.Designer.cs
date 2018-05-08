namespace Bai1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxsender = new System.Windows.Forms.TextBox();
            this.buttonsend = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxsubject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxbody = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sender:";
            // 
            // textBoxsender
            // 
            this.textBoxsender.Location = new System.Drawing.Point(62, 32);
            this.textBoxsender.Name = "textBoxsender";
            this.textBoxsender.Size = new System.Drawing.Size(247, 20);
            this.textBoxsender.TabIndex = 1;
            // 
            // buttonsend
            // 
            this.buttonsend.Location = new System.Drawing.Point(429, 415);
            this.buttonsend.Name = "buttonsend";
            this.buttonsend.Size = new System.Drawing.Size(75, 23);
            this.buttonsend.TabIndex = 2;
            this.buttonsend.Text = "Send";
            this.buttonsend.UseVisualStyleBackColor = true;
            this.buttonsend.Click += new System.EventHandler(this.buttonsend_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(62, 81);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(247, 20);
            this.textBoxPass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pass:";
            // 
            // textBoxto
            // 
            this.textBoxto.Location = new System.Drawing.Point(62, 134);
            this.textBoxto.Name = "textBoxto";
            this.textBoxto.Size = new System.Drawing.Size(247, 20);
            this.textBoxto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To:";
            // 
            // textBoxsubject
            // 
            this.textBoxsubject.Location = new System.Drawing.Point(62, 171);
            this.textBoxsubject.Name = "textBoxsubject";
            this.textBoxsubject.Size = new System.Drawing.Size(442, 20);
            this.textBoxsubject.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subject:";
            // 
            // textBoxbody
            // 
            this.textBoxbody.Location = new System.Drawing.Point(62, 208);
            this.textBoxbody.Multiline = true;
            this.textBoxbody.Name = "textBoxbody";
            this.textBoxbody.Size = new System.Drawing.Size(442, 199);
            this.textBoxbody.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Body:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.textBoxbody);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxsubject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonsend);
            this.Controls.Add(this.textBoxsender);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SendMail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxsender;
        private System.Windows.Forms.Button buttonsend;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxsubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxbody;
        private System.Windows.Forms.Label label5;
    }
}

