namespace Gomoku
{
    partial class MainForm
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
            this.Btn_Restart = new System.Windows.Forms.Button();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.PicBox_Board = new System.Windows.Forms.PictureBox();
            this.lbl_ColorOfChess = new System.Windows.Forms.Label();
            this.lbl_Turns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Board)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Restart
            // 
            this.Btn_Restart.Location = new System.Drawing.Point(890, 12);
            this.Btn_Restart.Name = "Btn_Restart";
            this.Btn_Restart.Size = new System.Drawing.Size(106, 74);
            this.Btn_Restart.TabIndex = 0;
            this.Btn_Restart.Text = "Restart";
            this.Btn_Restart.UseVisualStyleBackColor = true;
            this.Btn_Restart.Click += new System.EventHandler(this.Btn_Restart_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Enabled = false;
            this.Btn_Start.Location = new System.Drawing.Point(890, 92);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(106, 74);
            this.Btn_Start.TabIndex = 1;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            // 
            // PicBox_Board
            // 
            this.PicBox_Board.BackColor = System.Drawing.Color.Transparent;
            this.PicBox_Board.Image = global::Gomoku.Properties.Resources.borad;
            this.PicBox_Board.Location = new System.Drawing.Point(10, 10);
            this.PicBox_Board.Margin = new System.Windows.Forms.Padding(0);
            this.PicBox_Board.Name = "PicBox_Board";
            this.PicBox_Board.Size = new System.Drawing.Size(810, 802);
            this.PicBox_Board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicBox_Board.TabIndex = 2;
            this.PicBox_Board.TabStop = false;
            this.PicBox_Board.Click += new System.EventHandler(this.PicBox_Board_Click);
            // 
            // lbl_ColorOfChess
            // 
            this.lbl_ColorOfChess.AutoSize = true;
            this.lbl_ColorOfChess.Font = new System.Drawing.Font("宋体", 25F);
            this.lbl_ColorOfChess.Location = new System.Drawing.Point(884, 385);
            this.lbl_ColorOfChess.Name = "lbl_ColorOfChess";
            this.lbl_ColorOfChess.Size = new System.Drawing.Size(83, 34);
            this.lbl_ColorOfChess.TabIndex = 19;
            this.lbl_ColorOfChess.Text = "颜色";
            // 
            // lbl_Turns
            // 
            this.lbl_Turns.AutoSize = true;
            this.lbl_Turns.Font = new System.Drawing.Font("宋体", 25F);
            this.lbl_Turns.Location = new System.Drawing.Point(884, 304);
            this.lbl_Turns.Name = "lbl_Turns";
            this.lbl_Turns.Size = new System.Drawing.Size(117, 34);
            this.lbl_Turns.TabIndex = 20;
            this.lbl_Turns.Text = "第几步";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 818);
            this.Controls.Add(this.lbl_Turns);
            this.Controls.Add(this.lbl_ColorOfChess);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Btn_Restart);
            this.Controls.Add(this.PicBox_Board);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Restart;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.PictureBox PicBox_Board;
        private System.Windows.Forms.Label lbl_ColorOfChess;
        private System.Windows.Forms.Label lbl_Turns;
    }
}

