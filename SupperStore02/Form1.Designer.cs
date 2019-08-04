namespace SupperStore02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.room1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.addnewitem = new System.Windows.Forms.Label();
            this.updatenameorprice = new System.Windows.Forms.Label();
            this.txtShemdeg = new System.Windows.Forms.TextBox();
            this.btnShetana = new System.Windows.Forms.Button();
            this.btnGamotana = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblShemdeg = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ExelExp = new System.Windows.Forms.Button();
            this.updateNorP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.room1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Location = new System.Drawing.Point(9, 7);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(43, 13);
            this.lblamount.TabIndex = 2;
            this.lblamount.Text = "Amount";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.room1BindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(59, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // room1BindingSource
            // 
            this.room1BindingSource.DataSource = typeof(SupperStore02.Room1);
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.room1BindingSource, "Price", true));
            this.txtPrice.Location = new System.Drawing.Point(59, 68);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // txtAmount
            // 
            this.txtAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.room1BindingSource, "Amount", true));
            this.txtAmount.Location = new System.Drawing.Point(58, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.room1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 345);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.addnewitem);
            this.panel.Controls.Add(this.updatenameorprice);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.txtPrice);
            this.panel.Location = new System.Drawing.Point(454, 110);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(177, 92);
            this.panel.TabIndex = 11;
            // 
            // addnewitem
            // 
            this.addnewitem.AutoSize = true;
            this.addnewitem.Location = new System.Drawing.Point(26, 13);
            this.addnewitem.Name = "addnewitem";
            this.addnewitem.Size = new System.Drawing.Size(130, 13);
            this.addnewitem.TabIndex = 14;
            this.addnewitem.Text = "Add New Item To Storage";
            // 
            // updatenameorprice
            // 
            this.updatenameorprice.AutoSize = true;
            this.updatenameorprice.Location = new System.Drawing.Point(1, 0);
            this.updatenameorprice.Name = "updatenameorprice";
            this.updatenameorprice.Size = new System.Drawing.Size(174, 13);
            this.updatenameorprice.TabIndex = 13;
            this.updatenameorprice.Text = "Updating Item Name/Price/Amount";
            // 
            // txtShemdeg
            // 
            this.txtShemdeg.Location = new System.Drawing.Point(58, 30);
            this.txtShemdeg.Name = "txtShemdeg";
            this.txtShemdeg.Size = new System.Drawing.Size(100, 20);
            this.txtShemdeg.TabIndex = 15;
            // 
            // btnShetana
            // 
            this.btnShetana.Location = new System.Drawing.Point(3, 3);
            this.btnShetana.Name = "btnShetana";
            this.btnShetana.Size = new System.Drawing.Size(75, 23);
            this.btnShetana.TabIndex = 18;
            this.btnShetana.Text = "shetana";
            this.btnShetana.UseVisualStyleBackColor = true;
            this.btnShetana.Click += new System.EventHandler(this.BtnShetana_Click);
            // 
            // btnGamotana
            // 
            this.btnGamotana.Location = new System.Drawing.Point(92, 3);
            this.btnGamotana.Name = "btnGamotana";
            this.btnGamotana.Size = new System.Drawing.Size(75, 23);
            this.btnGamotana.TabIndex = 19;
            this.btnGamotana.Text = "gamotana";
            this.btnGamotana.UseVisualStyleBackColor = true;
            this.btnGamotana.Click += new System.EventHandler(this.BtnGamotana_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblShemdeg);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.txtShemdeg);
            this.panel1.Controls.Add(this.lblamount);
            this.panel1.Location = new System.Drawing.Point(455, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 53);
            this.panel1.TabIndex = 20;
            // 
            // lblShemdeg
            // 
            this.lblShemdeg.AutoSize = true;
            this.lblShemdeg.Location = new System.Drawing.Point(0, 33);
            this.lblShemdeg.Name = "lblShemdeg";
            this.lblShemdeg.Size = new System.Drawing.Size(51, 13);
            this.lblShemdeg.TabIndex = 22;
            this.lblShemdeg.Text = "vamatebt";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnShetana);
            this.panel2.Controls.Add(this.btnGamotana);
            this.panel2.Location = new System.Drawing.Point(454, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 30);
            this.panel2.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::SupperStore02.Properties.Resources.Accept_icon;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(469, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save To DataBase";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::SupperStore02.Properties.Resources.Close_2_icon;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(500, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ExelExp
            // 
            this.ExelExp.Image = global::SupperStore02.Properties.Resources.Excel_icon;
            this.ExelExp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExelExp.Location = new System.Drawing.Point(484, 328);
            this.ExelExp.Name = "ExelExp";
            this.ExelExp.Size = new System.Drawing.Size(101, 23);
            this.ExelExp.TabIndex = 15;
            this.ExelExp.Text = "Export To Exel";
            this.ExelExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExelExp.UseVisualStyleBackColor = true;
            this.ExelExp.Click += new System.EventHandler(this.ExelExp_Click);
            // 
            // updateNorP
            // 
            this.updateNorP.Image = global::SupperStore02.Properties.Resources.Pencil_icon;
            this.updateNorP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateNorP.Location = new System.Drawing.Point(484, 41);
            this.updateNorP.Name = "updateNorP";
            this.updateNorP.Size = new System.Drawing.Size(126, 23);
            this.updateNorP.TabIndex = 14;
            this.updateNorP.Text = "Update Name/Price";
            this.updateNorP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateNorP.UseVisualStyleBackColor = true;
            this.updateNorP.Click += new System.EventHandler(this.UpdateNorP_Click);
            // 
            // button1
            // 
            this.button1.Image = global::SupperStore02.Properties.Resources.Button_Add_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(484, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add New Product";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 356);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ExelExp);
            this.Controls.Add(this.updateNorP);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Storage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.room1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource room1BindingSource;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label addnewitem;
        private System.Windows.Forms.Label updatenameorprice;
        private System.Windows.Forms.Button updateNorP;
        private System.Windows.Forms.Button ExelExp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShetana;
        private System.Windows.Forms.Button btnGamotana;
        private System.Windows.Forms.TextBox txtShemdeg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblShemdeg;
        private System.Windows.Forms.Panel panel2;
    }
}

