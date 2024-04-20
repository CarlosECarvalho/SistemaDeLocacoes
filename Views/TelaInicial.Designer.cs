namespace SistemaDeLocacoes
{
    partial class TelaInicial
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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            empresasToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            locaçõesToolStripMenuItem = new ToolStripMenuItem();
            inserirLocaçõesToolStripMenuItem = new ToolStripMenuItem();
            cobrarLocaçõesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, locaçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1350, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { empresasToolStripMenuItem, produtosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // empresasToolStripMenuItem
            // 
            empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            empresasToolStripMenuItem.Size = new Size(124, 22);
            empresasToolStripMenuItem.Text = "Empresas";
            empresasToolStripMenuItem.Click += btnEmpresas_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(124, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += btnProdutos_Click;
            // 
            // locaçõesToolStripMenuItem
            // 
            locaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inserirLocaçõesToolStripMenuItem, cobrarLocaçõesToolStripMenuItem });
            locaçõesToolStripMenuItem.Name = "locaçõesToolStripMenuItem";
            locaçõesToolStripMenuItem.Size = new Size(68, 20);
            locaçõesToolStripMenuItem.Text = "Locações";
            // 
            // inserirLocaçõesToolStripMenuItem
            // 
            inserirLocaçõesToolStripMenuItem.Name = "inserirLocaçõesToolStripMenuItem";
            inserirLocaçõesToolStripMenuItem.Size = new Size(180, 22);
            inserirLocaçõesToolStripMenuItem.Text = "Inserir Locações";
            inserirLocaçõesToolStripMenuItem.Click += btnLocacoes_Click;
            // 
            // cobrarLocaçõesToolStripMenuItem
            // 
            cobrarLocaçõesToolStripMenuItem.Name = "cobrarLocaçõesToolStripMenuItem";
            cobrarLocaçõesToolStripMenuItem.Size = new Size(180, 22);
            cobrarLocaçõesToolStripMenuItem.Text = "Cobrar Locações";
            cobrarLocaçõesToolStripMenuItem.Click += btnCobrar_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaInicial";
            Text = "Início";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem empresasToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem locaçõesToolStripMenuItem;
        private ToolStripMenuItem inserirLocaçõesToolStripMenuItem;
        private ToolStripMenuItem cobrarLocaçõesToolStripMenuItem;
    }
}
