
namespace ConceptosIniciales.VistaPrincipal
{
    partial class MenuP
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlNumeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoNumerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.controlFactorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoFactorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abandonarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlNumeroToolStripMenuItem,
            this.controlOperacionesToolStripMenuItem,
            this.facturadorToolStripMenuItem,
            this.controlFactorialToolStripMenuItem,
            this.abandonarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controlNumeroToolStripMenuItem
            // 
            this.controlNumeroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesoNumerosToolStripMenuItem});
            this.controlNumeroToolStripMenuItem.Name = "controlNumeroToolStripMenuItem";
            this.controlNumeroToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.controlNumeroToolStripMenuItem.Text = "Control Numeros";
            this.controlNumeroToolStripMenuItem.Click += new System.EventHandler(this.controlNumeroToolStripMenuItem_Click);
            // 
            // procesoNumerosToolStripMenuItem
            // 
            this.procesoNumerosToolStripMenuItem.Name = "procesoNumerosToolStripMenuItem";
            this.procesoNumerosToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.procesoNumerosToolStripMenuItem.Text = "Proceso Numeros";
            this.procesoNumerosToolStripMenuItem.Click += new System.EventHandler(this.procesoNumerosToolStripMenuItem_Click);
            // 
            // controlOperacionesToolStripMenuItem
            // 
            this.controlOperacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesoOperacionesToolStripMenuItem});
            this.controlOperacionesToolStripMenuItem.Name = "controlOperacionesToolStripMenuItem";
            this.controlOperacionesToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.controlOperacionesToolStripMenuItem.Text = "Control Operaciones";
            // 
            // procesoOperacionesToolStripMenuItem
            // 
            this.procesoOperacionesToolStripMenuItem.Name = "procesoOperacionesToolStripMenuItem";
            this.procesoOperacionesToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.procesoOperacionesToolStripMenuItem.Text = "Proceso Operaciones";
            this.procesoOperacionesToolStripMenuItem.Click += new System.EventHandler(this.procesoOperacionesToolStripMenuItem_Click);
            // 
            // facturadorToolStripMenuItem
            // 
            this.facturadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturadorToolStripMenuItem1});
            this.facturadorToolStripMenuItem.Name = "facturadorToolStripMenuItem";
            this.facturadorToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.facturadorToolStripMenuItem.Text = "Control Facturador";
            this.facturadorToolStripMenuItem.Click += new System.EventHandler(this.facturadorToolStripMenuItem_Click);
            // 
            // facturadorToolStripMenuItem1
            // 
            this.facturadorToolStripMenuItem1.Name = "facturadorToolStripMenuItem1";
            this.facturadorToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.facturadorToolStripMenuItem1.Text = "Facturador";
            this.facturadorToolStripMenuItem1.Click += new System.EventHandler(this.facturadorToolStripMenuItem1_Click);
            // 
            // controlFactorialToolStripMenuItem
            // 
            this.controlFactorialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesoFactorialToolStripMenuItem});
            this.controlFactorialToolStripMenuItem.Name = "controlFactorialToolStripMenuItem";
            this.controlFactorialToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.controlFactorialToolStripMenuItem.Text = "Control Factorial";
            // 
            // procesoFactorialToolStripMenuItem
            // 
            this.procesoFactorialToolStripMenuItem.Name = "procesoFactorialToolStripMenuItem";
            this.procesoFactorialToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.procesoFactorialToolStripMenuItem.Text = "Proceso Factorial";
            this.procesoFactorialToolStripMenuItem.Click += new System.EventHandler(this.procesoFactorialToolStripMenuItem_Click);
            // 
            // abandonarToolStripMenuItem
            // 
            this.abandonarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.abandonarToolStripMenuItem.Name = "abandonarToolStripMenuItem";
            this.abandonarToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.abandonarToolStripMenuItem.Text = "Abandonar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 32);
            // 
            // MenuP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuP_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlNumeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoNumerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlOperacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoOperacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturadorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abandonarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlFactorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoFactorialToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}