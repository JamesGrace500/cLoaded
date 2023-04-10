namespace cLoaded
{
    partial class frm_landing
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
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 145);
            this.label1.TabIndex = 0;
            this.label1.Text = "You do not have permission to use this tool.  Please contact the Marketing Change" +
    " and Planning Team";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(95, 168);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(106, 31);
            this.QuitButton.TabIndex = 1;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // frm_landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 211);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_landing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_landing";
            this.Load += new System.EventHandler(this.frm_landing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button QuitButton;
    }
}