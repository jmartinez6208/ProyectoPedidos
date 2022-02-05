
namespace PresentacionEscritorio
{
    partial class PedidosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidosForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Estado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Repartidores = new System.Windows.Forms.ComboBox();
            this.comboBox_Clientes = new System.Windows.Forms.ComboBox();
            this.textBox_Conseguido = new System.Windows.Forms.TextBox();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.textBox_Fecha = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Pedidos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRepartidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRepartidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalConseguido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_EstadoPedido = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Estado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox_Repartidores);
            this.groupBox1.Controls.Add(this.comboBox_Clientes);
            this.groupBox1.Controls.Add(this.textBox_Conseguido);
            this.groupBox1.Controls.Add(this.textBox_Total);
            this.groupBox1.Controls.Add(this.textBox_Fecha);
            this.groupBox1.Controls.Add(this.textBox_Id);
            this.groupBox1.Controls.Add(this.btn_Limpiar);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(57, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 298);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // textBox_Estado
            // 
            this.textBox_Estado.Location = new System.Drawing.Point(275, 176);
            this.textBox_Estado.Name = "textBox_Estado";
            this.textBox_Estado.Size = new System.Drawing.Size(121, 22);
            this.textBox_Estado.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label7.Location = new System.Drawing.Point(159, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estado:";
            // 
            // comboBox_Repartidores
            // 
            this.comboBox_Repartidores.FormattingEnabled = true;
            this.comboBox_Repartidores.Location = new System.Drawing.Point(275, 99);
            this.comboBox_Repartidores.Name = "comboBox_Repartidores";
            this.comboBox_Repartidores.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Repartidores.TabIndex = 14;
            // 
            // comboBox_Clientes
            // 
            this.comboBox_Clientes.FormattingEnabled = true;
            this.comboBox_Clientes.Location = new System.Drawing.Point(275, 64);
            this.comboBox_Clientes.Name = "comboBox_Clientes";
            this.comboBox_Clientes.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Clientes.TabIndex = 13;
            // 
            // textBox_Conseguido
            // 
            this.textBox_Conseguido.Location = new System.Drawing.Point(275, 248);
            this.textBox_Conseguido.Name = "textBox_Conseguido";
            this.textBox_Conseguido.Size = new System.Drawing.Size(121, 22);
            this.textBox_Conseguido.TabIndex = 12;
            // 
            // textBox_Total
            // 
            this.textBox_Total.Location = new System.Drawing.Point(275, 212);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.Size = new System.Drawing.Size(121, 22);
            this.textBox_Total.TabIndex = 11;
            // 
            // textBox_Fecha
            // 
            this.textBox_Fecha.Location = new System.Drawing.Point(275, 141);
            this.textBox_Fecha.Name = "textBox_Fecha";
            this.textBox_Fecha.Size = new System.Drawing.Size(121, 22);
            this.textBox_Fecha.TabIndex = 10;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(275, 32);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(121, 22);
            this.textBox_Id.TabIndex = 9;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.btn_Limpiar.Location = new System.Drawing.Point(532, 135);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(106, 35);
            this.btn_Limpiar.TabIndex = 8;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.btn_Eliminar.Location = new System.Drawing.Point(532, 176);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(106, 35);
            this.btn_Eliminar.TabIndex = 7;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.btnGuardar.Location = new System.Drawing.Point(532, 219);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 35);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label6.Location = new System.Drawing.Point(69, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Conseguido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label5.Location = new System.Drawing.Point(175, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label4.Location = new System.Drawing.Point(166, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label3.Location = new System.Drawing.Point(125, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repartidor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label2.Location = new System.Drawing.Point(156, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label1.Location = new System.Drawing.Point(136, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Pedido:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_Pedidos);
            this.groupBox2.Controls.Add(this.comboBox_EstadoPedido);
            this.groupBox2.Location = new System.Drawing.Point(12, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 413);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla de pedidos";
            // 
            // dataGridView_Pedidos
            // 
            this.dataGridView_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.estado,
            this.idCliente,
            this.idRepartidor,
            this.fechaCreacion,
            this.NombreCliente,
            this.NombreRepartidor,
            this.total,
            this.TotalConseguido});
            this.dataGridView_Pedidos.Location = new System.Drawing.Point(6, 51);
            this.dataGridView_Pedidos.Name = "dataGridView_Pedidos";
            this.dataGridView_Pedidos.RowHeadersWidth = 51;
            this.dataGridView_Pedidos.RowTemplate.Height = 24;
            this.dataGridView_Pedidos.Size = new System.Drawing.Size(714, 356);
            this.dataGridView_Pedidos.TabIndex = 1;
            this.dataGridView_Pedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Pedidos_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "ESTADO";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 70;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "ID CLIENTE";
            this.idCliente.MinimumWidth = 6;
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            this.idCliente.Width = 125;
            // 
            // idRepartidor
            // 
            this.idRepartidor.DataPropertyName = "idRepartidor";
            this.idRepartidor.HeaderText = "IDREPARTIDOR";
            this.idRepartidor.MinimumWidth = 6;
            this.idRepartidor.Name = "idRepartidor";
            this.idRepartidor.ReadOnly = true;
            this.idRepartidor.Visible = false;
            this.idRepartidor.Width = 125;
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.DataPropertyName = "fechaCreacion";
            this.fechaCreacion.HeaderText = "FECHA";
            this.fechaCreacion.MinimumWidth = 6;
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.ReadOnly = true;
            this.fechaCreacion.Width = 90;
            // 
            // NombreCliente
            // 
            this.NombreCliente.DataPropertyName = "NombreCliente";
            this.NombreCliente.HeaderText = "CLIENTE";
            this.NombreCliente.MinimumWidth = 6;
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 125;
            // 
            // NombreRepartidor
            // 
            this.NombreRepartidor.DataPropertyName = "NombreRepartidor";
            this.NombreRepartidor.HeaderText = "REPARTIDOR";
            this.NombreRepartidor.MinimumWidth = 6;
            this.NombreRepartidor.Name = "NombreRepartidor";
            this.NombreRepartidor.ReadOnly = true;
            this.NombreRepartidor.Width = 125;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "TOTAL";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 90;
            // 
            // TotalConseguido
            // 
            this.TotalConseguido.DataPropertyName = "TotalConseguido";
            this.TotalConseguido.HeaderText = "CONSEGUIDO";
            this.TotalConseguido.MinimumWidth = 6;
            this.TotalConseguido.Name = "TotalConseguido";
            this.TotalConseguido.ReadOnly = true;
            this.TotalConseguido.Width = 90;
            // 
            // comboBox_EstadoPedido
            // 
            this.comboBox_EstadoPedido.FormattingEnabled = true;
            this.comboBox_EstadoPedido.Location = new System.Drawing.Point(6, 21);
            this.comboBox_EstadoPedido.Name = "comboBox_EstadoPedido";
            this.comboBox_EstadoPedido.Size = new System.Drawing.Size(274, 24);
            this.comboBox_EstadoPedido.TabIndex = 0;
            // 
            // PedidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PedidosForm";
            this.Text = "PedidosForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_Pedidos;
        private System.Windows.Forms.ComboBox comboBox_EstadoPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_Fecha;
        private System.Windows.Forms.ComboBox comboBox_Repartidores;
        private System.Windows.Forms.ComboBox comboBox_Clientes;
        private System.Windows.Forms.TextBox textBox_Conseguido;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRepartidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRepartidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalConseguido;
    }
}