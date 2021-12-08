
namespace CinemaARM
{
    partial class InterForm
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
            this.typePanel = new System.Windows.Forms.Panel();
            this.serialButton = new System.Windows.Forms.RadioButton();
            this.filmButton = new System.Windows.Forms.RadioButton();
            this.data_Panel = new System.Windows.Forms.Panel();
            this.add_Button = new System.Windows.Forms.Button();
            this.return_Button = new System.Windows.Forms.Button();
            this.start_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.countBox = new System.Windows.Forms.TextBox();
            this.typePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите тип показа:";
            // 
            // typePanel
            // 
            this.typePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typePanel.Controls.Add(this.label1);
            this.typePanel.Controls.Add(this.serialButton);
            this.typePanel.Controls.Add(this.filmButton);
            this.typePanel.Location = new System.Drawing.Point(13, 13);
            this.typePanel.Name = "typePanel";
            this.typePanel.Size = new System.Drawing.Size(156, 81);
            this.typePanel.TabIndex = 2;
            // 
            // serialButton
            // 
            this.serialButton.AutoSize = true;
            this.serialButton.Location = new System.Drawing.Point(14, 54);
            this.serialButton.Name = "serialButton";
            this.serialButton.Size = new System.Drawing.Size(66, 19);
            this.serialButton.TabIndex = 2;
            this.serialButton.Text = "Сериал";
            this.serialButton.UseVisualStyleBackColor = true;
            this.serialButton.CheckedChanged += new System.EventHandler(this.seanseType_CheckedChanged);
            // 
            // filmButton
            // 
            this.filmButton.AutoSize = true;
            this.filmButton.Location = new System.Drawing.Point(14, 28);
            this.filmButton.Name = "filmButton";
            this.filmButton.Size = new System.Drawing.Size(63, 19);
            this.filmButton.TabIndex = 1;
            this.filmButton.Text = "Фильм";
            this.filmButton.UseVisualStyleBackColor = true;
            this.filmButton.CheckedChanged += new System.EventHandler(this.seanseType_CheckedChanged);
            // 
            // data_Panel
            // 
            this.data_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_Panel.Location = new System.Drawing.Point(175, 13);
            this.data_Panel.Name = "data_Panel";
            this.data_Panel.Size = new System.Drawing.Size(200, 320);
            this.data_Panel.TabIndex = 3;
            // 
            // add_Button
            // 
            this.add_Button.Location = new System.Drawing.Point(12, 129);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(75, 50);
            this.add_Button.TabIndex = 4;
            this.add_Button.Text = "Добавить";
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // return_Button
            // 
            this.return_Button.Location = new System.Drawing.Point(94, 129);
            this.return_Button.Name = "return_Button";
            this.return_Button.Size = new System.Drawing.Size(75, 50);
            this.return_Button.TabIndex = 5;
            this.return_Button.Text = "Отмена";
            this.return_Button.UseVisualStyleBackColor = true;
            this.return_Button.Click += new System.EventHandler(this.return_Button_Click);
            // 
            // start_Button
            // 
            this.start_Button.Location = new System.Drawing.Point(12, 185);
            this.start_Button.Name = "start_Button";
            this.start_Button.Size = new System.Drawing.Size(156, 50);
            this.start_Button.TabIndex = 6;
            this.start_Button.Text = "Готово";
            this.start_Button.UseVisualStyleBackColor = true;
            this.start_Button.Click += new System.EventHandler(this.start_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество показов:";
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(139, 98);
            this.countBox.Name = "countBox";
            this.countBox.ReadOnly = true;
            this.countBox.Size = new System.Drawing.Size(30, 23);
            this.countBox.TabIndex = 8;
            // 
            // InterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 340);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.start_Button);
            this.Controls.Add(this.return_Button);
            this.Controls.Add(this.add_Button);
            this.Controls.Add(this.data_Panel);
            this.Controls.Add(this.typePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InterForm";
            this.Text = "Ввод фильмов";
            this.typePanel.ResumeLayout(false);
            this.typePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel typePanel;
        private System.Windows.Forms.Panel data_Panel;
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.Button return_Button;
        private System.Windows.Forms.Button start_Button;
        private System.Windows.Forms.RadioButton serialButton;
        private System.Windows.Forms.RadioButton filmButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countBox;
    }
}