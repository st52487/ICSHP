namespace Exercise5
{
    partial class NejKluby
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
            this.textBoxGoals = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxClubs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Počet gólů";
            // 
            // textBoxGoals
            // 
            this.textBoxGoals.AccessibleName = "";
            this.textBoxGoals.Location = new System.Drawing.Point(16, 34);
            this.textBoxGoals.Name = "textBoxGoals";
            this.textBoxGoals.ReadOnly = true;
            this.textBoxGoals.Size = new System.Drawing.Size(100, 22);
            this.textBoxGoals.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kluby";
            // 
            // richTextBoxClubs
            // 
            this.richTextBoxClubs.AccessibleName = "richTextBestClubs";
            this.richTextBoxClubs.Location = new System.Drawing.Point(19, 99);
            this.richTextBoxClubs.Multiline = false;
            this.richTextBoxClubs.Name = "richTextBoxClubs";
            this.richTextBoxClubs.Size = new System.Drawing.Size(396, 177);
            this.richTextBoxClubs.TabIndex = 3;
            this.richTextBoxClubs.Text = "";
            // 
            // NejKluby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 324);
            this.Controls.Add(this.richTextBoxClubs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxGoals);
            this.Controls.Add(this.label1);
            this.Name = "NejKluby";
            this.Text = "NejKluby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGoals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxClubs;
    }
}