namespace SanityArchiver_List
{
    partial class Form2_Attributes
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
            this.checkedListBox_Attributes = new System.Windows.Forms.CheckedListBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_Location = new System.Windows.Forms.Label();
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox_Attributes
            // 
            this.checkedListBox_Attributes.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_Attributes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_Attributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_Attributes.FormattingEnabled = true;
            this.checkedListBox_Attributes.Items.AddRange(new object[] {
            "Archive",
            "ReadOnly",
            "Hidden",
            "System",
            "Encrypted"});
            this.checkedListBox_Attributes.Location = new System.Drawing.Point(60, 93);
            this.checkedListBox_Attributes.Name = "checkedListBox_Attributes";
            this.checkedListBox_Attributes.Size = new System.Drawing.Size(124, 154);
            this.checkedListBox_Attributes.TabIndex = 0;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(23, 261);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 30);
            this.button_Ok.TabIndex = 1;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(122, 261);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 30);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // label_Location
            // 
            this.label_Location.AutoSize = true;
            this.label_Location.Location = new System.Drawing.Point(9, 47);
            this.label_Location.MaximumSize = new System.Drawing.Size(330, 35);
            this.label_Location.Name = "label_Location";
            this.label_Location.Size = new System.Drawing.Size(66, 17);
            this.label_Location.TabIndex = 2;
            this.label_Location.Text = "Location:";
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.Location = new System.Drawing.Point(12, 12);
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.ReadOnly = true;
            this.textBox_FileName.Size = new System.Drawing.Size(298, 22);
            this.textBox_FileName.TabIndex = 3;
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(221, 261);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 30);
            this.button_Apply.TabIndex = 4;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.Button_Apply_Click);
            // 
            // Form2_Attributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 303);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.textBox_FileName);
            this.Controls.Add(this.label_Location);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.checkedListBox_Attributes);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 350);
            this.MinimumSize = new System.Drawing.Size(340, 350);
            this.Name = "Form2_Attributes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form_Attributes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_Attributes;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_Location;
        private System.Windows.Forms.TextBox textBox_FileName;
        private System.Windows.Forms.Button button_Apply;
    }
}