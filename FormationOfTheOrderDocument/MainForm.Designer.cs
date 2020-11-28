
namespace FormationOfTheOrderDocument
{
    partial class MainForm
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
            this.openExcelButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveXMLButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // openExcelButton
            // 
            this.openExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openExcelButton.Location = new System.Drawing.Point(12, 12);
            this.openExcelButton.Name = "openExcelButton";
            this.openExcelButton.Size = new System.Drawing.Size(325, 23);
            this.openExcelButton.TabIndex = 0;
            this.openExcelButton.Text = "Открыть Excel файл";
            this.openExcelButton.UseVisualStyleBackColor = true;
            this.openExcelButton.Click += new System.EventHandler(this.OnOpenExcelButtonClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "*.xlsx|";
            this.openFileDialog.Title = "Открыть Excel файл";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "*.xml|";
            this.saveFileDialog.Title = "Сохранить XML файл";
            // 
            // saveXMLButton
            // 
            this.saveXMLButton.Enabled = false;
            this.saveXMLButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveXMLButton.Location = new System.Drawing.Point(12, 99);
            this.saveXMLButton.Name = "saveXMLButton";
            this.saveXMLButton.Size = new System.Drawing.Size(325, 23);
            this.saveXMLButton.TabIndex = 1;
            this.saveXMLButton.Text = "Сохранить XML";
            this.saveXMLButton.UseVisualStyleBackColor = true;
            this.saveXMLButton.Click += new System.EventHandler(this.OnSaveXMLButtonClick);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.progressBar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar.Location = new System.Drawing.Point(12, 70);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(325, 23);
            this.progressBar.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(349, 136);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.saveXMLButton);
            this.Controls.Add(this.openExcelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Конвектор excel в xml";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openExcelButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button saveXMLButton;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

