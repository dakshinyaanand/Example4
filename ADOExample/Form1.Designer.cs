namespace ADOExample
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
            this.components = new System.ComponentModel.Container();
            this.lblname = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblmembership = new System.Windows.Forms.Label();
            this.lblshopping = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.rbfree = new System.Windows.Forms.RadioButton();
            this.rbpaid = new System.Windows.Forms.RadioButton();
            this.clbshop = new System.Windows.Forms.CheckedListBox();
            this.cbcod = new System.Windows.Forms.CheckBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.lbselect = new System.Windows.Forms.ListBox();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.registerShoppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingDBDataSet = new ADOExample.TrainingDBDataSet();
            this.btndelete = new System.Windows.Forms.Button();
            this.registerShoppingTableAdapter = new ADOExample.TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblname.Location = new System.Drawing.Point(82, 68);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(61, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter name";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblgender.Location = new System.Drawing.Point(82, 100);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(76, 13);
            this.lblgender.TabIndex = 1;
            this.lblgender.Text = "Select gender ";
            this.lblgender.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblmembership
            // 
            this.lblmembership.AutoSize = true;
            this.lblmembership.Location = new System.Drawing.Point(82, 137);
            this.lblmembership.Name = "lblmembership";
            this.lblmembership.Size = new System.Drawing.Size(97, 13);
            this.lblmembership.TabIndex = 2;
            this.lblmembership.Text = "Select Membership";
            // 
            // lblshopping
            // 
            this.lblshopping.AutoSize = true;
            this.lblshopping.Location = new System.Drawing.Point(82, 171);
            this.lblshopping.Name = "lblshopping";
            this.lblshopping.Size = new System.Drawing.Size(139, 13);
            this.lblshopping.TabIndex = 3;
            this.lblshopping.Text = "Select Shopping perference";
            this.lblshopping.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(82, 312);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(57, 13);
            this.lblcod.TabIndex = 4;
            this.lblcod.Text = "pefer COD";
            this.lblcod.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(82, 352);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(81, 13);
            this.lblpassword.TabIndex = 5;
            this.lblpassword.Text = "Enter Password";
            this.lblpassword.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(251, 60);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(182, 20);
            this.txtname.TabIndex = 6;
            // 
            // cbgender
            // 
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(251, 91);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(137, 21);
            this.cbgender.TabIndex = 7;
            this.cbgender.SelectedIndexChanged += new System.EventHandler(this.cbgender_SelectedIndexChanged);
            // 
            // rbfree
            // 
            this.rbfree.AutoSize = true;
            this.rbfree.Location = new System.Drawing.Point(251, 132);
            this.rbfree.Name = "rbfree";
            this.rbfree.Size = new System.Drawing.Size(46, 17);
            this.rbfree.TabIndex = 8;
            this.rbfree.TabStop = true;
            this.rbfree.Text = "Free";
            this.rbfree.UseVisualStyleBackColor = true;
            // 
            // rbpaid
            // 
            this.rbpaid.AutoSize = true;
            this.rbpaid.Location = new System.Drawing.Point(387, 132);
            this.rbpaid.Name = "rbpaid";
            this.rbpaid.Size = new System.Drawing.Size(46, 17);
            this.rbpaid.TabIndex = 9;
            this.rbpaid.TabStop = true;
            this.rbpaid.Text = "Paid";
            this.rbpaid.UseVisualStyleBackColor = true;
            this.rbpaid.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // clbshop
            // 
            this.clbshop.FormattingEnabled = true;
            this.clbshop.Items.AddRange(new object[] {
            "Cosmectics",
            "shoes",
            "Mobiles",
            "laptops",
            "Electronic gadgets",
            "Apparels",
            "kitchen Items"});
            this.clbshop.Location = new System.Drawing.Point(251, 171);
            this.clbshop.Name = "clbshop";
            this.clbshop.Size = new System.Drawing.Size(182, 94);
            this.clbshop.TabIndex = 10;
            this.clbshop.SelectedIndexChanged += new System.EventHandler(this.clbshop_SelectedIndexChanged);
            // 
            // cbcod
            // 
            this.cbcod.AutoSize = true;
            this.cbcod.Location = new System.Drawing.Point(251, 308);
            this.cbcod.Name = "cbcod";
            this.cbcod.Size = new System.Drawing.Size(55, 17);
            this.cbcod.TabIndex = 11;
            this.cbcod.Text = "COD?";
            this.cbcod.UseVisualStyleBackColor = true;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(273, 331);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(182, 20);
            this.txtpassword.TabIndex = 12;
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(146, 388);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(75, 23);
            this.btnregister.TabIndex = 13;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(251, 388);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 14;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // lbselect
            // 
            this.lbselect.FormattingEnabled = true;
            this.lbselect.Location = new System.Drawing.Point(734, 60);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(192, 238);
            this.lbselect.TabIndex = 15;
            // 
            // cbId
            // 
            this.cbId.DataSource = this.registerShoppingBindingSource;
            this.cbId.DisplayMember = "Name";
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(251, 27);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(121, 21);
            this.cbId.TabIndex = 16;
            this.cbId.ValueMember = "Id";
            // 
            // registerShoppingBindingSource
            // 
            this.registerShoppingBindingSource.DataMember = "RegisterShopping";
            this.registerShoppingBindingSource.DataSource = this.trainingDBDataSet;
            // 
            // trainingDBDataSet
            // 
            this.trainingDBDataSet.DataSetName = "TrainingDBDataSet";
            this.trainingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(358, 388);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // registerShoppingTableAdapter
            // 
            this.registerShoppingTableAdapter.ClearBeforeFill = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(485, 388);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 23;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1011, 436);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.cbId);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.cbcod);
            this.Controls.Add(this.clbshop);
            this.Controls.Add(this.rbpaid);
            this.Controls.Add(this.rbfree);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.lblshopping);
            this.Controls.Add(this.lblmembership);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblmembership;
        private System.Windows.Forms.Label lblshopping;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.RadioButton rbfree;
        private System.Windows.Forms.RadioButton rbpaid;
        private System.Windows.Forms.CheckedListBox clbshop;
        private System.Windows.Forms.CheckBox cbcod;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.ListBox lbselect;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Button btndelete;
        private TrainingDBDataSet trainingDBDataSet;
        private System.Windows.Forms.BindingSource registerShoppingBindingSource;
        private TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter registerShoppingTableAdapter;
        private System.Windows.Forms.Button btnupdate;
    }
}

