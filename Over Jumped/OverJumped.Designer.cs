namespace Over_Jumped
{
    partial class Over_Jumped
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer Ver;
            System.Windows.Forms.Timer Hor;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Over_Jumped));
            this.Test = new System.Windows.Forms.Label();
            this.Box0 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Box1 = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.ScoreNum = new System.Windows.Forms.Label();
            Ver = new System.Windows.Forms.Timer(this.components);
            Hor = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Box0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ver
            // 
            Ver.Enabled = true;
            Ver.Interval = 10;
            Ver.Tick += new System.EventHandler(this.Ver_Tick);
            // 
            // Hor
            // 
            Hor.Enabled = true;
            Hor.Interval = 10;
            Hor.Tick += new System.EventHandler(this.Hor_Tick);
            // 
            // Test
            // 
            this.Test.AutoSize = true;
            this.Test.Location = new System.Drawing.Point(167, 123);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(0, 17);
            this.Test.TabIndex = 1;
            // 
            // Box0
            // 
            this.Box0.Image = global::Over_Jumped.Properties.Resources.White_full;
            this.Box0.Location = new System.Drawing.Point(670, 668);
            this.Box0.Name = "Box0";
            this.Box0.Size = new System.Drawing.Size(351, 97);
            this.Box0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box0.TabIndex = 2;
            this.Box0.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(529, 584);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(75, 73);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Box1
            // 
            this.Box1.Image = global::Over_Jumped.Properties.Resources.White_full;
            this.Box1.Location = new System.Drawing.Point(12, 488);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(351, 97);
            this.Box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box1.TabIndex = 3;
            this.Box1.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Location = new System.Drawing.Point(934, 36);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(49, 17);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score:";
            // 
            // ScoreNum
            // 
            this.ScoreNum.AutoSize = true;
            this.ScoreNum.Location = new System.Drawing.Point(989, 36);
            this.ScoreNum.Name = "ScoreNum";
            this.ScoreNum.Size = new System.Drawing.Size(16, 17);
            this.ScoreNum.TabIndex = 5;
            this.ScoreNum.Text = "0";
            // 
            // Over_Jumped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 941);
            this.Controls.Add(this.ScoreNum);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.Box0);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.Player);
            this.Name = "Over_Jumped";
            this.Text = "Over Jumped";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Over_Jumped_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Over_Jumped_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Box0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label Test;
        private System.Windows.Forms.PictureBox Box0;
        private System.Windows.Forms.PictureBox Box1;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Label ScoreNum;
    }
}

