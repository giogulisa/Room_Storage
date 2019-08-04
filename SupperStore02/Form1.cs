using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupperStore02
{
    public partial class Form1 : Form
    {
        SupperStoreEntities test;

        public Form1()
        {
            InitializeComponent();
            panel.Hide();
            btnCancel.Hide();
            btnSave.Hide();
            panel1.Hide();
        }
        //When save is clicked
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Show();
                btnCancel.Show();
                panel1.Show();
                btnSave.Show();
                txtAmount.Show();
                lblamount.Show();
                panel2.Show();
                addnewitem.Show();
                txtShemdeg.Hide();
                lblShemdeg.Hide();
                updateNorP.Hide();
                updatenameorprice.Hide();
                txtShemdeg.Hide();
                lblShemdeg.Hide();
                panel2.Hide();
                Room1 product = new Room1();
                test.Room1.Add(product);
                room1BindingSource.Add(product);
                room1BindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Name or Price Update
        private void UpdateNorP_Click(object sender, EventArgs e)
        {
            panel.Show();
            updatenameorprice.Show();
            btnCancel.Show();
            btnSave.Show();
            panel1.Show();
            lblamount.Show();
            txtAmount.Show();
            button1.Hide();
            lblShemdeg.Hide();
            txtShemdeg.Hide();
            panel2.Hide();
            addnewitem.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            test = new SupperStoreEntities();
            room1BindingSource.DataSource = test.Room1.ToList();
        }

        //washlistvis viyeneb gilak 'Deletes'
        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if(MessageBox.Show("darwmunebuli xar rom gsurs washla ?", "Message",MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    test.Room1.Remove(room1BindingSource.Current as Room1);
                    room1BindingSource.RemoveCurrent();
                }
            }
            //RATA moxdes cvlilebis shenaxva washlis shemdeg dauyovnebliv bazashi
            try
            {
                room1BindingSource.EndEdit();
                test.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                room1BindingSource.ResetBindings(false);
            }
        }

        //Excel - shi gadatana
        private void copyAlltoClipboard()
        {
            //rom wavshalo pirveli blank column from datagridview
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void ExelExp_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                for (j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }
                StartRow++;

                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        }
                        catch
                        {
                            ;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Cancel gilakis dawerisas mowmdeba tu risi shesrulebaa sawiro
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if(btnShetana.Visible == true && btnGamotana.Visible == false)
            {
                lblamount.Enabled = true;
                txtAmount.Enabled = true;
                button1.Show();
                updateNorP.Show();
                btnGamotana.Show();
                panel1.Hide();
                btnCancel.Hide();
                btnSave.Hide();
                txtShemdeg.Text = "0";
            }
            else if (btnGamotana.Visible == true && btnGamotana.Visible == true)
            {
                lblamount.Enabled = true;
                txtAmount.Enabled = true;
                txtShemdeg.Text = "0";
                button1.Show();
                updateNorP.Show();
                btnShetana.Show();
                panel1.Hide();
                btnCancel.Hide();
                btnSave.Hide();
            }

            else if (updateNorP.Visible == true && button1.Visible == false)
            {
                room1BindingSource.ResetBindings(false);
                foreach (DbEntityEntry entry in test.ChangeTracker.Entries())
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            entry.State = EntityState.Detached;
                            break;
                        case EntityState.Modified:
                            entry.State = EntityState.Unchanged;
                            break;
                        case EntityState.Deleted:
                            entry.Reload();
                            break;
                    }
                }
                button1.Show();
                panel1.Hide();
                panel2.Show();
                btnCancel.Hide();
                panel.Hide();
                btnSave.Hide();
            }
            else
            {
                /*
                room1BindingSource.MoveLast();
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);
                */
                test.Room1.Remove(room1BindingSource.Current as Room1);
                room1BindingSource.RemoveCurrent();
                try
                {
                    room1BindingSource.EndEdit();
                    test.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    room1BindingSource.ResetBindings(false);
                }
                updateNorP.Show();
                panel2.Show();
                panel.Hide();
                btnCancel.Hide();
                btnSave.Hide();
                txtAmount.Hide();
                lblamount.Hide();
                txtShemdeg.Hide(); 
            }
        }

        //save ze daklikebisas
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true && btnShetana.Visible == true)
            {
                int Amount = Int32.Parse(txtAmount.Text);
                int Shemdeg = Int32.Parse(txtShemdeg.Text);
                int Sum = Amount + Shemdeg;
                txtAmount.Text = Sum.ToString();
                lblamount.Enabled = true;
                txtAmount.Enabled = true;
                btnGamotana.Show();
                panel1.Hide();
                btnSave.Hide();
                txtShemdeg.Text = "0";
            }
            if (panel1.Visible == true && btnGamotana.Visible == true)
            {
                int Amount = Int32.Parse(txtAmount.Text);
                int Shemdeg = Int32.Parse(txtShemdeg.Text);
                if(Amount < Shemdeg)
                {
                    Shemdeg = 0;
                    MessageBox.Show("Tqven gagaqvt imaze meti, vidre amjamat sawyobshia");
                }
                else
                {
                    int Sum = Amount - Shemdeg;
                    txtAmount.Text = Sum.ToString();
                }
                lblamount.Enabled = true;
                txtAmount.Enabled = true;
                btnGamotana.Show();
                panel1.Hide();
                btnSave.Hide();
                btnShetana.Show();
                //isev vanuleb meore vels
                txtShemdeg.Text = "0";
            }
            if (button1.Visible == true)
            {
                btnSave.Hide();
                panel2.Show();
                btnGamotana.Show();
                btnShetana.Show();
                panel1.Hide();
            }
            if (updateNorP.Visible == true)
            {
                panel2.Show();
                panel1.Hide();
            }

            try
            {
                room1BindingSource.EndEdit();
                test.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                room1BindingSource.ResetBindings(false);
            }
            panel.Hide();
            updateNorP.Show();
            button1.Show();
            btnCancel.Hide();
        }

        private void BtnShetana_Click(object sender, EventArgs e)
        {
            lblamount.Enabled = false;
            txtAmount.Enabled = false;
            txtShemdeg.Text = "0";
            btnSave.Show();
            panel.Show();
            panel1.Show();
            txtAmount.Show();
            lblamount.Show();
            lblShemdeg.Show();
            txtShemdeg.Show();
            btnCancel.Show();
            btnGamotana.Hide();
            panel.Hide();
            button1.Hide();
            updateNorP.Hide();
        }

        private void BtnGamotana_Click(object sender, EventArgs e)
        {
            lblamount.Enabled = false;
            txtAmount.Enabled = false;
            txtShemdeg.Text = "0";
            btnSave.Show();
            panel.Show();
            panel1.Show();
            txtAmount.Show();
            lblamount.Show();
            txtShemdeg.Show();
            lblShemdeg.Show();
            btnGamotana.Show();
            btnCancel.Show();
            panel.Hide();
            button1.Hide();
            updateNorP.Hide();
            btnShetana.Hide();

        }
    }
}
