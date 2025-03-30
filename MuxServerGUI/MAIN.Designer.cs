namespace MuxServerGUI
{
    partial class MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.XML = new System.Windows.Forms.Label();
            this.XML_T = new System.Windows.Forms.TextBox();
            this.MUX_M = new System.Windows.Forms.TextBox();
            this.MUX = new System.Windows.Forms.Label();
            this.PORT_T = new System.Windows.Forms.TextBox();
            this.PORT = new System.Windows.Forms.Label();
            this.CLIP_T = new System.Windows.Forms.TextBox();
            this.CLIP = new System.Windows.Forms.Label();
            this.WAIT = new System.Windows.Forms.Label();
            this.WAIT_T = new System.Windows.Forms.ComboBox();
            this.Execute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XML
            // 
            this.XML.AutoSize = true;
            this.XML.Font = new System.Drawing.Font("Vineta BT", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XML.Location = new System.Drawing.Point(12, 13);
            this.XML.Name = "XML";
            this.XML.Size = new System.Drawing.Size(160, 19);
            this.XML.TabIndex = 0;
            this.XML.Text = "Open project：";
            // 
            // XML_T
            // 
            this.XML_T.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.XML_T.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.XML_T.Location = new System.Drawing.Point(167, 8);
            this.XML_T.Name = "XML_T";
            this.XML_T.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.XML_T.Size = new System.Drawing.Size(393, 21);
            this.XML_T.TabIndex = 1;
            this.XML_T.WordWrap = false;
            // 
            // MUX_M
            // 
            this.MUX_M.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MUX_M.Location = new System.Drawing.Point(19, 54);
            this.MUX_M.Multiline = true;
            this.MUX_M.Name = "MUX_M";
            this.MUX_M.ReadOnly = true;
            this.MUX_M.Size = new System.Drawing.Size(541, 21);
            this.MUX_M.TabIndex = 3;
            this.MUX_M.WordWrap = false;
            // 
            // MUX
            // 
            this.MUX.AutoSize = true;
            this.MUX.Font = new System.Drawing.Font("Vineta BT", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MUX.Location = new System.Drawing.Point(12, 35);
            this.MUX.Name = "MUX";
            this.MUX.Size = new System.Drawing.Size(398, 19);
            this.MUX.TabIndex = 2;
            this.MUX.Text = "Path to the Mux Server executable：";
            // 
            // PORT_T
            // 
            this.PORT_T.Location = new System.Drawing.Point(72, 86);
            this.PORT_T.Multiline = true;
            this.PORT_T.Name = "PORT_T";
            this.PORT_T.Size = new System.Drawing.Size(35, 21);
            this.PORT_T.TabIndex = 5;
            this.PORT_T.Text = "9920";
            // 
            // PORT
            // 
            this.PORT.AutoSize = true;
            this.PORT.Font = new System.Drawing.Font("Vineta BT", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PORT.Location = new System.Drawing.Point(12, 86);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(68, 19);
            this.PORT.TabIndex = 4;
            this.PORT.Text = "port：";
            // 
            // CLIP_T
            // 
            this.CLIP_T.Location = new System.Drawing.Point(175, 86);
            this.CLIP_T.Multiline = true;
            this.CLIP_T.Name = "CLIP_T";
            this.CLIP_T.Size = new System.Drawing.Size(35, 21);
            this.CLIP_T.TabIndex = 7;
            this.CLIP_T.Text = "1";
            // 
            // CLIP
            // 
            this.CLIP.AutoSize = true;
            this.CLIP.Font = new System.Drawing.Font("Vineta BT", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLIP.Location = new System.Drawing.Point(115, 86);
            this.CLIP.Name = "CLIP";
            this.CLIP.Size = new System.Drawing.Size(65, 19);
            this.CLIP.TabIndex = 6;
            this.CLIP.Text = "clip：";
            // 
            // WAIT
            // 
            this.WAIT.AutoSize = true;
            this.WAIT.Font = new System.Drawing.Font("Vineta BT", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WAIT.Location = new System.Drawing.Point(219, 86);
            this.WAIT.Name = "WAIT";
            this.WAIT.Size = new System.Drawing.Size(70, 19);
            this.WAIT.TabIndex = 8;
            this.WAIT.Text = "wait：";
            // 
            // WAIT_T
            // 
            this.WAIT_T.FormattingEnabled = true;
            this.WAIT_T.Items.AddRange(new object[] {
            "True",
            "False"});
            this.WAIT_T.Location = new System.Drawing.Point(283, 86);
            this.WAIT_T.Name = "WAIT_T";
            this.WAIT_T.Size = new System.Drawing.Size(53, 20);
            this.WAIT_T.TabIndex = 9;
            this.WAIT_T.Text = "True";
            // 
            // Execute
            // 
            this.Execute.Font = new System.Drawing.Font("Vineta BT", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.Location = new System.Drawing.Point(454, 86);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(103, 23);
            this.Execute.TabIndex = 10;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(574, 121);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.WAIT_T);
            this.Controls.Add(this.WAIT);
            this.Controls.Add(this.CLIP_T);
            this.Controls.Add(this.CLIP);
            this.Controls.Add(this.PORT_T);
            this.Controls.Add(this.PORT);
            this.Controls.Add(this.MUX_M);
            this.Controls.Add(this.MUX);
            this.Controls.Add(this.XML_T);
            this.Controls.Add(this.XML);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MuxServerGUI_v0.1 by@KSSW | Original author: shimamura-hougetsu";
            this.Load += new System.EventHandler(this.MAIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label XML;
        private System.Windows.Forms.TextBox XML_T;
        private System.Windows.Forms.TextBox MUX_M;
        private System.Windows.Forms.Label MUX;
        private System.Windows.Forms.TextBox PORT_T;
        private System.Windows.Forms.Label PORT;
        private System.Windows.Forms.TextBox CLIP_T;
        private System.Windows.Forms.Label CLIP;
        private System.Windows.Forms.Label WAIT;
        private System.Windows.Forms.ComboBox WAIT_T;
        private System.Windows.Forms.Button Execute;
    }
}

