namespace bankzaken
{
    partial class bankzakenForm
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
            this.balanceBox1 = new System.Windows.Forms.RichTextBox();
            this.balance = new System.Windows.Forms.Label();
            this.Stort1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.perfAction1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bedrag1 = new System.Windows.Forms.TextBox();
            this.schrijfOver1 = new System.Windows.Forms.RadioButton();
            this.neemop1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.perfAction2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bedrag2 = new System.Windows.Forms.TextBox();
            this.schrijfOver2 = new System.Windows.Forms.RadioButton();
            this.neemop2 = new System.Windows.Forms.RadioButton();
            this.balanceBox2 = new System.Windows.Forms.RichTextBox();
            this.stort2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // balanceBox1
            // 
            this.balanceBox1.Location = new System.Drawing.Point(16, 67);
            this.balanceBox1.Name = "balanceBox1";
            this.balanceBox1.Size = new System.Drawing.Size(267, 56);
            this.balanceBox1.TabIndex = 0;
            this.balanceBox1.Text = "";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(16, 27);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(87, 25);
            this.balance.TabIndex = 1;
            this.balance.Text = "balance 1";
            // 
            // Stort1
            // 
            this.Stort1.AutoSize = true;
            this.Stort1.Checked = true;
            this.Stort1.Location = new System.Drawing.Point(16, 164);
            this.Stort1.Name = "Stort1";
            this.Stort1.Size = new System.Drawing.Size(74, 29);
            this.Stort1.TabIndex = 2;
            this.Stort1.TabStop = true;
            this.Stort1.Text = "stort";
            this.Stort1.UseVisualStyleBackColor = true;
            this.Stort1.CheckedChanged += new System.EventHandler(this.Stort1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.perfAction1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bedrag1);
            this.groupBox1.Controls.Add(this.schrijfOver1);
            this.groupBox1.Controls.Add(this.neemop1);
            this.groupBox1.Controls.Add(this.balanceBox1);
            this.groupBox1.Controls.Add(this.Stort1);
            this.groupBox1.Controls.Add(this.balance);
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // perfAction1
            // 
            this.perfAction1.Location = new System.Drawing.Point(182, 337);
            this.perfAction1.Name = "perfAction1";
            this.perfAction1.Size = new System.Drawing.Size(90, 33);
            this.perfAction1.TabIndex = 7;
            this.perfAction1.Text = "Stort";
            this.perfAction1.UseVisualStyleBackColor = true;
            this.perfAction1.Click += new System.EventHandler(this.perfAction1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "bedrag";
            // 
            // bedrag1
            // 
            this.bedrag1.Location = new System.Drawing.Point(16, 337);
            this.bedrag1.Name = "bedrag1";
            this.bedrag1.Size = new System.Drawing.Size(150, 31);
            this.bedrag1.TabIndex = 5;
            // 
            // schrijfOver1
            // 
            this.schrijfOver1.AutoSize = true;
            this.schrijfOver1.Location = new System.Drawing.Point(16, 264);
            this.schrijfOver1.Name = "schrijfOver1";
            this.schrijfOver1.Size = new System.Drawing.Size(152, 29);
            this.schrijfOver1.TabIndex = 4;
            this.schrijfOver1.Text = "schrijf over >>";
            this.schrijfOver1.UseVisualStyleBackColor = true;
            this.schrijfOver1.CheckedChanged += new System.EventHandler(this.schrijfOver1_CheckedChanged);
            // 
            // neemop1
            // 
            this.neemop1.AutoSize = true;
            this.neemop1.Location = new System.Drawing.Point(16, 214);
            this.neemop1.Name = "neemop1";
            this.neemop1.Size = new System.Drawing.Size(108, 29);
            this.neemop1.TabIndex = 3;
            this.neemop1.Text = "neem op";
            this.neemop1.UseVisualStyleBackColor = true;
            this.neemop1.CheckedChanged += new System.EventHandler(this.neemop1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.perfAction2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bedrag2);
            this.groupBox2.Controls.Add(this.schrijfOver2);
            this.groupBox2.Controls.Add(this.neemop2);
            this.groupBox2.Controls.Add(this.balanceBox2);
            this.groupBox2.Controls.Add(this.stort2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(468, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 426);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // perfAction2
            // 
            this.perfAction2.Location = new System.Drawing.Point(182, 337);
            this.perfAction2.Name = "perfAction2";
            this.perfAction2.Size = new System.Drawing.Size(90, 33);
            this.perfAction2.TabIndex = 7;
            this.perfAction2.Text = "Stort";
            this.perfAction2.UseVisualStyleBackColor = true;
            this.perfAction2.Click += new System.EventHandler(this.perfAction2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "bedrag";
            // 
            // bedrag2
            // 
            this.bedrag2.Location = new System.Drawing.Point(16, 337);
            this.bedrag2.Name = "bedrag2";
            this.bedrag2.Size = new System.Drawing.Size(150, 31);
            this.bedrag2.TabIndex = 5;
            // 
            // schrijfOver2
            // 
            this.schrijfOver2.AutoSize = true;
            this.schrijfOver2.Location = new System.Drawing.Point(16, 264);
            this.schrijfOver2.Name = "schrijfOver2";
            this.schrijfOver2.Size = new System.Drawing.Size(152, 29);
            this.schrijfOver2.TabIndex = 4;
            this.schrijfOver2.Text = "schrijf over >>";
            this.schrijfOver2.UseVisualStyleBackColor = true;
            this.schrijfOver2.CheckedChanged += new System.EventHandler(this.schrijfOver2_CheckedChanged);
            // 
            // neemop2
            // 
            this.neemop2.AutoSize = true;
            this.neemop2.Location = new System.Drawing.Point(16, 214);
            this.neemop2.Name = "neemop2";
            this.neemop2.Size = new System.Drawing.Size(108, 29);
            this.neemop2.TabIndex = 3;
            this.neemop2.Text = "neem op";
            this.neemop2.UseVisualStyleBackColor = true;
            this.neemop2.CheckedChanged += new System.EventHandler(this.neemop2_CheckedChanged);
            // 
            // balanceBox2
            // 
            this.balanceBox2.Location = new System.Drawing.Point(16, 67);
            this.balanceBox2.Name = "balanceBox2";
            this.balanceBox2.Size = new System.Drawing.Size(267, 56);
            this.balanceBox2.TabIndex = 0;
            this.balanceBox2.Text = "";
            // 
            // stort2
            // 
            this.stort2.AutoSize = true;
            this.stort2.Checked = true;
            this.stort2.Location = new System.Drawing.Point(16, 164);
            this.stort2.Name = "stort2";
            this.stort2.Size = new System.Drawing.Size(74, 29);
            this.stort2.TabIndex = 2;
            this.stort2.TabStop = true;
            this.stort2.Text = "stort";
            this.stort2.UseVisualStyleBackColor = true;
            this.stort2.CheckedChanged += new System.EventHandler(this.stort2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "balance 2";
            // 
            // bankzakenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "bankzakenForm";
            this.Text = "bankzakenForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox balanceBox1;
        private Label balance;
        private RadioButton Stort1;
        private GroupBox groupBox1;
        private Button perfAction1;
        private Label label1;
        private TextBox bedrag1;
        private RadioButton schrijfOver1;
        private RadioButton neemop1;
        private GroupBox groupBox2;
        private Button perfAction2;
        private Label label2;
        private TextBox bedrag2;
        private RadioButton schrijfOver2;
        private RadioButton neemop2;
        private RichTextBox balanceBox2;
        private RadioButton stort2;
        private Label label3;
    }
}