
namespace Sample
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDirectoryName = new System.Windows.Forms.Label();
            this.textBoxDirectoryName = new System.Windows.Forms.TextBox();
            this.buttonSelect1 = new System.Windows.Forms.Button();
            this.buttonSelect2 = new System.Windows.Forms.Button();
            this.selectDirectoryDialog1 = new SelectDirectoryDialog();
            this.SuspendLayout();
            // 
            // labelDirectoryName
            // 
            this.labelDirectoryName.AutoSize = true;
            this.labelDirectoryName.Location = new System.Drawing.Point(12, 15);
            this.labelDirectoryName.Name = "labelDirectoryName";
            this.labelDirectoryName.Size = new System.Drawing.Size(83, 12);
            this.labelDirectoryName.TabIndex = 0;
            this.labelDirectoryName.Text = "&DirectoryName:";
            // 
            // textBoxDirectoryName
            // 
            this.textBoxDirectoryName.Location = new System.Drawing.Point(101, 12);
            this.textBoxDirectoryName.Name = "textBoxDirectoryName";
            this.textBoxDirectoryName.Size = new System.Drawing.Size(687, 19);
            this.textBoxDirectoryName.TabIndex = 1;
            // 
            // buttonSelect1
            // 
            this.buttonSelect1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect1.Location = new System.Drawing.Point(632, 37);
            this.buttonSelect1.Name = "buttonSelect1";
            this.buttonSelect1.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect1.TabIndex = 2;
            this.buttonSelect1.Text = "Select (&1)";
            this.buttonSelect1.UseVisualStyleBackColor = true;
            this.buttonSelect1.Click += new System.EventHandler(this.buttonSelect1_Click);
            // 
            // buttonSelect2
            // 
            this.buttonSelect2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect2.Location = new System.Drawing.Point(713, 37);
            this.buttonSelect2.Name = "buttonSelect2";
            this.buttonSelect2.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect2.TabIndex = 3;
            this.buttonSelect2.Text = "Select (&2)";
            this.buttonSelect2.UseVisualStyleBackColor = true;
            this.buttonSelect2.Click += new System.EventHandler(this.buttonSelect2_Click);
            // 
            // selectDirectoryDialog1
            // 
            this.selectDirectoryDialog1.DirectoryName = null;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 72);
            this.Controls.Add(this.buttonSelect2);
            this.Controls.Add(this.buttonSelect1);
            this.Controls.Add(this.textBoxDirectoryName);
            this.Controls.Add(this.labelDirectoryName);
            this.Name = "FormMain";
            this.Text = "FileOpenDialog Sample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDirectoryName;
        private System.Windows.Forms.TextBox textBoxDirectoryName;
        private System.Windows.Forms.Button buttonSelect1;
        private System.Windows.Forms.Button buttonSelect2;
        private SelectDirectoryDialog selectDirectoryDialog1;
    }
}

