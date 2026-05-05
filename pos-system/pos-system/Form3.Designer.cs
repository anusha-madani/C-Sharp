namespace pos_system
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.addtocardbtn = new System.Windows.Forms.Button();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.proitem = new System.Windows.Forms.Label();
            this.proprice = new System.Windows.Forms.Label();
            this.proqty = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(241, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = " PRODUCT MANAGEMENT";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(420, 165);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(121, 22);
            this.txtprice.TabIndex = 1;
            // 
            // addtocardbtn
            // 
            this.addtocardbtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addtocardbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtocardbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addtocardbtn.Location = new System.Drawing.Point(491, 447);
            this.addtocardbtn.Name = "addtocardbtn";
            this.addtocardbtn.Size = new System.Drawing.Size(137, 40);
            this.addtocardbtn.TabIndex = 2;
            this.addtocardbtn.Text = "Add to Cart";
            this.addtocardbtn.UseVisualStyleBackColor = false;
            this.addtocardbtn.Click += new System.EventHandler(this.donebtn_Click);
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Items.AddRange(new object[] {
            "\"LAPTOP\"",
            "\"MOBILE\""});
            this.cmbProducts.Location = new System.Drawing.Point(420, 107);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(121, 24);
            this.cmbProducts.TabIndex = 3;
            // 
            // proitem
            // 
            this.proitem.AutoSize = true;
            this.proitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proitem.Location = new System.Drawing.Point(182, 107);
            this.proitem.Name = "proitem";
            this.proitem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.proitem.Size = new System.Drawing.Size(156, 29);
            this.proitem.TabIndex = 4;
            this.proitem.Text = "PRODUCTS";
            this.proitem.Click += new System.EventHandler(this.proitem_Click);
            // 
            // proprice
            // 
            this.proprice.AutoSize = true;
            this.proprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proprice.Location = new System.Drawing.Point(182, 165);
            this.proprice.Name = "proprice";
            this.proprice.Size = new System.Drawing.Size(175, 29);
            this.proprice.TabIndex = 5;
            this.proprice.Text = "UNIT PRICES";
            // 
            // proqty
            // 
            this.proqty.AutoSize = true;
            this.proqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proqty.Location = new System.Drawing.Point(182, 228);
            this.proqty.Name = "proqty";
            this.proqty.Size = new System.Drawing.Size(144, 29);
            this.proqty.TabIndex = 6;
            this.proqty.Text = "QUANTITY";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(420, 228);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(121, 22);
            this.txtqty.TabIndex = 7;
            // 
            // clearbtn
            // 
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clearbtn.Location = new System.Drawing.Point(127, 447);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(100, 40);
            this.clearbtn.TabIndex = 8;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addbtn.Location = new System.Drawing.Point(313, 447);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(115, 40);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "Update";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(51, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Receontly Modified Prouducts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(56, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 92);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Products";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qauntity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // btndone
            // 
            this.btndone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndone.ForeColor = System.Drawing.Color.Teal;
            this.btndone.Location = new System.Drawing.Point(590, 257);
            this.btndone.Name = "btndone";
            this.btndone.Size = new System.Drawing.Size(77, 33);
            this.btndone.TabIndex = 12;
            this.btndone.Text = "done";
            this.btndone.UseVisualStyleBackColor = true;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 516);
            this.Controls.Add(this.btndone);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.proqty);
            this.Controls.Add(this.proprice);
            this.Controls.Add(this.proitem);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.addtocardbtn);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button addtocardbtn;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label proitem;
        private System.Windows.Forms.Label proprice;
        private System.Windows.Forms.Label proqty;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btndone;
    }
}