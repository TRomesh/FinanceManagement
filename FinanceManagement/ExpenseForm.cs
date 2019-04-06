using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManagement
{
    public partial class ExpenseForm : Form
    {

        int cLeft = 1;
        private ComboBox[] combo1;  // Array of comboboxes
        private RichTextBox[] rtext1;  // Array of richtextbo
        private TextBox[] text1;    // Array of textboxes
        private int count = -1;
        private int max_row = 10;
        private int empty_count = 0;
        private int rowIndex = 0;
        public ExpenseForm()
        {
            InitializeComponent();
            combo1_rtext1_text1_array();    // declaring array for new row addition
        }

        private void combo1_rtext1_text1_array()
        {
            combo1 = new ComboBox[max_row];
            rtext1 = new RichTextBox[max_row];
            text1 = new TextBox[max_row];
        }

        private void add_row_Click(object sender, EventArgs e)
        {
            if (count == max_row - 1)
            {
                MessageBox.Show("Maximum of 10 rows can be added");
                return;
            }
            else
            {
                count++;
               
                
                combo1[count] = new ComboBox();
                combo1[count].Top = cLeft * 25;
                //combo1[count].Left = 100;
                for (int i = 1; i <= 5; i++)
                    combo1[count].Items.Add("Item " + i);
                rtext1[count] = new RichTextBox();
                rtext1[count].Top = cLeft * 25;
                //rtext1[count].Left = 100;
                text1[count] = new TextBox();
                text1[count].Top = cLeft * 25;
               // text1[count].Left = 100;
                rowIndex = this.items_panel.RowCount++;
                combo1[count].Dock = DockStyle.None;
                rtext1[count].Dock = DockStyle.None;
                text1[count].Dock = DockStyle.None;
                combo1[count].Anchor = AnchorStyles.None;
                rtext1[count].Anchor = AnchorStyles.None;
                text1[count].Anchor = AnchorStyles.None;
                this.items_panel.Controls.Add(this.combo1[count], 0, rowIndex);
                this.items_panel.Controls.Add(this.rtext1[count], 1, rowIndex);
                this.items_panel.Controls.Add(this.text1[count], 2, rowIndex);
                this.items_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                cLeft = cLeft + 1;
            }
        }

        private void remove_row_Click(object sender, EventArgs e)
        {
            if (count > -1)  // Deleting one row at a time
            {
                this.items_panel.Controls.Remove(combo1[count]);
                this.items_panel.Controls.Remove(rtext1[count]);
                this.items_panel.Controls.Remove(text1[count]);
                this.items_panel.RowCount--;  // decrementing the row count
                count--;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            comboBox1.ResetText();
            comboBox2.ResetText();
            for (int i = count; i > -1; i--)
            {
                this.items_panel.Controls.Remove(combo1[i]);
                this.items_panel.Controls.Remove(rtext1[i]);
                this.items_panel.Controls.Remove(text1[i]);
            }
            this.items_panel.RowCount = 1;
            count = -1;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (count > -1)
            {
                for (int i = 0; i <= count; i++)
                {
                    if (text1[count].Text == "" || combo1[count].SelectedItem == null || rtext1[count].Text == null)
                        empty_count++;
                }
                if (empty_count > 0)
                {
                    MessageBox.Show("Empty Fields detected ! Please fill or select data for all fields");
                    empty_count = 0;
                }
                else
                    MessageBox.Show("No database connection for this application !!! ");
            }
            else if (count == -1)
                if (textBox1.Text == "" || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
                    MessageBox.Show("Empty Fields detected ! Please fill or select data for all fields");
                else
                    MessageBox.Show("No database connection for this application");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        //public System.Windows.Forms.TextBox AddNewTextBox()
        //{
        //    System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
        //    this.Controls.Add(txt);
        //    txt.Top = cLeft * 25;
        //    txt.Left = 100;
        //    txt.Text = "TextBox " + this.cLeft.ToString();
        //    cLeft = cLeft + 1;
        //    return txt;
        //}

        private void AddExpenseLine(object sender, EventArgs e)
        {

        }
    }
}
