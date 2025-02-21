namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button BtnStart;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LblMsg = new System.Windows.Forms.Label();
            this.BtnStop = new System.Windows.Forms.Button();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.TmrGo = new System.Windows.Forms.Timer(this.components);
            this.ImgDice = new System.Windows.Forms.ImageList(this.components);
            BtnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("新細明體", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(258, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "擲骰子遊戲";
            // 
            // LblMsg
            // 
            this.LblMsg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LblMsg.Location = new System.Drawing.Point(228, 258);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(255, 51);
            this.LblMsg.TabIndex = 2;
            this.LblMsg.Text = "label2";
            // 
            // BtnStart
            // 
            BtnStart.Location = new System.Drawing.Point(195, 348);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new System.Drawing.Size(101, 33);
            BtnStart.TabIndex = 3;
            BtnStart.Text = "開始";
            BtnStart.UseVisualStyleBackColor = true;
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(419, 348);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(99, 33);
            this.BtnStop.TabIndex = 4;
            this.BtnStop.Text = "停止";
            this.BtnStop.UseVisualStyleBackColor = true;
            // 
            // Pic1
            // 
            this.Pic1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.d6;
            this.Pic1.Location = new System.Drawing.Point(320, 164);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(56, 56);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic1.TabIndex = 1;
            this.Pic1.TabStop = false;
            // 
            // ImgDice
            // 
            this.ImgDice.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgDice.ImageStream")));
            this.ImgDice.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgDice.Images.SetKeyName(0, "d1.jpg");
            this.ImgDice.Images.SetKeyName(1, "d2.jpg");
            this.ImgDice.Images.SetKeyName(2, "d3.jpg");
            this.ImgDice.Images.SetKeyName(3, "d4.jpg");
            this.ImgDice.Images.SetKeyName(4, "d5.jpg");
            this.ImgDice.Images.SetKeyName(5, "d6.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(BtnStart);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.Pic1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Timer TmrGo;
        private System.Windows.Forms.ImageList ImgDice;
    }
}

