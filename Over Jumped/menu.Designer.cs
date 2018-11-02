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
            this.LoadGame.Click += new System.EventHandler(this.LoadGame_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 440);
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
    }
}