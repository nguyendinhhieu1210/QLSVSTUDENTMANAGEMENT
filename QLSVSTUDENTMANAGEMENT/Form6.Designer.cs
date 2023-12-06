namespace QLSVSTUDENTMANAGEMENT
{
    partial class Form6
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnview1 = new System.Windows.Forms.Button();
            this.btnview2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnview1
            // 
            this.btnview1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnview1.Location = new System.Drawing.Point(321, 131);
            this.btnview1.Name = "btnview1";
            this.btnview1.Size = new System.Drawing.Size(159, 91);
            this.btnview1.TabIndex = 2;
            this.btnview1.Text = "View student information";
            this.btnview1.UseVisualStyleBackColor = false;
            this.btnview1.Click += new System.EventHandler(this.btnview1_Click);
            // 
            // btnview2
            // 
            this.btnview2.BackColor = System.Drawing.SystemColors.Info;
            this.btnview2.Location = new System.Drawing.Point(321, 260);
            this.btnview2.Name = "btnview2";
            this.btnview2.Size = new System.Drawing.Size(159, 91);
            this.btnview2.TabIndex = 3;
            this.btnview2.Text = "View student scores";
            this.btnview2.UseVisualStyleBackColor = false;
            this.btnview2.Click += new System.EventHandler(this.btnview2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnview2);
            this.Controls.Add(this.btnview1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnview1;
        private System.Windows.Forms.Button btnview2;
    }
}