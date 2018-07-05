namespace TrocaOleo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtQtdeLitro = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbOleo = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblOleo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblVLitro = new System.Windows.Forms.Label();
            this.lblQLItro = new System.Windows.Forms.Label();
            this.lblVTotal = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtValorLitro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQtdeLitro
            // 
            this.txtQtdeLitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeLitro.Location = new System.Drawing.Point(346, 193);
            this.txtQtdeLitro.Name = "txtQtdeLitro";
            this.txtQtdeLitro.Size = new System.Drawing.Size(139, 27);
            this.txtQtdeLitro.TabIndex = 1;
            this.txtQtdeLitro.TextChanged += new System.EventHandler(this.txtQtdeLitro_TextChanged);
            this.txtQtdeLitro.Validating += new System.ComponentModel.CancelEventHandler(this.txtQtdeLitro_Validating);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(346, 219);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(139, 27);
            this.txtValorTotal.TabIndex = 2;
            this.txtValorTotal.TextChanged += new System.EventHandler(this.txtValorTotal_TextChanged);
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(346, 32);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(164, 28);
            this.cmbCliente.TabIndex = 3;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(346, 86);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(164, 28);
            this.cmbCategoria.TabIndex = 4;
            // 
            // cmbOleo
            // 
            this.cmbOleo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOleo.FormattingEnabled = true;
            this.cmbOleo.Location = new System.Drawing.Point(346, 59);
            this.cmbOleo.Name = "cmbOleo";
            this.cmbOleo.Size = new System.Drawing.Size(164, 28);
            this.cmbOleo.TabIndex = 5;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(346, 113);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(164, 28);
            this.cmbTipo.TabIndex = 6;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(346, 140);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(164, 28);
            this.cmbFabricante.TabIndex = 7;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Enabled = false;
            this.txtEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(346, 245);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(139, 27);
            this.txtEmailCliente.TabIndex = 8;
            this.txtEmailCliente.TextChanged += new System.EventHandler(this.txtEmailCliente_TextChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lblData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblData.Location = new System.Drawing.Point(220, 6);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(47, 24);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(346, 7);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 27);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2018, 7, 5, 0, 0, 0, 0);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lblCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCliente.Location = new System.Drawing.Point(220, 33);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(68, 24);
            this.lblCliente.TabIndex = 11;
            this.lblCliente.Text = "Cliente";
            // 
            // lblOleo
            // 
            this.lblOleo.AutoSize = true;
            this.lblOleo.BackColor = System.Drawing.Color.Transparent;
            this.lblOleo.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lblOleo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOleo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOleo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOleo.Location = new System.Drawing.Point(220, 60);
            this.lblOleo.Name = "lblOleo";
            this.lblOleo.Size = new System.Drawing.Size(51, 24);
            this.lblOleo.TabIndex = 12;
            this.lblOleo.Text = "Óleo";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lblCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCategoria.Location = new System.Drawing.Point(220, 87);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(90, 24);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lblTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTipo.Location = new System.Drawing.Point(220, 114);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(48, 24);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipo";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.BackColor = System.Drawing.Color.Transparent;
            this.lblFabricante.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lblFabricante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricante.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFabricante.Location = new System.Drawing.Point(220, 141);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(99, 24);
            this.lblFabricante.TabIndex = 15;
            this.lblFabricante.Text = "Fabricante";
            // 
            // lblVLitro
            // 
            this.lblVLitro.AutoSize = true;
            this.lblVLitro.BackColor = System.Drawing.Color.Transparent;
            this.lblVLitro.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lblVLitro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVLitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVLitro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVLitro.Location = new System.Drawing.Point(220, 167);
            this.lblVLitro.Name = "lblVLitro";
            this.lblVLitro.Size = new System.Drawing.Size(94, 24);
            this.lblVLitro.TabIndex = 16;
            this.lblVLitro.Text = "Valor Litro";
            // 
            // lblQLItro
            // 
            this.lblQLItro.AutoSize = true;
            this.lblQLItro.BackColor = System.Drawing.Color.Transparent;
            this.lblQLItro.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lblQLItro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQLItro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLItro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQLItro.Location = new System.Drawing.Point(220, 193);
            this.lblQLItro.Name = "lblQLItro";
            this.lblQLItro.Size = new System.Drawing.Size(91, 24);
            this.lblQLItro.TabIndex = 17;
            this.lblQLItro.Text = "Qtde Litro";
            // 
            // lblVTotal
            // 
            this.lblVTotal.AutoSize = true;
            this.lblVTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblVTotal.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lblVTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVTotal.Location = new System.Drawing.Point(220, 219);
            this.lblVTotal.Name = "lblVTotal";
            this.lblVTotal.Size = new System.Drawing.Size(100, 24);
            this.lblVTotal.TabIndex = 18;
            this.lblVTotal.Text = "Valor Total";
            this.lblVTotal.Click += new System.EventHandler(this.lblVTotal_Click);
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailCliente.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lblEmailCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmailCliente.Location = new System.Drawing.Point(220, 245);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(120, 24);
            this.lblEmailCliente.TabIndex = 19;
            this.lblEmailCliente.Text = "Email Cliente";
            this.lblEmailCliente.Click += new System.EventHandler(this.lblEmailCliente_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.Location = new System.Drawing.Point(513, 260);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 40);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtValorLitro
            // 
            this.txtValorLitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorLitro.Location = new System.Drawing.Point(346, 167);
            this.txtValorLitro.Name = "txtValorLitro";
            this.txtValorLitro.Size = new System.Drawing.Size(139, 27);
            this.txtValorLitro.TabIndex = 0;
            this.txtValorLitro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::TrocaOleo.Properties.Resources.troca_de_oleo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.lblVTotal);
            this.Controls.Add(this.lblQLItro);
            this.Controls.Add(this.lblVLitro);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblOleo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbOleo);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtQtdeLitro);
            this.Controls.Add(this.txtValorLitro);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Serviço de Óleo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtQtdeLitro;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbOleo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblOleo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblVLitro;
        private System.Windows.Forms.Label lblQLItro;
        private System.Windows.Forms.Label lblVTotal;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtValorLitro;
    }
}

