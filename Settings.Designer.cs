
namespace StudentHousing
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.txt_Earn = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btn_earnnigs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Earn
            // 
            this.txt_Earn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txt_Earn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Earn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Earn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txt_Earn.Location = new System.Drawing.Point(211, 164);
            this.txt_Earn.Multiline = true;
            this.txt_Earn.Name = "txt_Earn";
            this.txt_Earn.Size = new System.Drawing.Size(292, 25);
            this.txt_Earn.TabIndex = 15;
            this.txt_Earn.Text = "PKR74320";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbltitle.Location = new System.Drawing.Point(26, 21);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(127, 32);
            this.lbltitle.TabIndex = 17;
            this.lbltitle.Text = "Settings";
            // 
            // btn_earnnigs
            // 
            this.btn_earnnigs.FlatAppearance.BorderSize = 0;
            this.btn_earnnigs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_earnnigs.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_earnnigs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_earnnigs.Image = ((System.Drawing.Image)(resources.GetObject("btn_earnnigs.Image")));
            this.btn_earnnigs.Location = new System.Drawing.Point(125, 150);
            this.btn_earnnigs.Name = "btn_earnnigs";
            this.btn_earnnigs.Size = new System.Drawing.Size(53, 50);
            this.btn_earnnigs.TabIndex = 18;
            this.btn_earnnigs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_earnnigs.UseVisualStyleBackColor = true;
            this.btn_earnnigs.Click += new System.EventHandler(this.btn_earnnigs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(206, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Press Button To Update Earnings";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_earnnigs);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.txt_Earn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Earn;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btn_earnnigs;
        private System.Windows.Forms.Label label2;
    }
}