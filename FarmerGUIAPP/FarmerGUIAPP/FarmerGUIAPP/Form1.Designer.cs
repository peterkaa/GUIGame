namespace FarmerGUIAPP
{
    partial class FarmerGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarmerGUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.introductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.directionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBxFoxSouth = new System.Windows.Forms.PictureBox();
            this.picBxFoxNorth = new System.Windows.Forms.PictureBox();
            this.picBxChickenSouth = new System.Windows.Forms.PictureBox();
            this.picBxChickenNorth = new System.Windows.Forms.PictureBox();
            this.picBxFarmerNorth = new System.Windows.Forms.PictureBox();
            this.picBxFarmerSouth = new System.Windows.Forms.PictureBox();
            this.picBxGrainNorth = new System.Windows.Forms.PictureBox();
            this.picBxGrainSouth = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFoxSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFoxNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxChickenSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxChickenNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFarmerNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFarmerSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxGrainNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxGrainSouth)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.resetToolStripMenuItem.Text = "Restart";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.introductionToolStripMenuItem,
            this.toolStripSeparator1,
            this.directionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // introductionToolStripMenuItem
            // 
            this.introductionToolStripMenuItem.Name = "introductionToolStripMenuItem";
            this.introductionToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.introductionToolStripMenuItem.Text = "Introduction";
            this.introductionToolStripMenuItem.Click += new System.EventHandler(this.introductionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // directionsToolStripMenuItem
            // 
            this.directionsToolStripMenuItem.Name = "directionsToolStripMenuItem";
            this.directionsToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.directionsToolStripMenuItem.Text = "Directions";
            this.directionsToolStripMenuItem.Click += new System.EventHandler(this.directionsToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.infoToolStripMenuItem.Text = "&Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // picBxFoxSouth
            // 
            this.picBxFoxSouth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBxFoxSouth.BackgroundImage")));
            this.picBxFoxSouth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxFoxSouth.Location = new System.Drawing.Point(608, 291);
            this.picBxFoxSouth.Name = "picBxFoxSouth";
            this.picBxFoxSouth.Size = new System.Drawing.Size(88, 111);
            this.picBxFoxSouth.TabIndex = 1;
            this.picBxFoxSouth.TabStop = false;
            this.picBxFoxSouth.Visible = false;
            this.picBxFoxSouth.Click += new System.EventHandler(this.picBxFoxSouth_Click);
            // 
            // picBxFoxNorth
            // 
            this.picBxFoxNorth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBxFoxNorth.BackgroundImage")));
            this.picBxFoxNorth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxFoxNorth.Location = new System.Drawing.Point(35, 291);
            this.picBxFoxNorth.Name = "picBxFoxNorth";
            this.picBxFoxNorth.Size = new System.Drawing.Size(88, 111);
            this.picBxFoxNorth.TabIndex = 2;
            this.picBxFoxNorth.TabStop = false;
            this.picBxFoxNorth.Click += new System.EventHandler(this.picBxFoxNorth_Click);
            // 
            // picBxChickenSouth
            // 
            this.picBxChickenSouth.BackgroundImage = global::FarmerGUIAPP.Properties.Resources.chicken;
            this.picBxChickenSouth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxChickenSouth.Location = new System.Drawing.Point(757, 229);
            this.picBxChickenSouth.Name = "picBxChickenSouth";
            this.picBxChickenSouth.Size = new System.Drawing.Size(100, 100);
            this.picBxChickenSouth.TabIndex = 3;
            this.picBxChickenSouth.TabStop = false;
            this.picBxChickenSouth.Visible = false;
            this.picBxChickenSouth.Click += new System.EventHandler(this.picBxChickenSouth_Click);
            // 
            // picBxChickenNorth
            // 
            this.picBxChickenNorth.BackgroundImage = global::FarmerGUIAPP.Properties.Resources.chicken;
            this.picBxChickenNorth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxChickenNorth.Location = new System.Drawing.Point(165, 242);
            this.picBxChickenNorth.Name = "picBxChickenNorth";
            this.picBxChickenNorth.Size = new System.Drawing.Size(100, 100);
            this.picBxChickenNorth.TabIndex = 4;
            this.picBxChickenNorth.TabStop = false;
            this.picBxChickenNorth.Click += new System.EventHandler(this.picBxChickenNorth_Click);
            // 
            // picBxFarmerNorth
            // 
            this.picBxFarmerNorth.BackgroundImage = global::FarmerGUIAPP.Properties.Resources.farmer;
            this.picBxFarmerNorth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxFarmerNorth.Location = new System.Drawing.Point(35, 89);
            this.picBxFarmerNorth.Name = "picBxFarmerNorth";
            this.picBxFarmerNorth.Size = new System.Drawing.Size(100, 144);
            this.picBxFarmerNorth.TabIndex = 5;
            this.picBxFarmerNorth.TabStop = false;
            this.picBxFarmerNorth.Click += new System.EventHandler(this.picBxFarmerNorth_Click);
            // 
            // picBxFarmerSouth
            // 
            this.picBxFarmerSouth.BackgroundImage = global::FarmerGUIAPP.Properties.Resources.farmer;
            this.picBxFarmerSouth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxFarmerSouth.Location = new System.Drawing.Point(564, 106);
            this.picBxFarmerSouth.Name = "picBxFarmerSouth";
            this.picBxFarmerSouth.Size = new System.Drawing.Size(100, 144);
            this.picBxFarmerSouth.TabIndex = 6;
            this.picBxFarmerSouth.TabStop = false;
            this.picBxFarmerSouth.Visible = false;
            this.picBxFarmerSouth.Click += new System.EventHandler(this.picBxFarmerSouth_Click);
            // 
            // picBxGrainNorth
            // 
            this.picBxGrainNorth.BackgroundImage = global::FarmerGUIAPP.Properties.Resources.grain;
            this.picBxGrainNorth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxGrainNorth.Location = new System.Drawing.Point(211, 106);
            this.picBxGrainNorth.Name = "picBxGrainNorth";
            this.picBxGrainNorth.Size = new System.Drawing.Size(100, 95);
            this.picBxGrainNorth.TabIndex = 7;
            this.picBxGrainNorth.TabStop = false;
            this.picBxGrainNorth.Click += new System.EventHandler(this.picBxGrainNorth_Click);
            // 
            // picBxGrainSouth
            // 
            this.picBxGrainSouth.BackgroundImage = global::FarmerGUIAPP.Properties.Resources.grain;
            this.picBxGrainSouth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxGrainSouth.Location = new System.Drawing.Point(757, 89);
            this.picBxGrainSouth.Name = "picBxGrainSouth";
            this.picBxGrainSouth.Size = new System.Drawing.Size(100, 95);
            this.picBxGrainSouth.TabIndex = 8;
            this.picBxGrainSouth.TabStop = false;
            this.picBxGrainSouth.Visible = false;
            this.picBxGrainSouth.Click += new System.EventHandler(this.picBxGrainSouth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(169, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "North Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(587, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "South Bank";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // FarmerGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 520);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBxGrainSouth);
            this.Controls.Add(this.picBxGrainNorth);
            this.Controls.Add(this.picBxFarmerSouth);
            this.Controls.Add(this.picBxFarmerNorth);
            this.Controls.Add(this.picBxChickenNorth);
            this.Controls.Add(this.picBxChickenSouth);
            this.Controls.Add(this.picBxFoxNorth);
            this.Controls.Add(this.picBxFoxSouth);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "FarmerGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FarmerGUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFoxSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFoxNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxChickenSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxChickenNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFarmerNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFarmerSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxGrainNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxGrainSouth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBxFoxSouth;
        private System.Windows.Forms.PictureBox picBxFoxNorth;
        private System.Windows.Forms.PictureBox picBxChickenSouth;
        private System.Windows.Forms.PictureBox picBxChickenNorth;
        private System.Windows.Forms.PictureBox picBxFarmerNorth;
        private System.Windows.Forms.PictureBox picBxFarmerSouth;
        private System.Windows.Forms.PictureBox picBxGrainNorth;
        private System.Windows.Forms.PictureBox picBxGrainSouth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem introductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

