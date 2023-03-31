namespace Rock_Scissors_Paper
{
    partial class ChooseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseForm));
            this.LbNickname = new System.Windows.Forms.Label();
            this.TbPlayerNickname = new System.Windows.Forms.TextBox();
            this.BtStart = new System.Windows.Forms.Button();
            this.LbBotName = new System.Windows.Forms.Label();
            this.LbPlayerName = new System.Windows.Forms.Label();
            this.LbResult = new System.Windows.Forms.Label();
            this.LbChoseItem = new System.Windows.Forms.Label();
            this.BtReset = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            this.PbPaper = new System.Windows.Forms.PictureBox();
            this.PbScissors = new System.Windows.Forms.PictureBox();
            this.PbRock = new System.Windows.Forms.PictureBox();
            this.PbBot = new System.Windows.Forms.PictureBox();
            this.PbPlayer = new System.Windows.Forms.PictureBox();
            this.LbVs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // LbNickname
            // 
            this.LbNickname.AutoSize = true;
            this.LbNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbNickname.Location = new System.Drawing.Point(72, 20);
            this.LbNickname.Name = "LbNickname";
            this.LbNickname.Size = new System.Drawing.Size(225, 20);
            this.LbNickname.TabIndex = 0;
            this.LbNickname.Text = "Въведете вашето име:";
            // 
            // TbPlayerNickname
            // 
            this.TbPlayerNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbPlayerNickname.Location = new System.Drawing.Point(317, 18);
            this.TbPlayerNickname.Name = "TbPlayerNickname";
            this.TbPlayerNickname.Size = new System.Drawing.Size(146, 26);
            this.TbPlayerNickname.TabIndex = 1;
            // 
            // BtStart
            // 
            this.BtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtStart.Location = new System.Drawing.Point(252, 68);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(121, 43);
            this.BtStart.TabIndex = 2;
            this.BtStart.Text = "Старт";
            this.BtStart.UseVisualStyleBackColor = true;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // LbBotName
            // 
            this.LbBotName.AutoSize = true;
            this.LbBotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbBotName.Location = new System.Drawing.Point(417, 106);
            this.LbBotName.Name = "LbBotName";
            this.LbBotName.Size = new System.Drawing.Size(104, 20);
            this.LbBotName.TabIndex = 5;
            this.LbBotName.Text = "Компютър";
            this.LbBotName.Visible = false;
            // 
            // LbPlayerName
            // 
            this.LbPlayerName.AutoSize = true;
            this.LbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbPlayerName.Location = new System.Drawing.Point(90, 106);
            this.LbPlayerName.Name = "LbPlayerName";
            this.LbPlayerName.Size = new System.Drawing.Size(0, 20);
            this.LbPlayerName.TabIndex = 6;
            // 
            // LbResult
            // 
            this.LbResult.AutoSize = true;
            this.LbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbResult.Location = new System.Drawing.Point(228, 317);
            this.LbResult.Name = "LbResult";
            this.LbResult.Size = new System.Drawing.Size(107, 20);
            this.LbResult.TabIndex = 7;
            this.LbResult.Text = "Резултат: ";
            // 
            // LbChoseItem
            // 
            this.LbChoseItem.AutoSize = true;
            this.LbChoseItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbChoseItem.Location = new System.Drawing.Point(170, 379);
            this.LbChoseItem.Name = "LbChoseItem";
            this.LbChoseItem.Size = new System.Drawing.Size(190, 20);
            this.LbChoseItem.TabIndex = 8;
            this.LbChoseItem.Text = "Изберете предмет:";
            // 
            // BtReset
            // 
            this.BtReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtReset.Location = new System.Drawing.Point(510, 430);
            this.BtReset.Name = "BtReset";
            this.BtReset.Size = new System.Drawing.Size(121, 43);
            this.BtReset.TabIndex = 12;
            this.BtReset.Text = "Рестарт";
            this.BtReset.UseVisualStyleBackColor = true;
            this.BtReset.Click += new System.EventHandler(this.BtReset_Click);
            // 
            // BtClose
            // 
            this.BtClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtClose.Location = new System.Drawing.Point(510, 491);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(121, 43);
            this.BtClose.TabIndex = 13;
            this.BtClose.Text = "Затвори";
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // PbPaper
            // 
            this.PbPaper.Image = global::Rock_Scissors_Paper.Properties.Resources.paper1;
            this.PbPaper.Location = new System.Drawing.Point(343, 424);
            this.PbPaper.Name = "PbPaper";
            this.PbPaper.Size = new System.Drawing.Size(129, 118);
            this.PbPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbPaper.TabIndex = 11;
            this.PbPaper.TabStop = false;
            this.PbPaper.Click += new System.EventHandler(this.PbPaper_Click);
            // 
            // PbScissors
            // 
            this.PbScissors.Image = global::Rock_Scissors_Paper.Properties.Resources.scissors;
            this.PbScissors.Location = new System.Drawing.Point(171, 424);
            this.PbScissors.Name = "PbScissors";
            this.PbScissors.Size = new System.Drawing.Size(129, 118);
            this.PbScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbScissors.TabIndex = 10;
            this.PbScissors.TabStop = false;
            this.PbScissors.Click += new System.EventHandler(this.PbScissors_Click);
            // 
            // PbRock
            // 
            this.PbRock.Image = global::Rock_Scissors_Paper.Properties.Resources.rock;
            this.PbRock.Location = new System.Drawing.Point(29, 411);
            this.PbRock.Name = "PbRock";
            this.PbRock.Size = new System.Drawing.Size(141, 131);
            this.PbRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbRock.TabIndex = 9;
            this.PbRock.TabStop = false;
            this.PbRock.Click += new System.EventHandler(this.PbRock_Click);
            // 
            // PbBot
            // 
            this.PbBot.Image = global::Rock_Scissors_Paper.Properties.Resources.question;
            this.PbBot.Location = new System.Drawing.Point(381, 137);
            this.PbBot.Name = "PbBot";
            this.PbBot.Size = new System.Drawing.Size(175, 165);
            this.PbBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBot.TabIndex = 4;
            this.PbBot.TabStop = false;
            // 
            // PbPlayer
            // 
            this.PbPlayer.Image = global::Rock_Scissors_Paper.Properties.Resources.question;
            this.PbPlayer.Location = new System.Drawing.Point(66, 137);
            this.PbPlayer.Name = "PbPlayer";
            this.PbPlayer.Size = new System.Drawing.Size(175, 165);
            this.PbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbPlayer.TabIndex = 3;
            this.PbPlayer.TabStop = false;
            // 
            // LbVs
            // 
            this.LbVs.AutoSize = true;
            this.LbVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbVs.Location = new System.Drawing.Point(269, 196);
            this.LbVs.Name = "LbVs";
            this.LbVs.Size = new System.Drawing.Size(70, 42);
            this.LbVs.TabIndex = 14;
            this.LbVs.Text = "VS";
            // 
            // ChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 567);
            this.Controls.Add(this.LbVs);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.BtReset);
            this.Controls.Add(this.PbPaper);
            this.Controls.Add(this.PbScissors);
            this.Controls.Add(this.PbRock);
            this.Controls.Add(this.LbChoseItem);
            this.Controls.Add(this.LbResult);
            this.Controls.Add(this.LbPlayerName);
            this.Controls.Add(this.LbBotName);
            this.Controls.Add(this.PbBot);
            this.Controls.Add(this.PbPlayer);
            this.Controls.Add(this.BtStart);
            this.Controls.Add(this.TbPlayerNickname);
            this.Controls.Add(this.LbNickname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Scissors Paper";
            this.Load += new System.EventHandler(this.ChooseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbNickname;
        private System.Windows.Forms.TextBox TbPlayerNickname;
        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.PictureBox PbPlayer;
        private System.Windows.Forms.PictureBox PbBot;
        private System.Windows.Forms.Label LbBotName;
        private System.Windows.Forms.Label LbPlayerName;
        private System.Windows.Forms.Label LbResult;
        private System.Windows.Forms.Label LbChoseItem;
        private System.Windows.Forms.PictureBox PbRock;
        private System.Windows.Forms.PictureBox PbScissors;
        private System.Windows.Forms.PictureBox PbPaper;
        private System.Windows.Forms.Button BtReset;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.Label LbVs;
    }
}

