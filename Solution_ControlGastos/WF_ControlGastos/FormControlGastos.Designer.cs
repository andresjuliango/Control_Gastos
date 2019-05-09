namespace WF_ControlGastos
{
    partial class FormGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGastos));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGestion = new System.Windows.Forms.TabPage();
            this.tabPageMaximos = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.gbConcepto = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPageGestion.SuspendLayout();
            this.gbFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(12, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(54, 40);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(72, 12);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(54, 40);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(132, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 40);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(192, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(54, 40);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(316, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(54, 40);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(256, 12);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(54, 40);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGestion);
            this.tabControl1.Controls.Add(this.tabPageMaximos);
            this.tabControl1.Location = new System.Drawing.Point(12, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 418);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPageGestion
            // 
            this.tabPageGestion.Controls.Add(this.gbConcepto);
            this.tabPageGestion.Controls.Add(this.gbFecha);
            this.tabPageGestion.Location = new System.Drawing.Point(4, 22);
            this.tabPageGestion.Name = "tabPageGestion";
            this.tabPageGestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGestion.Size = new System.Drawing.Size(963, 392);
            this.tabPageGestion.TabIndex = 0;
            this.tabPageGestion.Text = "Gestión";
            this.tabPageGestion.UseVisualStyleBackColor = true;
            // 
            // tabPageMaximos
            // 
            this.tabPageMaximos.Location = new System.Drawing.Point(4, 22);
            this.tabPageMaximos.Name = "tabPageMaximos";
            this.tabPageMaximos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMaximos.Size = new System.Drawing.Size(963, 392);
            this.tabPageMaximos.TabIndex = 1;
            this.tabPageMaximos.Text = "Máximos";
            this.tabPageMaximos.UseVisualStyleBackColor = true;
            this.tabPageMaximos.Click += new System.EventHandler(this.tabPageMaximos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(376, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(54, 40);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.monthCalendar1);
            this.gbFecha.Location = new System.Drawing.Point(6, 6);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(265, 195);
            this.gbFecha.TabIndex = 0;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(7, 20);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // gbConcepto
            // 
            this.gbConcepto.Location = new System.Drawing.Point(6, 207);
            this.gbConcepto.Name = "gbConcepto";
            this.gbConcepto.Size = new System.Drawing.Size(265, 195);
            this.gbConcepto.TabIndex = 1;
            this.gbConcepto.TabStop = false;
            this.gbConcepto.Text = "Concepto";
            // 
            // FormGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 604);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGastos";
            this.Text = "Control de Gastos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPageGestion.ResumeLayout(false);
            this.gbFecha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGestion;
        private System.Windows.Forms.TabPage tabPageMaximos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbConcepto;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

