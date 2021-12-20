namespace dinoGame
{
    partial class dinogame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dinogame));
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.green_dino_box = new System.Windows.Forms.GroupBox();
            this.green_dino_picture = new System.Windows.Forms.PictureBox();
            this.red_dino_box = new System.Windows.Forms.GroupBox();
            this.red_dino_picture = new System.Windows.Forms.PictureBox();
            this.activate_green = new System.Windows.Forms.Button();
            this.activate_red = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.munt = new System.Windows.Forms.PictureBox();
            this.green_dino_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.green_dino_picture)).BeginInit();
            this.red_dino_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.red_dino_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.munt)).BeginInit();
            this.SuspendLayout();
            // 
            // movementTimer
            // 
            this.movementTimer.Enabled = true;
            this.movementTimer.Interval = 10;
            this.movementTimer.Tick += new System.EventHandler(this.movement);
            // 
            // green_dino_box
            // 
            this.green_dino_box.Controls.Add(this.munt);
            this.green_dino_box.Controls.Add(this.green_dino_picture);
            this.green_dino_box.Location = new System.Drawing.Point(4, 12);
            this.green_dino_box.Name = "green_dino_box";
            this.green_dino_box.Size = new System.Drawing.Size(387, 394);
            this.green_dino_box.TabIndex = 0;
            this.green_dino_box.TabStop = false;
            // 
            // green_dino_picture
            // 
            this.green_dino_picture.Image = ((System.Drawing.Image)(resources.GetObject("green_dino_picture.Image")));
            this.green_dino_picture.Location = new System.Drawing.Point(106, 296);
            this.green_dino_picture.Name = "green_dino_picture";
            this.green_dino_picture.Size = new System.Drawing.Size(100, 83);
            this.green_dino_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.green_dino_picture.TabIndex = 0;
            this.green_dino_picture.TabStop = false;
            // 
            // red_dino_box
            // 
            this.red_dino_box.Controls.Add(this.red_dino_picture);
            this.red_dino_box.Location = new System.Drawing.Point(390, 12);
            this.red_dino_box.Name = "red_dino_box";
            this.red_dino_box.Size = new System.Drawing.Size(408, 394);
            this.red_dino_box.TabIndex = 1;
            this.red_dino_box.TabStop = false;
            // 
            // red_dino_picture
            // 
            this.red_dino_picture.Image = ((System.Drawing.Image)(resources.GetObject("red_dino_picture.Image")));
            this.red_dino_picture.Location = new System.Drawing.Point(105, 296);
            this.red_dino_picture.Name = "red_dino_picture";
            this.red_dino_picture.Size = new System.Drawing.Size(100, 83);
            this.red_dino_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.red_dino_picture.TabIndex = 1;
            this.red_dino_picture.TabStop = false;
            // 
            // activate_green
            // 
            this.activate_green.Location = new System.Drawing.Point(305, 419);
            this.activate_green.Name = "activate_green";
            this.activate_green.Size = new System.Drawing.Size(75, 23);
            this.activate_green.TabIndex = 2;
            this.activate_green.Text = "activate";
            this.activate_green.UseVisualStyleBackColor = true;
            this.activate_green.Click += new System.EventHandler(this.activate_green_Click);
            // 
            // activate_red
            // 
            this.activate_red.Location = new System.Drawing.Point(408, 419);
            this.activate_red.Name = "activate_red";
            this.activate_red.Size = new System.Drawing.Size(75, 23);
            this.activate_red.TabIndex = 3;
            this.activate_red.Text = "activate";
            this.activate_red.UseVisualStyleBackColor = true;
            this.activate_red.Click += new System.EventHandler(this.activate_red_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(365, 462);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(48, 15);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score: 0";
            // 
            // munt
            // 
            this.munt.Image = ((System.Drawing.Image)(resources.GetObject("munt.Image")));
            this.munt.Location = new System.Drawing.Point(236, 100);
            this.munt.Name = "munt";
            this.munt.Size = new System.Drawing.Size(26, 23);
            this.munt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.munt.TabIndex = 1;
            this.munt.TabStop = false;
            this.munt.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dinogame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.activate_red);
            this.Controls.Add(this.activate_green);
            this.Controls.Add(this.red_dino_box);
            this.Controls.Add(this.green_dino_box);
            this.Name = "dinogame";
            this.Text = "dinogame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            this.green_dino_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.green_dino_picture)).EndInit();
            this.red_dino_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.red_dino_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.munt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer movementTimer;
        private GroupBox green_dino_box;
        private PictureBox green_dino_picture;
        private GroupBox red_dino_box;
        private PictureBox red_dino_picture;
        private Button activate_green;
        private Button activate_red;
        private Label Score;
        private PictureBox munt;
    }
}