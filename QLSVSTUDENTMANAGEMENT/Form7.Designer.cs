namespace QLSVSTUDENTMANAGEMENT
{
    partial class Form7
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
            this.btnview2 = new System.Windows.Forms.Button();
            this.btnview1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnview2
            // 
            this.btnview2.BackColor = System.Drawing.Color.Blue;
            this.btnview2.Location = new System.Drawing.Point(321, 244);
            this.btnview2.Name = "btnview2";
            this.btnview2.Size = new System.Drawing.Size(159, 91);
            this.btnview2.TabIndex = 5;
            this.btnview2.Text = "See test scores";
            this.btnview2.UseVisualStyleBackColor = false;
            this.btnview2.Click += new System.EventHandler(this.btnview2_Click);
            // 
            // btnview1
            // 
            this.btnview1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnview1.Location = new System.Drawing.Point(321, 115);
            this.btnview1.Name = "btnview1";
            this.btnview1.Size = new System.Drawing.Size(159, 91);
            this.btnview1.TabIndex = 4;
            this.btnview1.Text = "View your information";
            this.btnview1.UseVisualStyleBackColor = false;
            this.btnview1.Click += new System.EventHandler(this.btnview1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnview2);
            this.Controls.Add(this.btnview1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnview2;
        private System.Windows.Forms.Button btnview1;
    }
}