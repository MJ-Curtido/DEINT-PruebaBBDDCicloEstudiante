namespace DEINT_AdminIES
{
    partial class FormEstudiantes
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
            this.imgEstudiante = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.tbApe2 = new System.Windows.Forms.TextBox();
            this.tbApe1 = new System.Windows.Forms.TextBox();
            this.lbl2Ape = new System.Windows.Forms.Label();
            this.lbl1Ape = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.cbCiclos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imgEstudiante
            // 
            this.imgEstudiante.Location = new System.Drawing.Point(13, 13);
            this.imgEstudiante.Name = "imgEstudiante";
            this.imgEstudiante.Size = new System.Drawing.Size(197, 230);
            this.imgEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEstudiante.TabIndex = 0;
            this.imgEstudiante.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(13, 273);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(197, 23);
            this.btnExaminar.TabIndex = 1;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // tbApe2
            // 
            this.tbApe2.Location = new System.Drawing.Point(510, 94);
            this.tbApe2.Name = "tbApe2";
            this.tbApe2.Size = new System.Drawing.Size(240, 20);
            this.tbApe2.TabIndex = 9;
            // 
            // tbApe1
            // 
            this.tbApe1.Location = new System.Drawing.Point(253, 94);
            this.tbApe1.Name = "tbApe1";
            this.tbApe1.Size = new System.Drawing.Size(240, 20);
            this.tbApe1.TabIndex = 8;
            // 
            // lbl2Ape
            // 
            this.lbl2Ape.AutoSize = true;
            this.lbl2Ape.Location = new System.Drawing.Point(507, 78);
            this.lbl2Ape.Name = "lbl2Ape";
            this.lbl2Ape.Size = new System.Drawing.Size(90, 13);
            this.lbl2Ape.TabIndex = 7;
            this.lbl2Ape.Text = "Segundo Apellido";
            // 
            // lbl1Ape
            // 
            this.lbl1Ape.AutoSize = true;
            this.lbl1Ape.Location = new System.Drawing.Point(250, 78);
            this.lbl1Ape.Name = "lbl1Ape";
            this.lbl1Ape.Size = new System.Drawing.Size(76, 13);
            this.lbl1Ape.TabIndex = 6;
            this.lbl1Ape.Text = "Primer Apellido";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(452, 29);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(298, 20);
            this.tbNombre.TabIndex = 13;
            // 
            // tbClave
            // 
            this.tbClave.Enabled = false;
            this.tbClave.Location = new System.Drawing.Point(253, 29);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(183, 20);
            this.tbClave.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(449, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(250, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "ID";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(253, 158);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(497, 20);
            this.tbCorreo.TabIndex = 20;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(250, 142);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 18;
            this.lblCorreo.Text = "Correo";
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Location = new System.Drawing.Point(250, 207);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(30, 13);
            this.lblCiclo.TabIndex = 14;
            this.lblCiclo.Text = "Ciclo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(253, 273);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(390, 273);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(531, 273);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 23;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(675, 273);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(13, 311);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(737, 127);
            this.gridView.TabIndex = 26;
            // 
            // cbCiclos
            // 
            this.cbCiclos.FormattingEnabled = true;
            this.cbCiclos.Location = new System.Drawing.Point(253, 223);
            this.cbCiclos.Name = "cbCiclos";
            this.cbCiclos.Size = new System.Drawing.Size(497, 21);
            this.cbCiclos.TabIndex = 28;
            // 
            // FormEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCiclos);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblCiclo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbApe2);
            this.Controls.Add(this.tbApe1);
            this.Controls.Add(this.lbl2Ape);
            this.Controls.Add(this.lbl1Ape);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.imgEstudiante);
            this.Name = "FormEstudiantes";
            this.Text = "FormEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.imgEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgEstudiante;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox tbApe2;
        private System.Windows.Forms.TextBox tbApe1;
        private System.Windows.Forms.Label lbl2Ape;
        private System.Windows.Forms.Label lbl1Ape;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.ComboBox cbCiclos;
    }
}