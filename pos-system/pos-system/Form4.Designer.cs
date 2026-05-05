namespace pos_system
{
    partial class Form4
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
            this.slip = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.orderbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // slip
            // 
            this.slip.AutoSize = true;
            this.slip.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.slip.Location = new System.Drawing.Point(262, 55);
            this.slip.Name = "slip";
            this.slip.Size = new System.Drawing.Size(231, 39);
            this.slip.TabIndex = 0;
            this.slip.Text = "YOUR CARD";
            this.slip.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(109, 117);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(529, 119);
            this.dgvCart.TabIndex = 1;
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Location = new System.Drawing.Point(106, 304);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(113, 16);
            this.lbltotalamount.TabIndex = 2;
            this.lbltotalamount.Text = "TOTAL AMOUNT";
            // 
            // orderbtn
            // 
            this.orderbtn.BackColor = System.Drawing.Color.DarkGreen;
            this.orderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.orderbtn.Location = new System.Drawing.Point(451, 364);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(273, 51);
            this.orderbtn.TabIndex = 3;
            this.orderbtn.Text = "CONFIRM ORDER";
            this.orderbtn.UseVisualStyleBackColor = false;
            this.orderbtn.Click += new System.EventHandler(this.orderbtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.orderbtn);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.slip);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label slip;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Button orderbtn;
    }
}