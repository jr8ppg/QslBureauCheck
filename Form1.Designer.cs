
namespace QslBureauCheck
{
	partial class Form1
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
            this.panelInputBase = new System.Windows.Forms.Panel();
            this.panelInputBody = new System.Windows.Forms.Panel();
            this.textInput = new System.Windows.Forms.TextBox();
            this.panelInputHead = new System.Windows.Forms.Panel();
            this.buttonLoadFromFIle = new System.Windows.Forms.Button();
            this.panelOutputBase = new System.Windows.Forms.Panel();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.panelOutputHead = new System.Windows.Forms.Panel();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelInputBase.SuspendLayout();
            this.panelInputBody.SuspendLayout();
            this.panelInputHead.SuspendLayout();
            this.panelOutputBase.SuspendLayout();
            this.panelOutputHead.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInputBase
            // 
            this.panelInputBase.Controls.Add(this.panelInputBody);
            this.panelInputBase.Controls.Add(this.panelInputHead);
            this.panelInputBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputBase.Location = new System.Drawing.Point(0, 0);
            this.panelInputBase.Name = "panelInputBase";
            this.panelInputBase.Size = new System.Drawing.Size(506, 566);
            this.panelInputBase.TabIndex = 0;
            // 
            // panelInputBody
            // 
            this.panelInputBody.Controls.Add(this.textInput);
            this.panelInputBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputBody.Location = new System.Drawing.Point(0, 49);
            this.panelInputBody.Name = "panelInputBody";
            this.panelInputBody.Size = new System.Drawing.Size(506, 517);
            this.panelInputBody.TabIndex = 2;
            // 
            // textInput
            // 
            this.textInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textInput.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textInput.Location = new System.Drawing.Point(0, 0);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textInput.Size = new System.Drawing.Size(506, 517);
            this.textInput.TabIndex = 1;
            this.textInput.WordWrap = false;
            // 
            // panelInputHead
            // 
            this.panelInputHead.Controls.Add(this.label3);
            this.panelInputHead.Controls.Add(this.label2);
            this.panelInputHead.Controls.Add(this.buttonLoadFromFIle);
            this.panelInputHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInputHead.Location = new System.Drawing.Point(0, 0);
            this.panelInputHead.Name = "panelInputHead";
            this.panelInputHead.Size = new System.Drawing.Size(506, 49);
            this.panelInputHead.TabIndex = 1;
            // 
            // buttonLoadFromFIle
            // 
            this.buttonLoadFromFIle.Location = new System.Drawing.Point(8, 8);
            this.buttonLoadFromFIle.Name = "buttonLoadFromFIle";
            this.buttonLoadFromFIle.Size = new System.Drawing.Size(120, 30);
            this.buttonLoadFromFIle.TabIndex = 0;
            this.buttonLoadFromFIle.Text = "ファイル読み込み";
            this.buttonLoadFromFIle.UseVisualStyleBackColor = true;
            this.buttonLoadFromFIle.Click += new System.EventHandler(this.buttonLoadFromFIle_Click);
            // 
            // panelOutputBase
            // 
            this.panelOutputBase.Controls.Add(this.textOutput);
            this.panelOutputBase.Controls.Add(this.panelOutputHead);
            this.panelOutputBase.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOutputBase.Location = new System.Drawing.Point(661, 0);
            this.panelOutputBase.Name = "panelOutputBase";
            this.panelOutputBase.Size = new System.Drawing.Size(464, 566);
            this.panelOutputBase.TabIndex = 1;
            // 
            // textOutput
            // 
            this.textOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textOutput.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textOutput.Location = new System.Drawing.Point(0, 49);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOutput.Size = new System.Drawing.Size(464, 517);
            this.textOutput.TabIndex = 3;
            this.textOutput.WordWrap = false;
            // 
            // panelOutputHead
            // 
            this.panelOutputHead.Controls.Add(this.label1);
            this.panelOutputHead.Controls.Add(this.buttonSaveToFile);
            this.panelOutputHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOutputHead.Location = new System.Drawing.Point(0, 0);
            this.panelOutputHead.Name = "panelOutputHead";
            this.panelOutputHead.Size = new System.Drawing.Size(464, 49);
            this.panelOutputHead.TabIndex = 2;
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveToFile.Location = new System.Drawing.Point(332, 8);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(120, 30);
            this.buttonSaveToFile.TabIndex = 0;
            this.buttonSaveToFile.Text = "ファイル保存";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(658, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 566);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.buttonQuery);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCenter.Location = new System.Drawing.Point(506, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(152, 566);
            this.panelCenter.TabIndex = 4;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(16, 244);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(120, 30);
            this.buttonQuery.TabIndex = 1;
            this.buttonQuery.Text = "転送可否照会";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "ADIFファイル|*.adi;*.adif|Cabrilloファイル|*.CBR|すべてのファイル|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "ADIFファイル|*.adi|Cabrilloファイル|*.CBR|すべてのファイル|*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "転送可";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(385, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "元ファイル";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(134, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "ADIFまたはCabrilloファイルを読み込むか貼り付けして下さい。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 566);
            this.Controls.Add(this.panelInputBase);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelOutputBase);
            this.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form1";
            this.Text = "JARL転送可否照会";
            this.panelInputBase.ResumeLayout(false);
            this.panelInputBody.ResumeLayout(false);
            this.panelInputBody.PerformLayout();
            this.panelInputHead.ResumeLayout(false);
            this.panelInputHead.PerformLayout();
            this.panelOutputBase.ResumeLayout(false);
            this.panelOutputBase.PerformLayout();
            this.panelOutputHead.ResumeLayout(false);
            this.panelOutputHead.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel panelInputBase;
        private System.Windows.Forms.Panel panelInputBody;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Panel panelInputHead;
        private System.Windows.Forms.Button buttonLoadFromFIle;
        private System.Windows.Forms.Panel panelOutputBase;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Panel panelOutputHead;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

