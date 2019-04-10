namespace FinanceManagement
{
    partial class EventForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.apdate = new System.Windows.Forms.DateTimePicker();
            this.btnupdateapp = new System.Windows.Forms.Button();
            this.btndeleteapp = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.apdescription = new System.Windows.Forms.TextBox();
            this.aptype = new System.Windows.Forms.TextBox();
            this.apname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appointmentGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tadate = new System.Windows.Forms.DateTimePicker();
            this.btnupdateevn = new System.Windows.Forms.Button();
            this.btndeleteevn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tadescription = new System.Windows.Forms.TextBox();
            this.tatype = new System.Windows.Forms.TextBox();
            this.taname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.taskGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 353);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.appointmentGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(550, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Appointments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.apdate);
            this.groupBox1.Controls.Add(this.btnupdateapp);
            this.groupBox1.Controls.Add(this.btndeleteapp);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.apdescription);
            this.groupBox1.Controls.Add(this.aptype);
            this.groupBox1.Controls.Add(this.apname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Date Time";
            // 
            // apdate
            // 
            this.apdate.Location = new System.Drawing.Point(83, 122);
            this.apdate.Name = "apdate";
            this.apdate.Size = new System.Drawing.Size(200, 20);
            this.apdate.TabIndex = 10;
            // 
            // btnupdateapp
            // 
            this.btnupdateapp.Location = new System.Drawing.Point(317, 113);
            this.btnupdateapp.Name = "btnupdateapp";
            this.btnupdateapp.Size = new System.Drawing.Size(75, 23);
            this.btnupdateapp.TabIndex = 9;
            this.btnupdateapp.Text = "Update";
            this.btnupdateapp.UseVisualStyleBackColor = true;
            this.btnupdateapp.Click += new System.EventHandler(this.AppUpdate);
            // 
            // btndeleteapp
            // 
            this.btndeleteapp.Location = new System.Drawing.Point(317, 83);
            this.btndeleteapp.Name = "btndeleteapp";
            this.btndeleteapp.Size = new System.Drawing.Size(75, 23);
            this.btndeleteapp.TabIndex = 8;
            this.btndeleteapp.Text = "Delete";
            this.btndeleteapp.UseVisualStyleBackColor = true;
            this.btndeleteapp.Click += new System.EventHandler(this.AppDelete);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(317, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.BindingContextChanged += new System.EventHandler(this.AppCancel);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(317, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AppSave);
            // 
            // apdescription
            // 
            this.apdescription.Location = new System.Drawing.Point(83, 91);
            this.apdescription.Name = "apdescription";
            this.apdescription.Size = new System.Drawing.Size(149, 20);
            this.apdescription.TabIndex = 5;
            // 
            // aptype
            // 
            this.aptype.Location = new System.Drawing.Point(83, 58);
            this.aptype.Name = "aptype";
            this.aptype.Size = new System.Drawing.Size(149, 20);
            this.aptype.TabIndex = 4;
            // 
            // apname
            // 
            this.apname.Location = new System.Drawing.Point(83, 28);
            this.apname.Name = "apname";
            this.apname.Size = new System.Drawing.Size(149, 20);
            this.apname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // appointmentGridView
            // 
            this.appointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentGridView.Location = new System.Drawing.Point(6, 161);
            this.appointmentGridView.Name = "appointmentGridView";
            this.appointmentGridView.Size = new System.Drawing.Size(538, 160);
            this.appointmentGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.taskGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tasks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tadate);
            this.groupBox2.Controls.Add(this.btnupdateevn);
            this.groupBox2.Controls.Add(this.btndeleteevn);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tadescription);
            this.groupBox2.Controls.Add(this.tatype);
            this.groupBox2.Controls.Add(this.taname);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date Time";
            // 
            // tadate
            // 
            this.tadate.Location = new System.Drawing.Point(83, 122);
            this.tadate.Name = "tadate";
            this.tadate.Size = new System.Drawing.Size(200, 20);
            this.tadate.TabIndex = 10;
            // 
            // btnupdateevn
            // 
            this.btnupdateevn.Location = new System.Drawing.Point(317, 113);
            this.btnupdateevn.Name = "btnupdateevn";
            this.btnupdateevn.Size = new System.Drawing.Size(75, 23);
            this.btnupdateevn.TabIndex = 9;
            this.btnupdateevn.Text = "Update";
            this.btnupdateevn.UseVisualStyleBackColor = true;
            this.btnupdateevn.Click += new System.EventHandler(this.TaskUpdate);
            // 
            // btndeleteevn
            // 
            this.btndeleteevn.Location = new System.Drawing.Point(317, 83);
            this.btndeleteevn.Name = "btndeleteevn";
            this.btndeleteevn.Size = new System.Drawing.Size(75, 23);
            this.btndeleteevn.TabIndex = 8;
            this.btndeleteevn.Text = "Delete";
            this.btndeleteevn.UseVisualStyleBackColor = true;
            this.btndeleteevn.Click += new System.EventHandler(this.TaskDelete);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.TaskCanvel);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TaskSave);
            // 
            // tadescription
            // 
            this.tadescription.Location = new System.Drawing.Point(83, 91);
            this.tadescription.Name = "tadescription";
            this.tadescription.Size = new System.Drawing.Size(149, 20);
            this.tadescription.TabIndex = 5;
            // 
            // tatype
            // 
            this.tatype.Location = new System.Drawing.Point(83, 58);
            this.tatype.Name = "tatype";
            this.tatype.Size = new System.Drawing.Size(149, 20);
            this.tatype.TabIndex = 4;
            // 
            // taname
            // 
            this.taname.Location = new System.Drawing.Point(83, 28);
            this.taname.Name = "taname";
            this.taname.Size = new System.Drawing.Size(149, 20);
            this.taname.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // taskGridView
            // 
            this.taskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskGridView.Location = new System.Drawing.Point(6, 161);
            this.taskGridView.Name = "taskGridView";
            this.taskGridView.Size = new System.Drawing.Size(538, 160);
            this.taskGridView.TabIndex = 0;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 359);
            this.Controls.Add(this.tabControl1);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView appointmentGridView;
        private System.Windows.Forms.DataGridView taskGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox apdescription;
        private System.Windows.Forms.TextBox aptype;
        private System.Windows.Forms.TextBox apname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tadescription;
        private System.Windows.Forms.TextBox tatype;
        private System.Windows.Forms.TextBox taname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndeleteapp;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btndeleteevn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnupdateapp;
        private System.Windows.Forms.Button btnupdateevn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker apdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker tadate;
    }
}