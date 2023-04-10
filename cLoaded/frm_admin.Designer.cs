namespace cLoaded
{
    partial class frm_admin
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
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.TeamComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TablesComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ValueTexBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(106, 105);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(206, 28);
            this.CategoryComboBox.TabIndex = 0;
            // 
            // TeamComboBox
            // 
            this.TeamComboBox.FormattingEnabled = true;
            this.TeamComboBox.Location = new System.Drawing.Point(106, 139);
            this.TeamComboBox.Name = "TeamComboBox";
            this.TeamComboBox.Size = new System.Drawing.Size(206, 28);
            this.TeamComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teams";
            // 
            // TablesComboBox
            // 
            this.TablesComboBox.FormattingEnabled = true;
            this.TablesComboBox.Location = new System.Drawing.Point(428, 86);
            this.TablesComboBox.Name = "TablesComboBox";
            this.TablesComboBox.Size = new System.Drawing.Size(360, 28);
            this.TablesComboBox.TabIndex = 4;
            this.TablesComboBox.SelectedIndexChanged += new System.EventHandler(this.TablesComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tables";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(428, 170);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(360, 268);
            this.dataGridView2.TabIndex = 6;
            // 
            // ValueTexBox
            // 
            this.ValueTexBox.Location = new System.Drawing.Point(428, 140);
            this.ValueTexBox.Name = "ValueTexBox";
            this.ValueTexBox.Size = new System.Drawing.Size(260, 27);
            this.ValueTexBox.TabIndex = 7;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(694, 140);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(94, 29);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Value to add:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Available Dropdowns";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 49);
            this.button2.TabIndex = 11;
            this.button2.Text = "Proceed to main form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "Admin Panel";
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ValueTexBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TablesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeamComboBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Name = "frm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_admin";
            this.Load += new System.EventHandler(this.frm_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CategoryComboBox;
        private ComboBox TeamComboBox;
        private Label label1;
        private Label label2;
        private ComboBox TablesComboBox;
        private Label label3;
        private DataGridView dataGridView2;
        private TextBox ValueTexBox;
        private Button SubmitButton;
        private Label label4;
        private Label label5;
        private Button button2;
        private Panel panel1;
        private Label label6;
    }
}