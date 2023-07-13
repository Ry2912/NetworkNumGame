
namespace NetworkNumGame
{
    partial class MainForm
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
            this.TextMemo = new System.Windows.Forms.TextBox();
            this.ButtonInput = new System.Windows.Forms.Button();
            this.NUD = new System.Windows.Forms.NumericUpDown();
            this.TextResult = new System.Windows.Forms.TextBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.NUDthreshold = new System.Windows.Forms.NumericUpDown();
            this.Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDthreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // TextMemo
            // 
            this.TextMemo.Location = new System.Drawing.Point(12, 22);
            this.TextMemo.Multiline = true;
            this.TextMemo.Name = "TextMemo";
            this.TextMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextMemo.Size = new System.Drawing.Size(478, 416);
            this.TextMemo.TabIndex = 0;
            // 
            // ButtonInput
            // 
            this.ButtonInput.Location = new System.Drawing.Point(672, 126);
            this.ButtonInput.Name = "ButtonInput";
            this.ButtonInput.Size = new System.Drawing.Size(86, 36);
            this.ButtonInput.TabIndex = 1;
            this.ButtonInput.Text = "input Q";
            this.ButtonInput.UseVisualStyleBackColor = true;
            this.ButtonInput.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // NUD
            // 
            this.NUD.Location = new System.Drawing.Point(519, 126);
            this.NUD.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD.Name = "NUD";
            this.NUD.Size = new System.Drawing.Size(120, 25);
            this.NUD.TabIndex = 2;
            this.NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // TextResult
            // 
            this.TextResult.Location = new System.Drawing.Point(519, 195);
            this.TextResult.Multiline = true;
            this.TextResult.Name = "TextResult";
            this.TextResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextResult.Size = new System.Drawing.Size(239, 173);
            this.TextResult.TabIndex = 3;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(519, 31);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(239, 36);
            this.ButtonStart.TabIndex = 4;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // NUDthreshold
            // 
            this.NUDthreshold.Location = new System.Drawing.Point(638, 404);
            this.NUDthreshold.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NUDthreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDthreshold.Name = "NUDthreshold";
            this.NUDthreshold.Size = new System.Drawing.Size(120, 25);
            this.NUDthreshold.TabIndex = 5;
            this.NUDthreshold.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(529, 406);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(68, 18);
            this.Label.TabIndex = 6;
            this.Label.Text = "しきい値";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.NUDthreshold);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.TextResult);
            this.Controls.Add(this.NUD);
            this.Controls.Add(this.ButtonInput);
            this.Controls.Add(this.TextMemo);
            this.Name = "MainForm";
            this.Text = "NetworkNumGame";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDthreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextMemo;
        private System.Windows.Forms.Button ButtonInput;
        private System.Windows.Forms.NumericUpDown NUD;
        private System.Windows.Forms.TextBox TextResult;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.NumericUpDown NUDthreshold;
        private System.Windows.Forms.Label Label;
    }
}

