namespace Gallery
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
            this.hoverButton2 = new Gallery.CGallery();
            this.hoverButton1 = new Gallery.CircleGallery();
            this.SuspendLayout();
            // 
            // hoverButton1
            // 
            this.hoverButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButton1.ForeColor = System.Drawing.Color.White;
            this.hoverButton1.Location = new System.Drawing.Point(441, 46);
            this.hoverButton1.Name = "hoverButton1";
            this.hoverButton1.Size = new System.Drawing.Size(347, 345);
            this.hoverButton1.TabIndex = 3;
            this.hoverButton1.Text = "hoverButton1";
            this.hoverButton1.UseVisualStyleBackColor = true;
            // 
            // hoverButton2
            // 
            this.hoverButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButton2.ForeColor = System.Drawing.Color.White;
            this.hoverButton2.Location = new System.Drawing.Point(12, 46);
            this.hoverButton2.Name = "hoverButton2";
            this.hoverButton2.Size = new System.Drawing.Size(342, 345);
            this.hoverButton2.TabIndex = 2;
            this.hoverButton2.Text = "hoverButton2";
            this.hoverButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hoverButton1);
            this.Controls.Add(this.hoverButton2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CGallery hoverButton2;
        private CircleGallery hoverButton1;
    }
}

