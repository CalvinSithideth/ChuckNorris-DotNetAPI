namespace ChuckNorrisForm
{
    partial class MainForm
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
            this.CmbCategories = new System.Windows.Forms.ComboBox();
            this.BtnJoke = new System.Windows.Forms.Button();
            this.RtbJoke = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CmbCategories
            // 
            this.CmbCategories.FormattingEnabled = true;
            this.CmbCategories.Location = new System.Drawing.Point(13, 13);
            this.CmbCategories.Name = "CmbCategories";
            this.CmbCategories.Size = new System.Drawing.Size(121, 21);
            this.CmbCategories.TabIndex = 0;
            // 
            // BtnJoke
            // 
            this.BtnJoke.Location = new System.Drawing.Point(141, 10);
            this.BtnJoke.Name = "BtnJoke";
            this.BtnJoke.Size = new System.Drawing.Size(75, 23);
            this.BtnJoke.TabIndex = 1;
            this.BtnJoke.Text = "Joke";
            this.BtnJoke.UseVisualStyleBackColor = true;
            this.BtnJoke.Click += new System.EventHandler(this.BtnJoke_Click);
            // 
            // RtbJoke
            // 
            this.RtbJoke.Location = new System.Drawing.Point(13, 41);
            this.RtbJoke.Name = "RtbJoke";
            this.RtbJoke.Size = new System.Drawing.Size(775, 397);
            this.RtbJoke.TabIndex = 2;
            this.RtbJoke.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RtbJoke);
            this.Controls.Add(this.BtnJoke);
            this.Controls.Add(this.CmbCategories);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbCategories;
        private System.Windows.Forms.Button BtnJoke;
        private System.Windows.Forms.RichTextBox RtbJoke;
    }
}

