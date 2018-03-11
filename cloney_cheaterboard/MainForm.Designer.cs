namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_user = new System.Windows.Forms.TextBox();
            this.box_coins = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_system = new System.Windows.Forms.ComboBox();
            this.btn_PostScore = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coins";
            // 
            // box_user
            // 
            this.box_user.Location = new System.Drawing.Point(85, 6);
            this.box_user.Name = "box_user";
            this.box_user.Size = new System.Drawing.Size(230, 20);
            this.box_user.TabIndex = 1;
            // 
            // box_coins
            // 
            this.box_coins.Location = new System.Drawing.Point(85, 35);
            this.box_coins.Name = "box_coins";
            this.box_coins.Size = new System.Drawing.Size(230, 20);
            this.box_coins.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "System";
            // 
            // box_system
            // 
            this.box_system.FormattingEnabled = true;
            this.box_system.Items.AddRange(new object[] {
            "Windows",
            "Linux",
            "Android",
            "iOS"});
            this.box_system.Location = new System.Drawing.Point(85, 62);
            this.box_system.Name = "box_system";
            this.box_system.Size = new System.Drawing.Size(230, 21);
            this.box_system.TabIndex = 3;
            this.box_system.Text = "Windows";
            // 
            // btn_PostScore
            // 
            this.btn_PostScore.Location = new System.Drawing.Point(229, 89);
            this.btn_PostScore.Name = "btn_PostScore";
            this.btn_PostScore.Size = new System.Drawing.Size(86, 30);
            this.btn_PostScore.TabIndex = 4;
            this.btn_PostScore.Text = "Post Score";
            this.btn_PostScore.UseVisualStyleBackColor = true;
            this.btn_PostScore.Click += new System.EventHandler(this.btn_PostScore_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 98);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "(c) 2017 GENiEBEN";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 129);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_PostScore);
            this.Controls.Add(this.box_system);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_coins);
            this.Controls.Add(this.box_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Cloney Cheaterboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_user;
        private System.Windows.Forms.TextBox box_coins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox box_system;
        private System.Windows.Forms.Button btn_PostScore;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

