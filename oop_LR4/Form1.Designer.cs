namespace oop_LR4
{
    partial class Form1
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
            this.FileOK = new System.Windows.Forms.Button();
            this.EditFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FileOK
            // 
            this.FileOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileOK.Location = new System.Drawing.Point(188, 114);
            this.FileOK.Name = "FileOK";
            this.FileOK.Size = new System.Drawing.Size(75, 31);
            this.FileOK.TabIndex = 0;
            this.FileOK.Text = "OK";
            this.FileOK.UseVisualStyleBackColor = true;
            this.FileOK.Click += new System.EventHandler(this.FileOK_Click);
            // 
            // EditFileName
            // 
            this.EditFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditFileName.Location = new System.Drawing.Point(89, 69);
            this.EditFileName.Name = "EditFileName";
            this.EditFileName.Size = new System.Drawing.Size(272, 22);
            this.EditFileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите имя файла без расширения(по умолчанию temp.txt):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 166);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditFileName);
            this.Controls.Add(this.FileOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Главное окно";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileOK;
        private System.Windows.Forms.TextBox EditFileName;
        private System.Windows.Forms.Label label1;
    }
}

