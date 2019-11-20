namespace SanityArchiver_List
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
            this.listBox_Browser = new System.Windows.Forms.ListBox();
            this.comboBox_Drives = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_CurrentPath = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_ChangeAttributes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Browser
            // 
            this.listBox_Browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Browser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Browser.FormattingEnabled = true;
            this.listBox_Browser.ItemHeight = 20;
            this.listBox_Browser.Location = new System.Drawing.Point(0, 88);
            this.listBox_Browser.Name = "listBox_Browser";
            this.listBox_Browser.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_Browser.Size = new System.Drawing.Size(583, 664);
            this.listBox_Browser.TabIndex = 0;
            this.listBox_Browser.DoubleClick += new System.EventHandler(this.ListBox_Browser_DoubleClick);
            // 
            // comboBox_Drives
            // 
            this.comboBox_Drives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Drives.FormattingEnabled = true;
            this.comboBox_Drives.Location = new System.Drawing.Point(54, 10);
            this.comboBox_Drives.Name = "comboBox_Drives";
            this.comboBox_Drives.Size = new System.Drawing.Size(60, 24);
            this.comboBox_Drives.TabIndex = 1;
            this.comboBox_Drives.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_Drives_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drive:";
            // 
            // label_CurrentPath
            // 
            this.label_CurrentPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CurrentPath.AutoSize = true;
            this.label_CurrentPath.Location = new System.Drawing.Point(51, 53);
            this.label_CurrentPath.MaximumSize = new System.Drawing.Size(0, 34);
            this.label_CurrentPath.Name = "label_CurrentPath";
            this.label_CurrentPath.Size = new System.Drawing.Size(26, 17);
            this.label_CurrentPath.TabIndex = 3;
            this.label_CurrentPath.Text = "CP";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button_ChangeAttributes
            // 
            this.button_ChangeAttributes.Location = new System.Drawing.Point(148, 6);
            this.button_ChangeAttributes.Name = "button_ChangeAttributes";
            this.button_ChangeAttributes.Size = new System.Drawing.Size(47, 35);
            this.button_ChangeAttributes.TabIndex = 5;
            this.button_ChangeAttributes.Text = "r-hs";
            this.button_ChangeAttributes.UseVisualStyleBackColor = true;
            this.button_ChangeAttributes.Click += new System.EventHandler(this.Button_ChangeAttributes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 748);
            this.Controls.Add(this.button_ChangeAttributes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_CurrentPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Drives);
            this.Controls.Add(this.listBox_Browser);
            this.Location = new System.Drawing.Point(800, 0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Browser;
        private System.Windows.Forms.ComboBox comboBox_Drives;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_CurrentPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_ChangeAttributes;
    }
}

