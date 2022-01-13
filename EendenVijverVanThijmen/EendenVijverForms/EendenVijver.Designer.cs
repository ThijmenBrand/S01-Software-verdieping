namespace EendenVijverForms
{
    partial class EendenVijver
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EendenVijver));
            this.GameTickSpeed = new System.Windows.Forms.Timer(this.components);
            this.OoievaarMaag = new System.Windows.Forms.ProgressBar();
            this.maagInhoud = new System.Windows.Forms.Label();
            this.MessageValue = new System.Windows.Forms.Label();
            this.maagTimer = new System.Windows.Forms.Timer(this.components);
            this.StorkToilet = new System.Windows.Forms.PictureBox();
            this.KikkerMovementTimer = new System.Windows.Forms.Timer(this.components);
            this.OoievaarMovementTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StorkToilet)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTickSpeed
            // 
            this.GameTickSpeed.Enabled = true;
            this.GameTickSpeed.Tick += new System.EventHandler(this.AnimalTickSpeed);
            // 
            // OoievaarMaag
            // 
            this.OoievaarMaag.Location = new System.Drawing.Point(83, 12);
            this.OoievaarMaag.Name = "OoievaarMaag";
            this.OoievaarMaag.Size = new System.Drawing.Size(100, 23);
            this.OoievaarMaag.TabIndex = 0;
            // 
            // maagInhoud
            // 
            this.maagInhoud.AutoSize = true;
            this.maagInhoud.Location = new System.Drawing.Point(2, 12);
            this.maagInhoud.Name = "maagInhoud";
            this.maagInhoud.Size = new System.Drawing.Size(75, 15);
            this.maagInhoud.TabIndex = 1;
            this.maagInhoud.Text = "MaagInhoud";
            // 
            // MessageValue
            // 
            this.MessageValue.AutoSize = true;
            this.MessageValue.Location = new System.Drawing.Point(602, 12);
            this.MessageValue.Name = "MessageValue";
            this.MessageValue.Size = new System.Drawing.Size(0, 15);
            this.MessageValue.TabIndex = 2;
            // 
            // maagTimer
            // 
            this.maagTimer.Enabled = true;
            this.maagTimer.Interval = 1000;
            this.maagTimer.Tick += new System.EventHandler(this.maagtimer);
            // 
            // StorkToilet
            // 
            this.StorkToilet.Image = ((System.Drawing.Image)(resources.GetObject("StorkToilet.Image")));
            this.StorkToilet.Location = new System.Drawing.Point(1209, 12);
            this.StorkToilet.Name = "StorkToilet";
            this.StorkToilet.Size = new System.Drawing.Size(100, 74);
            this.StorkToilet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StorkToilet.TabIndex = 3;
            this.StorkToilet.TabStop = false;
            // 
            // KikkerMovementTimer
            // 
            this.KikkerMovementTimer.Enabled = true;
            this.KikkerMovementTimer.Tick += new System.EventHandler(this.DierMovement);
            // 
            // OoievaarMovementTimer
            // 
            this.OoievaarMovementTimer.Enabled = true;
            this.OoievaarMovementTimer.Tick += new System.EventHandler(this.OoievaarMovement);
            // 
            // EendenVijver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1526, 875);
            this.Controls.Add(this.StorkToilet);
            this.Controls.Add(this.MessageValue);
            this.Controls.Add(this.maagInhoud);
            this.Controls.Add(this.OoievaarMaag);
            this.ForeColor = System.Drawing.Color.Honeydew;
            this.Name = "EendenVijver";
            this.Text = "Vijver";
            this.Load += new System.EventHandler(this.EendenVijver_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.StorkToilet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer GameTickSpeed;
        private ProgressBar OoievaarMaag;
        private Label maagInhoud;
        private Label MessageValue;
        private System.Windows.Forms.Timer maagTimer;
        private PictureBox StorkToilet;
        private System.Windows.Forms.Timer KikkerMovementTimer;
        private System.Windows.Forms.Timer OoievaarMovementTimer;
    }
}