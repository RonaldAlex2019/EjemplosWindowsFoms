namespace EjemplosWindowsFoms
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contenedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delegadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculosInteresCompuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contenedoresToolStripMenuItem,
            this.delegadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // contenedoresToolStripMenuItem
            // 
            this.contenedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabControlToolStripMenuItem});
            this.contenedoresToolStripMenuItem.Name = "contenedoresToolStripMenuItem";
            this.contenedoresToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.contenedoresToolStripMenuItem.Text = "Contenedores";
            this.contenedoresToolStripMenuItem.Click += new System.EventHandler(this.contenedoresToolStripMenuItem_Click);
            // 
            // tabControlToolStripMenuItem
            // 
            this.tabControlToolStripMenuItem.Name = "tabControlToolStripMenuItem";
            this.tabControlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabControlToolStripMenuItem.Text = "TabControl";
            this.tabControlToolStripMenuItem.Click += new System.EventHandler(this.tabControlToolStripMenuItem_Click);
            // 
            // delegadosToolStripMenuItem
            // 
            this.delegadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculosInteresCompuestoToolStripMenuItem});
            this.delegadosToolStripMenuItem.Name = "delegadosToolStripMenuItem";
            this.delegadosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.delegadosToolStripMenuItem.Text = "Delegados";
            // 
            // calculosInteresCompuestoToolStripMenuItem
            // 
            this.calculosInteresCompuestoToolStripMenuItem.Name = "calculosInteresCompuestoToolStripMenuItem";
            this.calculosInteresCompuestoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.calculosInteresCompuestoToolStripMenuItem.Text = "Calculos Interes Compuesto";
            this.calculosInteresCompuestoToolStripMenuItem.Click += new System.EventHandler(this.calculosInteresCompuestoToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Uso de Formularios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem contenedoresToolStripMenuItem;
        private ToolStripMenuItem tabControlToolStripMenuItem;
        private ToolStripMenuItem delegadosToolStripMenuItem;
        private ToolStripMenuItem calculosInteresCompuestoToolStripMenuItem;
    }
}