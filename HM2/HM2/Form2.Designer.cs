namespace HM2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnmassege = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(180, 50);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 0;
            // 
            // btnmassege
            // 
            this.btnmassege.Location = new System.Drawing.Point(190, 168);
            this.btnmassege.Name = "btnmassege";
            this.btnmassege.Size = new System.Drawing.Size(75, 37);
            this.btnmassege.TabIndex = 1;
            this.btnmassege.Text = ":)";
            this.btnmassege.UseVisualStyleBackColor = true;
            this.btnmassege.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(113, 50);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 16);
            this.lblid.TabIndex = 2;
            this.lblid.Text = "id";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(463, 340);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnmassege);
            this.Controls.Add(this.txtid);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnmassege;
        private System.Windows.Forms.Label lblid;
    }
}