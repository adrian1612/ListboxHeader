namespace ListboxHeader
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
            this.lboutput = new System.Windows.Forms.ListBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lboutput
            // 
            this.lboutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboutput.FormattingEnabled = true;
            this.lboutput.Location = new System.Drawing.Point(4, 164);
            this.lboutput.Name = "lboutput";
            this.lboutput.Size = new System.Drawing.Size(631, 238);
            this.lboutput.TabIndex = 0;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(546, 128);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 1;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtfname
            // 
            this.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfname.Location = new System.Drawing.Point(309, 37);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(231, 20);
            this.txtfname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Middle name";
            // 
            // txtmn
            // 
            this.txtmn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmn.Location = new System.Drawing.Point(309, 84);
            this.txtmn.Name = "txtmn";
            this.txtmn.Size = new System.Drawing.Size(231, 20);
            this.txtmn.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last name";
            // 
            // txtlname
            // 
            this.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlname.Location = new System.Drawing.Point(309, 131);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(231, 20);
            this.txtlname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // txtpass
            // 
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpass.Location = new System.Drawing.Point(12, 131);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(231, 20);
            this.txtpass.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Username";
            // 
            // txtuser
            // 
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.Location = new System.Drawing.Point(12, 84);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(231, 20);
            this.txtuser.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Location = new System.Drawing.Point(12, 37);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(231, 20);
            this.txtid.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.lboutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboutput;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
    }
}

