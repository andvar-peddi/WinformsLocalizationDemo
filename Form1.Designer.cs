namespace WinformsLocalizationNetFramework4._6._2Demo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romanianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.romanianToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.italianToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cultureManager1 = new Infralution.Localization.CultureManager(this.components);
            this.buttonHello = new System.Windows.Forms.Button();
            this.buttonWorld = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.languageToolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frenchToolStripMenuItem,
            this.italianToolStripMenuItem,
            this.englishToolStripMenuItem,
            this.romanianToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            resources.ApplyResources(this.frenchToolStripMenuItem, "frenchToolStripMenuItem");
            // 
            // italianToolStripMenuItem
            // 
            this.italianToolStripMenuItem.Name = "italianToolStripMenuItem";
            resources.ApplyResources(this.italianToolStripMenuItem, "italianToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            // 
            // romanianToolStripMenuItem
            // 
            this.romanianToolStripMenuItem.Name = "romanianToolStripMenuItem";
            resources.ApplyResources(this.romanianToolStripMenuItem, "romanianToolStripMenuItem");
            // 
            // languageToolStripMenuItem1
            // 
            this.languageToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.romanianToolStripMenuItem1,
            this.italianToolStripMenuItem1,
            this.frenchToolStripMenuItem1});
            this.languageToolStripMenuItem1.Name = "languageToolStripMenuItem1";
            resources.ApplyResources(this.languageToolStripMenuItem1, "languageToolStripMenuItem1");
            // 
            // romanianToolStripMenuItem1
            // 
            this.romanianToolStripMenuItem1.Name = "romanianToolStripMenuItem1";
            resources.ApplyResources(this.romanianToolStripMenuItem1, "romanianToolStripMenuItem1");
            this.romanianToolStripMenuItem1.Click += new System.EventHandler(this.romanianToolStripMenuItem1_Click);
            // 
            // italianToolStripMenuItem1
            // 
            this.italianToolStripMenuItem1.Name = "italianToolStripMenuItem1";
            resources.ApplyResources(this.italianToolStripMenuItem1, "italianToolStripMenuItem1");
            this.italianToolStripMenuItem1.Click += new System.EventHandler(this.italianToolStripMenuItem1_Click);
            // 
            // frenchToolStripMenuItem1
            // 
            this.frenchToolStripMenuItem1.Name = "frenchToolStripMenuItem1";
            resources.ApplyResources(this.frenchToolStripMenuItem1, "frenchToolStripMenuItem1");
            this.frenchToolStripMenuItem1.Click += new System.EventHandler(this.frenchToolStripMenuItem1_Click);
            // 
            // cultureManager1
            // 
            this.cultureManager1.ManagedControl = this;
            // 
            // buttonHello
            // 
            resources.ApplyResources(this.buttonHello, "buttonHello");
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.UseVisualStyleBackColor = true;
            // 
            // buttonWorld
            // 
            resources.ApplyResources(this.buttonWorld, "buttonWorld");
            this.buttonWorld.Name = "buttonWorld";
            this.buttonWorld.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelTest
            // 
            resources.ApplyResources(this.labelTest, "labelTest");
            this.labelTest.Name = "labelTest";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonWorld);
            this.Controls.Add(this.buttonHello);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romanianToolStripMenuItem;
        private Infralution.Localization.CultureManager cultureManager1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem romanianToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem italianToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem1;
        private System.Windows.Forms.Button buttonHello;
        private System.Windows.Forms.Button buttonWorld;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTest;
    }
}

