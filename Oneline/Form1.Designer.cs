
namespace Oneline
{
    partial class FormOneline
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOneline));
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnTransform = new System.Windows.Forms.Button();
            this.cbxAuto = new System.Windows.Forms.CheckBox();
            this.cbxCopy = new System.Windows.Forms.CheckBox();
            this._timerForAuto = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(10, 44);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(589, 275);
            this.txtContent.TabIndex = 0;
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(12, 12);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(66, 24);
            this.btnTransform.TabIndex = 1;
            this.btnTransform.Text = "转换";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // cbxAuto
            // 
            this.cbxAuto.AutoSize = true;
            this.cbxAuto.Location = new System.Drawing.Point(84, 17);
            this.cbxAuto.Name = "cbxAuto";
            this.cbxAuto.Size = new System.Drawing.Size(48, 16);
            this.cbxAuto.TabIndex = 2;
            this.cbxAuto.Text = "自动";
            this.cbxAuto.UseVisualStyleBackColor = true;
            this.cbxAuto.CheckedChanged += new System.EventHandler(this.cbxAuto_CheckedChanged);
            // 
            // cbxCopy
            // 
            this.cbxCopy.AutoSize = true;
            this.cbxCopy.Location = new System.Drawing.Point(138, 17);
            this.cbxCopy.Name = "cbxCopy";
            this.cbxCopy.Size = new System.Drawing.Size(96, 16);
            this.cbxCopy.TabIndex = 2;
            this.cbxCopy.Text = "复制到剪贴板";
            this.cbxCopy.UseVisualStyleBackColor = true;
            this.cbxCopy.CheckedChanged += new System.EventHandler(this.cbxCopy_CheckedChanged);
            // 
            // _timerForAuto
            // 
            this._timerForAuto.Interval = 500;
            // 
            // FormOneline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 331);
            this.Controls.Add(this.cbxCopy);
            this.Controls.Add(this.cbxAuto);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.txtContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOneline";
            this.Text = "Oneline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.CheckBox cbxAuto;
        private System.Windows.Forms.CheckBox cbxCopy;
        private System.Windows.Forms.Timer _timerForAuto;
    }
}

