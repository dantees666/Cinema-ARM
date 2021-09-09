
namespace CinemaARM
{
    partial class CheckForm
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
            this.checkTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkTextBox
            // 
            this.checkTextBox.Location = new System.Drawing.Point(10, 10);
            this.checkTextBox.Multiline = true;
            this.checkTextBox.Name = "checkTextBox";
            this.checkTextBox.ReadOnly = true;
            this.checkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.checkTextBox.Size = new System.Drawing.Size(385, 360);
            this.checkTextBox.TabIndex = 0;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmButton.AutoSize = true;
            this.confirmButton.Location = new System.Drawing.Point(170, 380);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(87, 25);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Подтвердить";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 421);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.checkTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CheckForm";
            this.Text = "Check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox checkTextBox;
        private System.Windows.Forms.Button confirmButton;
    }
}