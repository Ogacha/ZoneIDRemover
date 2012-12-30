namespace ZoneIDRemover
{
    partial class 設定画面
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.ファイル選択ボタン = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ファイル名欄 = new System.Windows.Forms.TextBox();
            this.実行ボタン = new System.Windows.Forms.Button();
            this.情報欄 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ファイル選択ボタン
            // 
            this.ファイル選択ボタン.Location = new System.Drawing.Point(245, 22);
            this.ファイル選択ボタン.Name = "ファイル選択ボタン";
            this.ファイル選択ボタン.Size = new System.Drawing.Size(27, 23);
            this.ファイル選択ボタン.TabIndex = 0;
            this.ファイル選択ボタン.Text = "button1";
            this.ファイル選択ボタン.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ファイル名欄
            // 
            this.ファイル名欄.Location = new System.Drawing.Point(13, 22);
            this.ファイル名欄.Name = "ファイル名欄";
            this.ファイル名欄.Size = new System.Drawing.Size(226, 19);
            this.ファイル名欄.TabIndex = 1;
            // 
            // 実行ボタン
            // 
            this.実行ボタン.Location = new System.Drawing.Point(23, 60);
            this.実行ボタン.Name = "実行ボタン";
            this.実行ボタン.Size = new System.Drawing.Size(75, 23);
            this.実行ボタン.TabIndex = 2;
            this.実行ボタン.Text = "button2";
            this.実行ボタン.UseVisualStyleBackColor = true;
            // 
            // 情報欄
            // 
            this.情報欄.Location = new System.Drawing.Point(13, 105);
            this.情報欄.Multiline = true;
            this.情報欄.Name = "情報欄";
            this.情報欄.Size = new System.Drawing.Size(259, 145);
            this.情報欄.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.情報欄);
            this.Controls.Add(this.実行ボタン);
            this.Controls.Add(this.ファイル名欄);
            this.Controls.Add(this.ファイル選択ボタン);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ファイル選択ボタン;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox ファイル名欄;
        private System.Windows.Forms.Button 実行ボタン;
        private System.Windows.Forms.TextBox 情報欄;
    }
}

