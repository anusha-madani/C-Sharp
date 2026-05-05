namespace pos_system
{
    partial class Form2
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logbtn = new System.Windows.Forms.Button();
            this.logusername = new System.Windows.Forms.Label();
            this.logpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.reglogbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(487, 156);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(137, 22);
            this.txtusername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(332, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN FROM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logbtn
            // 
            this.logbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.logbtn.Location = new System.Drawing.Point(451, 343);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(98, 39);
            this.logbtn.TabIndex = 3;
            this.logbtn.Text = "LOGIN";
            this.logbtn.UseVisualStyleBackColor = true;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // logusername
            // 
            this.logusername.AutoSize = true;
            this.logusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logusername.Location = new System.Drawing.Point(214, 156);
            this.logusername.Name = "logusername";
            this.logusername.Size = new System.Drawing.Size(156, 29);
            this.logusername.TabIndex = 4;
            this.logusername.Text = "USERNAME";
            // 
            // logpassword
            // 
            this.logpassword.AutoSize = true;
            this.logpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logpassword.Location = new System.Drawing.Point(214, 245);
            this.logpassword.Name = "logpassword";
            this.logpassword.Size = new System.Drawing.Size(159, 29);
            this.logpassword.TabIndex = 5;
            this.logpassword.Text = "PASSWORD";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(487, 230);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(137, 22);
            this.txtpassword.TabIndex = 6;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // reglogbtn
            // 
            this.reglogbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reglogbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.reglogbtn.Location = new System.Drawing.Point(263, 342);
            this.reglogbtn.Name = "reglogbtn";
            this.reglogbtn.Size = new System.Drawing.Size(135, 39);
            this.reglogbtn.TabIndex = 7;
            this.reglogbtn.Text = "REGISTER";
            this.reglogbtn.UseVisualStyleBackColor = true;
            this.reglogbtn.Click += new System.EventHandler(this.reglogbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reglogbtn);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.logpassword);
            this.Controls.Add(this.logusername);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusername);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Label logusername;
        private System.Windows.Forms.Label logpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button reglogbtn;
    }
}