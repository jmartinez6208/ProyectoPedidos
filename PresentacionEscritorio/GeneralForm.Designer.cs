
namespace PresentacionEscritorio
{
    partial class GeneralForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSubMenuReportes = new System.Windows.Forms.Panel();
            this.btnReporte3 = new System.Windows.Forms.Button();
            this.btnReporte2 = new System.Windows.Forms.Button();
            this.btnReporte1 = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnRepartidores = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Pedidos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedorHijo = new System.Windows.Forms.Panel();
            this.panelBarraSuperior = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenuReportes.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(510, 10);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(534, 10);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelSideMenu.Controls.Add(this.panelSubMenuReportes);
            this.panelSideMenu.Controls.Add(this.btnReportes);
            this.panelSideMenu.Controls.Add(this.btnRepartidores);
            this.panelSideMenu.Controls.Add(this.btnPedidos);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(183, 650);
            this.panelSideMenu.TabIndex = 9;
            this.panelSideMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSideMenu_MouseDown);
            // 
            // panelSubMenuReportes
            // 
            this.panelSubMenuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSubMenuReportes.Controls.Add(this.btnReporte3);
            this.panelSubMenuReportes.Controls.Add(this.btnReporte2);
            this.panelSubMenuReportes.Controls.Add(this.btnReporte1);
            this.panelSubMenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuReportes.Location = new System.Drawing.Point(0, 187);
            this.panelSubMenuReportes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSubMenuReportes.Name = "panelSubMenuReportes";
            this.panelSubMenuReportes.Size = new System.Drawing.Size(183, 137);
            this.panelSubMenuReportes.TabIndex = 3;
            // 
            // btnReporte3
            // 
            this.btnReporte3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporte3.FlatAppearance.BorderSize = 0;
            this.btnReporte3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte3.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte3.ForeColor = System.Drawing.Color.Snow;
            this.btnReporte3.Location = new System.Drawing.Point(0, 102);
            this.btnReporte3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReporte3.Name = "btnReporte3";
            this.btnReporte3.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnReporte3.Size = new System.Drawing.Size(183, 36);
            this.btnReporte3.TabIndex = 2;
            this.btnReporte3.Text = "Ventas por Tienda";
            this.btnReporte3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReporte3.UseVisualStyleBackColor = true;
            this.btnReporte3.Click += new System.EventHandler(this.btnReporte3_Click);
            // 
            // btnReporte2
            // 
            this.btnReporte2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporte2.FlatAppearance.BorderSize = 0;
            this.btnReporte2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte2.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte2.ForeColor = System.Drawing.Color.Snow;
            this.btnReporte2.Location = new System.Drawing.Point(0, 53);
            this.btnReporte2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReporte2.Name = "btnReporte2";
            this.btnReporte2.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnReporte2.Size = new System.Drawing.Size(183, 49);
            this.btnReporte2.TabIndex = 1;
            this.btnReporte2.Text = "Pedidos por Repartidor";
            this.btnReporte2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReporte2.UseVisualStyleBackColor = true;
            this.btnReporte2.Click += new System.EventHandler(this.btnReporte2_Click);
            // 
            // btnReporte1
            // 
            this.btnReporte1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporte1.FlatAppearance.BorderSize = 0;
            this.btnReporte1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte1.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte1.ForeColor = System.Drawing.Color.Snow;
            this.btnReporte1.Location = new System.Drawing.Point(0, 0);
            this.btnReporte1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReporte1.Name = "btnReporte1";
            this.btnReporte1.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnReporte1.Size = new System.Drawing.Size(183, 53);
            this.btnReporte1.TabIndex = 0;
            this.btnReporte1.Text = "Productos más vendidos";
            this.btnReporte1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReporte1.UseVisualStyleBackColor = true;
            this.btnReporte1.Click += new System.EventHandler(this.btnReporte1_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Snow;
            this.btnReportes.Location = new System.Drawing.Point(0, 150);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(183, 37);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnRepartidores
            // 
            this.btnRepartidores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRepartidores.FlatAppearance.BorderSize = 0;
            this.btnRepartidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepartidores.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepartidores.ForeColor = System.Drawing.Color.Snow;
            this.btnRepartidores.Location = new System.Drawing.Point(0, 113);
            this.btnRepartidores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRepartidores.Name = "btnRepartidores";
            this.btnRepartidores.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnRepartidores.Size = new System.Drawing.Size(183, 37);
            this.btnRepartidores.TabIndex = 1;
            this.btnRepartidores.Text = "Repartidores";
            this.btnRepartidores.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRepartidores.UseVisualStyleBackColor = true;
            this.btnRepartidores.Click += new System.EventHandler(this.btnRepartidores_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.Snow;
            this.btnPedidos.Location = new System.Drawing.Point(0, 76);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnPedidos.Size = new System.Drawing.Size(183, 37);
            this.btnPedidos.TabIndex = 0;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.Pedidos);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(183, 76);
            this.panelLogo.TabIndex = 0;
            // 
            // Pedidos
            // 
            this.Pedidos.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pedidos.ForeColor = System.Drawing.Color.Snow;
            this.Pedidos.Location = new System.Drawing.Point(73, 12);
            this.Pedidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(97, 50);
            this.Pedidos.TabIndex = 1;
            this.Pedidos.Text = "Pedidos JQ";
            this.Pedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pedidos.Click += new System.EventHandler(this.Pedidos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedorHijo
            // 
            this.panelContenedorHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorHijo.Location = new System.Drawing.Point(183, 0);
            this.panelContenedorHijo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContenedorHijo.Name = "panelContenedorHijo";
            this.panelContenedorHijo.Size = new System.Drawing.Size(567, 650);
            this.panelContenedorHijo.TabIndex = 10;
            this.panelContenedorHijo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorHijo_Paint);
            this.panelContenedorHijo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContenedorHijo_MouseDown);
            // 
            // panelBarraSuperior
            // 
            this.panelBarraSuperior.Controls.Add(this.btnCerrar);
            this.panelBarraSuperior.Controls.Add(this.btnMinimizar);
            this.panelBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraSuperior.Location = new System.Drawing.Point(183, 0);
            this.panelBarraSuperior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBarraSuperior.Name = "panelBarraSuperior";
            this.panelBarraSuperior.Size = new System.Drawing.Size(567, 34);
            this.panelBarraSuperior.TabIndex = 11;
            this.panelBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraSuperior_MouseDown);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(750, 650);
            this.Controls.Add(this.panelBarraSuperior);
            this.Controls.Add(this.panelContenedorHijo);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestorRepartidores";
            this.Load += new System.EventHandler(this.GestorRepartidores_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GestorRepartidores_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubMenuReportes.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBarraSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSubMenuReportes;
        private System.Windows.Forms.Button btnReporte3;
        private System.Windows.Forms.Button btnReporte2;
        private System.Windows.Forms.Button btnReporte1;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnRepartidores;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelContenedorHijo;
        private System.Windows.Forms.Panel panelBarraSuperior;
        private System.Windows.Forms.Label Pedidos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}