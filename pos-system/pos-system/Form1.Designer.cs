namespace pos_system
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
            this.label1 = new System.Windows.Forms.Label();
            this.regbtn = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.regusername = new System.Windows.Forms.Label();
            this.regpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(225, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRATION FORM";
            // 
            // regbtn
            // 
            this.regbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.regbtn.Location = new System.Drawing.Point(341, 364);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(130, 39);
            this.regbtn.TabIndex = 1;
            this.regbtn.Text = "REGISTER";
            this.regbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(459, 150);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(167, 22);
            this.txtusername.TabIndex = 2;
            // 
            // regusername
            // 
            this.regusername.AutoSize = true;
            this.regusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regusername.Location = new System.Drawing.Point(236, 143);
            this.regusername.Name = "regusername";
            this.regusername.Size = new System.Drawing.Size(156, 29);
            this.regusername.TabIndex = 3;
            this.regusername.Text = "USERNAME";
            // 
            // regpassword
            // 
            this.regpassword.AutoSize = true;
            this.regpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regpassword.Location = new System.Drawing.Point(236, 253);
            this.regpassword.Name = "regpassword";
            this.regpassword.Size = new System.Drawing.Size(159, 29);
            this.regpassword.TabIndex = 4;
            this.regpassword.Text = "PASSWORD";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(459, 255);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(167, 22);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.regpassword);
            this.Controls.Add(this.regusername);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label regusername;
        private System.Windows.Forms.Label regpassword;
        private System.Windows.Forms.TextBox txtpassword;
    }
}

