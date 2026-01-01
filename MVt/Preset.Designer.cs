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
            this.StatePreview = new System.Windows.Forms.PictureBox();
            this.JiggleTrackBar = new System.Windows.Forms.TrackBar();
            this.NewStateButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.JiggleCheck = new System.Windows.Forms.CheckBox();
            this.PresetsBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewPresetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StatePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JiggleTrackBar)).BeginInit();
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
            // StatePreview
            // 
            this.StatePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatePreview.Location = new System.Drawing.Point(12, 68);
            this.StatePreview.Name = "StatePreview";
            this.StatePreview.Size = new System.Drawing.Size(250, 250);
            this.StatePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StatePreview.TabIndex = 1;
            this.StatePreview.TabStop = false;
            // 
            // JiggleTrackBar
            // 
            this.JiggleTrackBar.Location = new System.Drawing.Point(11, 347);
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
            // PresetsBox
            // 
            this.PresetsBox.FormattingEnabled = true;
            this.PresetsBox.Location = new System.Drawing.Point(110, 12);
            this.PresetsBox.Name = "PresetsBox";
            this.PresetsBox.Size = new System.Drawing.Size(152, 21);
            this.PresetsBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Предпросмотр";
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
            // NewPresetButton
            // 
            this.NewPresetButton.Location = new System.Drawing.Point(13, 12);
            this.NewPresetButton.Name = "NewPresetButton";
            this.NewPresetButton.Size = new System.Drawing.Size(91, 23);
            this.NewPresetButton.TabIndex = 6;
            this.NewPresetButton.Text = "Новый тубер";
            this.NewPresetButton.UseVisualStyleBackColor = true;
            // 
            // Preset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 408);
            this.Controls.Add(this.NewPresetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PresetsBox);
            this.Controls.Add(this.JiggleCheck);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.NewStateButton);
            this.Controls.Add(this.JiggleTrackBar);
            this.Controls.Add(this.StatePreview);
            this.Controls.Add(this.StateList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Preset";
            this.Text = "Преднастройка";
            this.Load += new System.EventHandler(this.Preset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JiggleTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StatePreview;
        private System.Windows.Forms.ListBox StateList;
        private System.Windows.Forms.Button NewStateButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.CheckBox JiggleCheck;
        private System.Windows.Forms.TrackBar JiggleTrackBar;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.ComboBox PresetsBox;
        private System.Windows.Forms.Button NewPresetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

