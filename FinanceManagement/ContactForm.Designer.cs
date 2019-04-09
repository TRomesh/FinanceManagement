namespace FinanceManagement
{
    partial class ContactForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctype = new System.Windows.Forms.TextBox();
            this.cname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contactGridView = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.cemail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ctype);
            this.groupBox1.Controls.Add(this.cname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Details";
            // 
            // cemail
            // 
            this.cemail.Location = new System.Drawing.Point(116, 102);
            this.cemail.Name = "cemail";
            this.cemail.Size = new System.Drawing.Size(193, 20);
            this.cemail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // ctype
            // 
            this.ctype.Location = new System.Drawing.Point(116, 63);
            this.ctype.Name = "ctype";
            this.ctype.Size = new System.Drawing.Size(193, 20);
            this.ctype.TabIndex = 1;
            // 
            // cname
            // 
            this.cname.Location = new System.Drawing.Point(116, 20);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(193, 20);
            this.cname.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.contactGridView);
            this.groupBox2.Location = new System.Drawing.Point(13, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Tables";
            // 
            // contactGridView
            // 
            this.contactGridView.AllowUserToDeleteRows = false;
            this.contactGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactGridView.Location = new System.Drawing.Point(25, 37);
            this.contactGridView.Name = "contactGridView";
            this.contactGridView.ReadOnly = true;
            this.contactGridView.Size = new System.Drawing.Size(580, 180);
            this.contactGridView.TabIndex = 0;
            this.contactGridView.DoubleClick += new System.EventHandler(this.DoubleClickContact);
            // 
            // btnupdate
            // 
            this.btnupdate.Image = global::FinanceManagement.Properties.Resources.exchange;
            this.btnupdate.Location = new System.Drawing.Point(391, 108);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 24);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Update";
            this.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.Update);
            // 
            // btndelete
            // 
            this.btndelete.Image = global::FinanceManagement.Properties.Resources.trash;
            this.btndelete.Location = new System.Drawing.Point(391, 79);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.Delete);
            // 
            // btncancel
            // 
            this.btncancel.Image = global::FinanceManagement.Properties.Resources.cancel;
            this.btncancel.Location = new System.Drawing.Point(391, 46);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 27);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.Cancel);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::FinanceManagement.Properties.Resources.save;
            this.btnsave.Location = new System.Drawing.Point(391, 17);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.Save);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ContactForm";
            this.Text = "ContactForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contactGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox cemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctype;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView contactGridView;
    }
}