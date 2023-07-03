namespace DelegateCommTest
{
    partial class FrmMainA
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnCreateChildForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message Received:";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(33, 94);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(433, 134);
            this.txtContent.TabIndex = 1;
            // 
            // btnCreateChildForm
            // 
            this.btnCreateChildForm.Location = new System.Drawing.Point(138, 264);
            this.btnCreateChildForm.Name = "btnCreateChildForm";
            this.btnCreateChildForm.Size = new System.Drawing.Size(242, 36);
            this.btnCreateChildForm.TabIndex = 2;
            this.btnCreateChildForm.Text = "Create Child Form B";
            this.btnCreateChildForm.UseVisualStyleBackColor = true;
            this.btnCreateChildForm.Click += new System.EventHandler(this.btnCreateChildForm_Click);
            // 
            // FrmMainA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 348);
            this.Controls.Add(this.btnCreateChildForm);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label1);
            this.Name = "FrmMainA";
            this.Text = "Form A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnCreateChildForm;
    }
}

