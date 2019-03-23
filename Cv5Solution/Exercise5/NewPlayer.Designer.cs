namespace Exercise5
{
    partial class NewPlayer
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxClub = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGoals = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(70, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Klub";
            // 
            // comboBoxClub
            // 
            this.comboBoxClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClub.FormattingEnabled = true;
            this.comboBoxClub.Location = new System.Drawing.Point(70, 51);
            this.comboBoxClub.Name = "comboBoxClub";
            this.comboBoxClub.Size = new System.Drawing.Size(121, 24);
            this.comboBoxClub.TabIndex = 3;
            this.comboBoxClub.Items.AddRange(typeof(FotbalovyKlub).GetEnumNames());
            this.comboBoxClub.SelectedIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Góly";
            // 
            // textBoxGoals
            // 
            this.textBoxGoals.Location = new System.Drawing.Point(70, 85);
            this.textBoxGoals.Name = "textBoxGoals";
            this.textBoxGoals.Size = new System.Drawing.Size(121, 22);
            this.textBoxGoals.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OkEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Storno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.StornoEvent);
            // 
            // NewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 174);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxGoals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxClub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "NewPlayer";
            this.Text = "NewPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxClub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGoals;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}