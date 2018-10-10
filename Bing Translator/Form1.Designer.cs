namespace Translator
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
            this.TranslatedText = new System.Windows.Forms.TextBox();
            this.TraslateText = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TranslatedText
            // 
            this.TranslatedText.Location = new System.Drawing.Point(6, 213);
            this.TranslatedText.Multiline = true;
            this.TranslatedText.Name = "TranslatedText";
            this.TranslatedText.Size = new System.Drawing.Size(369, 92);
            this.TranslatedText.TabIndex = 7;
            // 
            // TraslateText
            // 
            this.TraslateText.Location = new System.Drawing.Point(6, 95);
            this.TraslateText.Multiline = true;
            this.TraslateText.Name = "TraslateText";
            this.TraslateText.Size = new System.Drawing.Size(369, 92);
            this.TraslateText.TabIndex = 6;
            this.TraslateText.TextChanged += new System.EventHandler(this.TextChanged_Click);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Cyril-Latin",
            "Latin-Cyril"});
            this.comboBox.Location = new System.Drawing.Point(109, 49);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(160, 21);
            this.comboBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 371);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.TranslatedText);
            this.Controls.Add(this.TraslateText);
            this.Name = "Form1";
            this.Text = "Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox TranslatedText;
        internal System.Windows.Forms.TextBox TraslateText;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

