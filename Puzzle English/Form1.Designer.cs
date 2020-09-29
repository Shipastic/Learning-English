namespace Puzzle_English
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1_english = new System.Windows.Forms.Label();
            this.label2_russia = new System.Windows.Forms.Label();
            this.picture_card = new System.Windows.Forms.PictureBox();
            this.button_previor = new System.Windows.Forms.Button();
            this.buttonnext = new System.Windows.Forms.Button();
            this.label1_video = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.picture_card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_english
            // 
            this.label1_english.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1_english.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1_english.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_english.ForeColor = System.Drawing.Color.Red;
            this.label1_english.Location = new System.Drawing.Point(120, 62);
            this.label1_english.Name = "label1_english";
            this.label1_english.Size = new System.Drawing.Size(358, 30);
            this.label1_english.TabIndex = 0;
            this.label1_english.Click += new System.EventHandler(this.label1_english_Click);
            // 
            // label2_russia
            // 
            this.label2_russia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2_russia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2_russia.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_russia.ForeColor = System.Drawing.Color.Blue;
            this.label2_russia.Location = new System.Drawing.Point(120, 479);
            this.label2_russia.Name = "label2_russia";
            this.label2_russia.Size = new System.Drawing.Size(358, 30);
            this.label2_russia.TabIndex = 1;
            this.label2_russia.Click += new System.EventHandler(this.label2_russia_Click);
            // 
            // picture_card
            // 
            this.picture_card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_card.Location = new System.Drawing.Point(120, 104);
            this.picture_card.Name = "picture_card";
            this.picture_card.Size = new System.Drawing.Size(358, 358);
            this.picture_card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_card.TabIndex = 2;
            this.picture_card.TabStop = false;
            // 
            // button_previor
            // 
            this.button_previor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_previor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_previor.Location = new System.Drawing.Point(39, 236);
            this.button_previor.Name = "button_previor";
            this.button_previor.Size = new System.Drawing.Size(75, 75);
            this.button_previor.TabIndex = 3;
            this.button_previor.Text = "<<<";
            this.button_previor.UseVisualStyleBackColor = true;
            this.button_previor.Click += new System.EventHandler(this.button_previor_Click);
            // 
            // buttonnext
            // 
            this.buttonnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonnext.Location = new System.Drawing.Point(487, 236);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(75, 75);
            this.buttonnext.TabIndex = 4;
            this.buttonnext.Text = ">>>";
            this.buttonnext.UseVisualStyleBackColor = true;
            this.buttonnext.Click += new System.EventHandler(this.buttonnext_Click);
            // 
            // label1_video
            // 
            this.label1_video.AutoSize = true;
            this.label1_video.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1_video.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_video.Location = new System.Drawing.Point(484, 113);
            this.label1_video.Name = "label1_video";
            this.label1_video.Size = new System.Drawing.Size(71, 18);
            this.label1_video.TabIndex = 5;
            this.label1_video.Text = "+ video";
            this.label1_video.Visible = false;
            this.label1_video.Click += new System.EventHandler(this.label1_video_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(120, 104);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(361, 358);
            this.player.TabIndex = 6;
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            this.player.Enter += new System.EventHandler(this.player_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 537);
            this.Controls.Add(this.label1_video);
            this.Controls.Add(this.buttonnext);
            this.Controls.Add(this.button_previor);
            this.Controls.Add(this.label2_russia);
            this.Controls.Add(this.label1_english);
            this.Controls.Add(this.player);
            this.Controls.Add(this.picture_card);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle English";
            ((System.ComponentModel.ISupportInitialize)(this.picture_card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_english;
        private System.Windows.Forms.Label label2_russia;
        private System.Windows.Forms.PictureBox picture_card;
        private System.Windows.Forms.Button button_previor;
        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.Label label1_video;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}

