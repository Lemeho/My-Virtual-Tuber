namespace MVt
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.InputString = new System.Windows.Forms.TextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LangBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HelppButton = new System.Windows.Forms.Button();
            this.AuthorButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // InputString
            // 
            this.InputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.InputString.Location = new System.Drawing.Point(17, 72);
            this.InputString.Name = "InputString";
            this.InputString.Size = new System.Drawing.Size(201, 20);
            this.InputString.TabIndex = 0;
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(224, 70);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(75, 23);
            this.InputButton.TabIndex = 1;
            this.InputButton.Text = "Обзор...";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Настройки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь корневой папки аватаров";
            // 
            // LangBox
            // 
            this.LangBox.FormattingEnabled = true;
            this.LangBox.Items.AddRange(new object[] {
            "Русский",
            "English"});
            this.LangBox.Location = new System.Drawing.Point(17, 129);
            this.LangBox.Name = "LangBox";
            this.LangBox.Size = new System.Drawing.Size(201, 21);
            this.LangBox.TabIndex = 4;
            this.LangBox.SelectedIndexChanged += new System.EventHandler(this.LangBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Язык / Language";
            // 
            // HelppButton
            // 
            this.HelppButton.Location = new System.Drawing.Point(17, 176);
            this.HelppButton.Name = "HelppButton";
            this.HelppButton.Size = new System.Drawing.Size(140, 23);
            this.HelppButton.TabIndex = 6;
            this.HelppButton.Text = "Помощь";
            this.HelppButton.UseVisualStyleBackColor = true;
            this.HelppButton.Click += new System.EventHandler(this.HelppButton_Click);
            // 
            // AuthorButton
            // 
            this.AuthorButton.Location = new System.Drawing.Point(159, 176);
            this.AuthorButton.Name = "AuthorButton";
            this.AuthorButton.Size = new System.Drawing.Size(140, 23);
            this.AuthorButton.TabIndex = 7;
            this.AuthorButton.Text = "Автор";
            this.AuthorButton.UseVisualStyleBackColor = true;
            this.AuthorButton.Click += new System.EventHandler(this.AuthorButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(223, 9);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 218);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AuthorButton);
            this.Controls.Add(this.HelppButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LangBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.InputString);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputString;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LangBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HelppButton;
        private System.Windows.Forms.Button AuthorButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}