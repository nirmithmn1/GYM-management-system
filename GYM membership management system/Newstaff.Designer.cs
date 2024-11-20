namespace WindowsFormsApp1
{
    partial class Newstaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Newstaff));
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.btnmale = new System.Windows.Forms.RadioButton();
            this.btnfemale = new System.Windows.Forms.RadioButton();
            this.datetimepickerDOB = new System.Windows.Forms.DateTimePicker();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtstate = new System.Windows.Forms.TextBox();
            this.Datetimepickerjoindate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(153, 124);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(100, 22);
            this.txtfname.TabIndex = 0;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(153, 174);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(100, 22);
            this.txtlname.TabIndex = 1;
            this.txtlname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnmale
            // 
            this.btnmale.AutoSize = true;
            this.btnmale.Location = new System.Drawing.Point(115, 239);
            this.btnmale.Name = "btnmale";
            this.btnmale.Size = new System.Drawing.Size(58, 20);
            this.btnmale.TabIndex = 2;
            this.btnmale.TabStop = true;
            this.btnmale.Text = "Male";
            this.btnmale.UseVisualStyleBackColor = true;
            // 
            // btnfemale
            // 
            this.btnfemale.AutoSize = true;
            this.btnfemale.Location = new System.Drawing.Point(179, 237);
            this.btnfemale.Name = "btnfemale";
            this.btnfemale.Size = new System.Drawing.Size(74, 20);
            this.btnfemale.TabIndex = 3;
            this.btnfemale.TabStop = true;
            this.btnfemale.Text = "Female";
            this.btnfemale.UseVisualStyleBackColor = true;
            // 
            // datetimepickerDOB
            // 
            this.datetimepickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimepickerDOB.Location = new System.Drawing.Point(136, 292);
            this.datetimepickerDOB.Name = "datetimepickerDOB";
            this.datetimepickerDOB.Size = new System.Drawing.Size(117, 22);
            this.datetimepickerDOB.TabIndex = 4;
            // 
            // txtmobile
            // 
            this.txtmobile.Location = new System.Drawing.Point(136, 358);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(100, 22);
            this.txtmobile.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(501, 122);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 22);
            this.txtemail.TabIndex = 6;
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(498, 290);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(100, 22);
            this.txtcity.TabIndex = 7;
            // 
            // txtstate
            // 
            this.txtstate.Location = new System.Drawing.Point(501, 234);
            this.txtstate.Name = "txtstate";
            this.txtstate.Size = new System.Drawing.Size(100, 22);
            this.txtstate.TabIndex = 8;
            // 
            // Datetimepickerjoindate
            // 
            this.Datetimepickerjoindate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datetimepickerjoindate.Location = new System.Drawing.Point(498, 172);
            this.Datetimepickerjoindate.Name = "Datetimepickerjoindate";
            this.Datetimepickerjoindate.Size = new System.Drawing.Size(117, 22);
            this.Datetimepickerjoindate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Date of Birth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Mobile no";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Join Date ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(386, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "State";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(386, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "City";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnsave.Location = new System.Drawing.Point(219, 411);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(79, 35);
            this.btnsave.TabIndex = 29;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.Crimson;
            this.btnreset.Location = new System.Drawing.Point(304, 411);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(79, 35);
            this.btnreset.TabIndex = 28;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // Newstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 484);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datetimepickerjoindate);
            this.Controls.Add(this.txtstate);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.datetimepickerDOB);
            this.Controls.Add(this.btnfemale);
            this.Controls.Add(this.btnmale);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Name = "Newstaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Newstaff";
            this.Load += new System.EventHandler(this.Newstaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.RadioButton btnmale;
        private System.Windows.Forms.RadioButton btnfemale;
        private System.Windows.Forms.DateTimePicker datetimepickerDOB;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtstate;
        private System.Windows.Forms.DateTimePicker Datetimepickerjoindate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnreset;
    }
}