namespace 去除参考文献
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.clearStart = new System.Windows.Forms.Button();
            this.orgText = new System.Windows.Forms.TextBox();
            this.targetText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clearStart
            // 
            this.clearStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearStart.Location = new System.Drawing.Point(509, 632);
            this.clearStart.Name = "clearStart";
            this.clearStart.Size = new System.Drawing.Size(89, 39);
            this.clearStart.TabIndex = 0;
            this.clearStart.Text = "clear";
            this.clearStart.UseVisualStyleBackColor = true;
            this.clearStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // orgText
            // 
            this.orgText.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orgText.Location = new System.Drawing.Point(12, 12);
            this.orgText.Multiline = true;
            this.orgText.Name = "orgText";
            this.orgText.Size = new System.Drawing.Size(1067, 317);
            this.orgText.TabIndex = 1;
            // 
            // targetText
            // 
            this.targetText.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.targetText.Location = new System.Drawing.Point(12, 335);
            this.targetText.Multiline = true;
            this.targetText.Name = "targetText";
            this.targetText.Size = new System.Drawing.Size(1067, 291);
            this.targetText.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 689);
            this.Controls.Add(this.targetText);
            this.Controls.Add(this.orgText);
            this.Controls.Add(this.clearStart);
            this.Name = "Form1";
            this.Text = "去除参考文献";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button clearStart;
        private System.Windows.Forms.TextBox orgText;
        private System.Windows.Forms.TextBox targetText;
    }
}

