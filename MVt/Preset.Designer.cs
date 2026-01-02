namespace MVt
{
    partial class Preset
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preset));
            this.StateList = new System.Windows.Forms.ListBox();
            this.JiggleTrackBar = new System.Windows.Forms.TrackBar();
            this.NewStateButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.JiggleCheck = new System.Windows.Forms.CheckBox();
            this.AvatarsBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewAvatarButton = new System.Windows.Forms.Button();
            this.JumpCheck = new System.Windows.Forms.CheckBox();
            this.JumpTrackBar1 = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BackColor = new System.Windows.Forms.Button();
            this.ColorPrewiev = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShadowCheck = new System.Windows.Forms.CheckBox();
            this.ShadowTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.JiggleTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // StateList
            // 
            this.StateList.FormattingEnabled = true;
            this.StateList.Location = new System.Drawing.Point(279, 68);
            this.StateList.Name = "StateList";
            this.StateList.Size = new System.Drawing.Size(152, 251);
            this.StateList.TabIndex = 0;
            // 
            // JiggleTrackBar
            // 
            this.JiggleTrackBar.Location = new System.Drawing.Point(12, 343);
            this.JiggleTrackBar.Name = "JiggleTrackBar";
            this.JiggleTrackBar.Size = new System.Drawing.Size(250, 45);
            this.JiggleTrackBar.TabIndex = 5;
            // 
            // NewStateButton
            // 
            this.NewStateButton.Location = new System.Drawing.Point(279, 323);
            this.NewStateButton.Name = "NewStateButton";
            this.NewStateButton.Size = new System.Drawing.Size(152, 23);
            this.NewStateButton.TabIndex = 1;
            this.NewStateButton.Text = "Новое состояние";
            this.NewStateButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(356, 10);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 8;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RunButton.Location = new System.Drawing.Point(279, 353);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(151, 44);
            this.RunButton.TabIndex = 2;
            this.RunButton.Text = "Запустить";
            this.RunButton.UseVisualStyleBackColor = true;
            // 
            // JiggleCheck
            // 
            this.JiggleCheck.AutoSize = true;
            this.JiggleCheck.Location = new System.Drawing.Point(13, 324);
            this.JiggleCheck.Name = "JiggleCheck";
            this.JiggleCheck.Size = new System.Drawing.Size(73, 17);
            this.JiggleCheck.TabIndex = 4;
            this.JiggleCheck.Text = "Трясучка";
            this.JiggleCheck.UseVisualStyleBackColor = true;
            // 
            // AvatarsBox
            // 
            this.AvatarsBox.FormattingEnabled = true;
            this.AvatarsBox.Location = new System.Drawing.Point(110, 12);
            this.AvatarsBox.Name = "AvatarsBox";
            this.AvatarsBox.Size = new System.Drawing.Size(152, 21);
            this.AvatarsBox.Sorted = true;
            this.AvatarsBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Состояния";
            // 
            // NewAvatarButton
            // 
            this.NewAvatarButton.Location = new System.Drawing.Point(13, 12);
            this.NewAvatarButton.Name = "NewAvatarButton";
            this.NewAvatarButton.Size = new System.Drawing.Size(91, 23);
            this.NewAvatarButton.TabIndex = 6;
            this.NewAvatarButton.Text = "Новый аватар";
            this.NewAvatarButton.UseVisualStyleBackColor = true;
            this.NewAvatarButton.Click += new System.EventHandler(this.NewAvatarButton_Click);
            // 
            // JumpCheck
            // 
            this.JumpCheck.AutoSize = true;
            this.JumpCheck.Location = new System.Drawing.Point(13, 394);
            this.JumpCheck.Name = "JumpCheck";
            this.JumpCheck.Size = new System.Drawing.Size(68, 17);
            this.JumpCheck.TabIndex = 11;
            this.JumpCheck.Text = "Прыжок";
            this.JumpCheck.UseVisualStyleBackColor = true;
            // 
            // JumpTrackBar1
            // 
            this.JumpTrackBar1.Location = new System.Drawing.Point(12, 417);
            this.JumpTrackBar1.Name = "JumpTrackBar1";
            this.JumpTrackBar1.Size = new System.Drawing.Size(250, 45);
            this.JumpTrackBar1.TabIndex = 12;
            // 
            // BackColor
            // 
            this.BackColor.Location = new System.Drawing.Point(13, 542);
            this.BackColor.Name = "BackColor";
            this.BackColor.Size = new System.Drawing.Size(75, 23);
            this.BackColor.TabIndex = 13;
            this.BackColor.Text = "Цвет фона";
            this.BackColor.UseVisualStyleBackColor = true;
            this.BackColor.Click += new System.EventHandler(this.BackColor_Click);
            // 
            // ColorPrewiev
            // 
            this.ColorPrewiev.Location = new System.Drawing.Point(111, 542);
            this.ColorPrewiev.Name = "ColorPrewiev";
            this.ColorPrewiev.Size = new System.Drawing.Size(152, 23);
            this.ColorPrewiev.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 259);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Предпросмотр";
            // 
            // ShadowCheck
            // 
            this.ShadowCheck.AutoSize = true;
            this.ShadowCheck.Location = new System.Drawing.Point(12, 468);
            this.ShadowCheck.Name = "ShadowCheck";
            this.ShadowCheck.Size = new System.Drawing.Size(80, 17);
            this.ShadowCheck.TabIndex = 11;
            this.ShadowCheck.Text = "Затенение";
            this.ShadowCheck.UseVisualStyleBackColor = true;
            // 
            // ShadowTrackBar
            // 
            this.ShadowTrackBar.Location = new System.Drawing.Point(11, 491);
            this.ShadowTrackBar.Name = "ShadowTrackBar";
            this.ShadowTrackBar.Size = new System.Drawing.Size(250, 45);
            this.ShadowTrackBar.TabIndex = 12;
            // 
            // Preset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ColorPrewiev);
            this.Controls.Add(this.BackColor);
            this.Controls.Add(this.ShadowTrackBar);
            this.Controls.Add(this.ShadowCheck);
            this.Controls.Add(this.JumpTrackBar1);
            this.Controls.Add(this.JumpCheck);
            this.Controls.Add(this.NewAvatarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AvatarsBox);
            this.Controls.Add(this.JiggleCheck);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.NewStateButton);
            this.Controls.Add(this.JiggleTrackBar);
            this.Controls.Add(this.StateList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Preset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preset";
            this.Load += new System.EventHandler(this.Preset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JiggleTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox StateList;
        private System.Windows.Forms.Button NewStateButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.CheckBox JiggleCheck;
        private System.Windows.Forms.TrackBar JiggleTrackBar;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button NewAvatarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox JumpCheck;
        private System.Windows.Forms.TrackBar JumpTrackBar1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BackColor;
        private System.Windows.Forms.Panel ColorPrewiev;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox AvatarsBox;
        private System.Windows.Forms.CheckBox ShadowCheck;
        private System.Windows.Forms.TrackBar ShadowTrackBar;
    }
}

