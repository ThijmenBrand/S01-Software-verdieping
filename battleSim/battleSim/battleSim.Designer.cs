namespace battleSim
{
    partial class battleSim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(battleSim));
            this.knight = new System.Windows.Forms.PictureBox();
            this.monster = new System.Windows.Forms.PictureBox();
            this.knightAttack = new System.Windows.Forms.Button();
            this.monsterAttack = new System.Windows.Forms.Button();
            this.knightHp = new System.Windows.Forms.Label();
            this.monsterHp = new System.Windows.Forms.Label();
            this.hitlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.knight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).BeginInit();
            this.SuspendLayout();
            // 
            // knight
            // 
            this.knight.Image = ((System.Drawing.Image)(resources.GetObject("knight.Image")));
            this.knight.Location = new System.Drawing.Point(26, 23);
            this.knight.Name = "knight";
            this.knight.Size = new System.Drawing.Size(147, 261);
            this.knight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.knight.TabIndex = 0;
            this.knight.TabStop = false;
            // 
            // monster
            // 
            this.monster.Image = ((System.Drawing.Image)(resources.GetObject("monster.Image")));
            this.monster.Location = new System.Drawing.Point(337, 23);
            this.monster.Name = "monster";
            this.monster.Size = new System.Drawing.Size(229, 261);
            this.monster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monster.TabIndex = 1;
            this.monster.TabStop = false;
            // 
            // knightAttack
            // 
            this.knightAttack.Location = new System.Drawing.Point(61, 290);
            this.knightAttack.Name = "knightAttack";
            this.knightAttack.Size = new System.Drawing.Size(75, 23);
            this.knightAttack.TabIndex = 2;
            this.knightAttack.Text = "Attack";
            this.knightAttack.UseVisualStyleBackColor = true;
            this.knightAttack.Click += new System.EventHandler(this.knightAttack_Click);
            // 
            // monsterAttack
            // 
            this.monsterAttack.Location = new System.Drawing.Point(419, 290);
            this.monsterAttack.Name = "monsterAttack";
            this.monsterAttack.Size = new System.Drawing.Size(75, 23);
            this.monsterAttack.TabIndex = 3;
            this.monsterAttack.Text = "Attack";
            this.monsterAttack.UseVisualStyleBackColor = true;
            this.monsterAttack.Click += new System.EventHandler(this.monsterAttack_Click);
            // 
            // knightHp
            // 
            this.knightHp.AutoSize = true;
            this.knightHp.Location = new System.Drawing.Point(61, 329);
            this.knightHp.Name = "knightHp";
            this.knightHp.Size = new System.Drawing.Size(45, 15);
            this.knightHp.TabIndex = 4;
            this.knightHp.Text = "hp: 100";
            // 
            // monsterHp
            // 
            this.monsterHp.AutoSize = true;
            this.monsterHp.Location = new System.Drawing.Point(419, 329);
            this.monsterHp.Name = "monsterHp";
            this.monsterHp.Size = new System.Drawing.Size(45, 15);
            this.monsterHp.TabIndex = 5;
            this.monsterHp.Text = "hp: 100";
            // 
            // hitlabel
            // 
            this.hitlabel.AutoSize = true;
            this.hitlabel.Location = new System.Drawing.Point(233, 37);
            this.hitlabel.Name = "hitlabel";
            this.hitlabel.Size = new System.Drawing.Size(0, 15);
            this.hitlabel.TabIndex = 6;
            // 
            // battleSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.hitlabel);
            this.Controls.Add(this.monsterHp);
            this.Controls.Add(this.knightHp);
            this.Controls.Add(this.monsterAttack);
            this.Controls.Add(this.knightAttack);
            this.Controls.Add(this.monster);
            this.Controls.Add(this.knight);
            this.Name = "battleSim";
            this.Text = "battleSim";
            this.Load += new System.EventHandler(this.battleSim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox knight;
        private PictureBox monster;
        private Button knightAttack;
        private Button monsterAttack;
        private Label knightHp;
        private Label monsterHp;
        private Label hitlabel;
    }
}