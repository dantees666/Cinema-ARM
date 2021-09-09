
namespace CinemaARM
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.showListPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.showList = new System.Windows.Forms.ListBox();
            this.sessionListPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sessionList = new System.Windows.Forms.ListBox();
            this.seatsPanel = new System.Windows.Forms.Panel();
            this.returnButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.basketTextBox = new System.Windows.Forms.TextBox();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.endButton = new System.Windows.Forms.Button();
            this.showListPanel.SuspendLayout();
            this.sessionListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // showListPanel
            // 
            this.showListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showListPanel.Controls.Add(this.label1);
            this.showListPanel.Controls.Add(this.showList);
            this.showListPanel.Location = new System.Drawing.Point(10, 10);
            this.showListPanel.Name = "showListPanel";
            this.showListPanel.Size = new System.Drawing.Size(500, 300);
            this.showListPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список доступных фильмов:";
            // 
            // showList
            // 
            this.showList.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showList.FormattingEnabled = true;
            this.showList.ItemHeight = 26;
            this.showList.Location = new System.Drawing.Point(10, 36);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(480, 238);
            this.showList.TabIndex = 1;
            this.showList.SelectedIndexChanged += new System.EventHandler(this.showList_SelectedIndexChanged);
            // 
            // sessionListPanel
            // 
            this.sessionListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sessionListPanel.Controls.Add(this.label2);
            this.sessionListPanel.Controls.Add(this.sessionList);
            this.sessionListPanel.Location = new System.Drawing.Point(10, 330);
            this.sessionListPanel.Name = "sessionListPanel";
            this.sessionListPanel.Size = new System.Drawing.Size(500, 300);
            this.sessionListPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Список доступных сеансов:";
            // 
            // sessionList
            // 
            this.sessionList.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sessionList.FormattingEnabled = true;
            this.sessionList.ItemHeight = 26;
            this.sessionList.Location = new System.Drawing.Point(10, 36);
            this.sessionList.Name = "sessionList";
            this.sessionList.Size = new System.Drawing.Size(480, 238);
            this.sessionList.TabIndex = 1;
            this.sessionList.SelectedIndexChanged += new System.EventHandler(this.sessionList_SelectedIndexChanged);
            // 
            // seatsPanel
            // 
            this.seatsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seatsPanel.Location = new System.Drawing.Point(530, 10);
            this.seatsPanel.Name = "seatsPanel";
            this.seatsPanel.Size = new System.Drawing.Size(530, 500);
            this.seatsPanel.TabIndex = 3;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(530, 565);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 25);
            this.returnButton.TabIndex = 4;
            this.returnButton.Text = "Отмена";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(615, 565);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 25);
            this.buyButton.TabIndex = 5;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // basketTextBox
            // 
            this.basketTextBox.Location = new System.Drawing.Point(700, 520);
            this.basketTextBox.Multiline = true;
            this.basketTextBox.Name = "basketTextBox";
            this.basketTextBox.ReadOnly = true;
            this.basketTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.basketTextBox.Size = new System.Drawing.Size(360, 110);
            this.basketTextBox.TabIndex = 6;
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalCostTextBox.Location = new System.Drawing.Point(530, 520);
            this.totalCostTextBox.Multiline = true;
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.ReadOnly = true;
            this.totalCostTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.totalCostTextBox.Size = new System.Drawing.Size(160, 39);
            this.totalCostTextBox.TabIndex = 7;
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(530, 597);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(164, 33);
            this.endButton.TabIndex = 8;
            this.endButton.Text = "Завершить";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 641);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.basketTextBox);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.seatsPanel);
            this.Controls.Add(this.sessionListPanel);
            this.Controls.Add(this.showListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "CinemaARM";
            this.showListPanel.ResumeLayout(false);
            this.showListPanel.PerformLayout();
            this.sessionListPanel.ResumeLayout(false);
            this.sessionListPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel showListPanel;
        private System.Windows.Forms.ListBox showList;
        private System.Windows.Forms.Panel sessionListPanel;
        private System.Windows.Forms.ListBox sessionList;
        private System.Windows.Forms.Panel seatsPanel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.TextBox basketTextBox;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button endButton;
    }
}

