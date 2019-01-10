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
            this.SuspendLayout();
            // 
            // lboutput
            // 
            this.lboutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboutput.FormattingEnabled = true;
            this.lboutput.ItemHeight = 20;
            this.lboutput.Location = new System.Drawing.Point(12, 164);
            this.lboutput.Name = "lboutput";
            this.lboutput.Size = new System.Drawing.Size(614, 224);
            this.lboutput.TabIndex = 0;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(249, 122);
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
            this.txtfname.Location = new System.Drawing.Point(12, 31);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(231, 20);
            this.txtfname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Middle name";
            // 
            // txtmn
            // 
            this.txtmn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmn.Location = new System.Drawing.Point(12, 78);
            this.txtmn.Name = "txtmn";
            this.txtmn.Size = new System.Drawing.Size(231, 20);
            this.txtmn.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last name";
            // 
            // txtlname
            // 
            this.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlname.Location = new System.Drawing.Point(12, 125);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(231, 20);
            this.txtlname.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 411);
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
    }
}

