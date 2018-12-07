namespace Over_Jumped
{
    partial class menu
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
            this.SaveGame = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.LoadGame = new System.Windows.Forms.Button();
            this.resumeGame = new System.Windows.Forms.Button();
            this.exitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveGame
            // 
            this.SaveGame.Location = new System.Drawing.Point(128, 122);
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.Size = new System.Drawing.Size(81, 46);
            this.SaveGame.TabIndex = 0;
            this.SaveGame.Text = "Save";
            this.SaveGame.UseVisualStyleBackColor = true;
            this.SaveGame.Visible = false;
            this.SaveGame.Click += new System.EventHandler(this.SaveGame_Click);
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(128, 63);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(81, 44);
            this.NewGame.TabIndex = 1;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // LoadGame
            // 
            this.LoadGame.Location = new System.Drawing.Point(128, 184);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(81, 56);
            this.LoadGame.TabIndex = 2;
            this.LoadGame.Text = "Load Game";
            this.LoadGame.UseVisualStyleBackColor = true;
            this.LoadGame.Visible = false;
            this.LoadGame.Click += new System.EventHandler(this.LoadGame_Click);
            // 
            // resumeGame
            // 
            this.resumeGame.Location = new System.Drawing.Point(128, 263);
            this.resumeGame.Name = "resumeGame";
            this.resumeGame.Size = new System.Drawing.Size(80, 54);
            this.resumeGame.TabIndex = 3;
            this.resumeGame.Text = "Resume";
            this.resumeGame.UseVisualStyleBackColor = true;
            this.resumeGame.Visible = false;
            this.resumeGame.Click += new System.EventHandler(this.resumeGame_Click);
            // 
            // exitGame
            // 
            this.exitGame.Location = new System.Drawing.Point(129, 337);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(79, 51);
            this.exitGame.TabIndex = 4;
            this.exitGame.Text = "Exit";
            this.exitGame.UseVisualStyleBackColor = true;
            this.exitGame.Click += new System.EventHandler(this.exitGame_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 440);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.resumeGame);
            this.Controls.Add(this.LoadGame);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.SaveGame);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveGame;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button LoadGame;
        private System.Windows.Forms.Button resumeGame;
        private System.Windows.Forms.Button exitGame;
    }
}