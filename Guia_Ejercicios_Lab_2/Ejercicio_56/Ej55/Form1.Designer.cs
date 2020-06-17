namespace Ej55
{
    partial class Ej56
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarArchivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoArchivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.caracteresStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.editorTxt = new System.Windows.Forms.RichTextBox();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoMenu});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(671, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoMenu
            // 
            this.archivoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoMenu,
            this.guardarArchivoMenu,
            this.guardarComoArchivoMenu});
            this.archivoMenu.Name = "archivoMenu";
            this.archivoMenu.Size = new System.Drawing.Size(60, 20);
            this.archivoMenu.Text = "Archivo";
            // 
            // abrirArchivoMenu
            // 
            this.abrirArchivoMenu.Name = "abrirArchivoMenu";
            this.abrirArchivoMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirArchivoMenu.Size = new System.Drawing.Size(231, 22);
            this.abrirArchivoMenu.Text = "Abrir";
            this.abrirArchivoMenu.Click += new System.EventHandler(this.abrirArchivoMenu_Click);
            // 
            // guardarArchivoMenu
            // 
            this.guardarArchivoMenu.Name = "guardarArchivoMenu";
            this.guardarArchivoMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarArchivoMenu.Size = new System.Drawing.Size(231, 22);
            this.guardarArchivoMenu.Text = "Guardar";
            this.guardarArchivoMenu.Click += new System.EventHandler(this.guardarArchivoMenu_Click);
            // 
            // guardarComoArchivoMenu
            // 
            this.guardarComoArchivoMenu.Name = "guardarComoArchivoMenu";
            this.guardarComoArchivoMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.guardarComoArchivoMenu.Size = new System.Drawing.Size(231, 22);
            this.guardarComoArchivoMenu.Text = "Guardar como...";
            this.guardarComoArchivoMenu.Click += new System.EventHandler(this.guardarComoArchivoMenu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caracteresStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(671, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // caracteresStatus
            // 
            this.caracteresStatus.Name = "caracteresStatus";
            this.caracteresStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // editorTxt
            // 
            this.editorTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorTxt.Location = new System.Drawing.Point(0, 24);
            this.editorTxt.Name = "editorTxt";
            this.editorTxt.Size = new System.Drawing.Size(671, 403);
            this.editorTxt.TabIndex = 5;
            this.editorTxt.Text = "";
            this.editorTxt.TextChanged += new System.EventHandler(this.editorTxt_TextChanged);
            // 
            // Ej56
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 449);
            this.Controls.Add(this.editorTxt);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Ej56";
            this.Text = "Ej56";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivoMenu;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoMenu;
        private System.Windows.Forms.ToolStripMenuItem guardarArchivoMenu;
        private System.Windows.Forms.ToolStripMenuItem guardarComoArchivoMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel caracteresStatus;
        private System.Windows.Forms.RichTextBox editorTxt;
    }
}

