namespace FinanceManagement
{
    partial class IncomeForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.items_panel = new System.Windows.Forms.Panel();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contacts = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(2, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(789, 206);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 181);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(588, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 214);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Image = global::FinanceManagement.Properties.Resources.plus;
            this.button1.Location = new System.Drawing.Point(17, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Row";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.add_row_Click);
            // 
            // button2
            // 
            this.button2.Image = global::FinanceManagement.Properties.Resources.minus;
            this.button2.Location = new System.Drawing.Point(17, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remove Row";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.remove_row_Click);
            // 
            // button5
            // 
            this.button5.Image = global::FinanceManagement.Properties.Resources.cancel;
            this.button5.Location = new System.Drawing.Point(17, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 25);
            this.button5.TabIndex = 9;
            this.button5.Text = "Cancel";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Image = global::FinanceManagement.Properties.Resources._checked;
            this.button3.Location = new System.Drawing.Point(17, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "Submit";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.submit_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(105, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 8;
            this.button4.Text = "Reset";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.reset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.items_panel);
            this.groupBox1.Controls.Add(this.mainGroupBox);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 214);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // items_panel
            // 
            this.items_panel.Location = new System.Drawing.Point(6, 82);
            this.items_panel.Name = "items_panel";
            this.items_panel.Size = new System.Drawing.Size(568, 126);
            this.items_panel.TabIndex = 8;
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.label3);
            this.mainGroupBox.Controls.Add(this.label2);
            this.mainGroupBox.Controls.Add(this.label1);
            this.mainGroupBox.Controls.Add(this.contacts);
            this.mainGroupBox.Controls.Add(this.description);
            this.mainGroupBox.Controls.Add(this.amount);
            this.mainGroupBox.Location = new System.Drawing.Point(18, 19);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(518, 56);
            this.mainGroupBox.TabIndex = 7;
            this.mainGroupBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Contact";
            // 
            // contacts
            // 
            this.contacts.FormattingEnabled = true;
            this.contacts.Location = new System.Drawing.Point(6, 29);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(150, 21);
            this.contacts.TabIndex = 3;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(359, 30);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(145, 20);
            this.description.TabIndex = 6;
            this.description.Text = "";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(182, 29);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(150, 20);
            this.amount.TabIndex = 5;
            this.amount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 431);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IncomeForm";
            this.Text = "IncomeForm";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox contacts;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel items_panel;
    }
}