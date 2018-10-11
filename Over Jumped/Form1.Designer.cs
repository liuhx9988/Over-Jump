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
            this.Player = new System.Windows.Forms.PictureBox();
            this.Test = new System.Windows.Forms.Label();
            Ver = new System.Windows.Forms.Timer(this.components);
            Hor = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
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
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Over_Jumped.Properties.Resources.download;
            this.Player.Location = new System.Drawing.Point(378, 228);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(142, 221);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Test
            // 
            this.Test.AutoSize = true;
            this.Test.Location = new System.Drawing.Point(167, 123);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(0, 17);
            this.Test.TabIndex = 1;
            // 
            // Over_Jumped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 941);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.Player);
            this.Name = "Over_Jumped";
            this.Text = "Over Jumped";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Over_Jumped_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Over_Jumped_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label Test;
    }
}

