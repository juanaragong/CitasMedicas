namespace CitasM
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            txtTelefono = new TextBox();
            btnSalio = new Button();
            txtClave = new TextBox();
            btnAgendar = new Button();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtMotivo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            dgvDatos = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(btnSalio);
            groupBox1.Controls.Add(txtClave);
            groupBox1.Controls.Add(btnAgendar);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 229);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Paciente";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(187, 109);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 5;
            // 
            // btnSalio
            // 
            btnSalio.Location = new Point(133, 177);
            btnSalio.Name = "btnSalio";
            btnSalio.Size = new Size(112, 34);
            btnSalio.TabIndex = 3;
            btnSalio.Text = "Ya Salio";
            btnSalio.UseVisualStyleBackColor = true;
            btnSalio.Click += btnSalio_Click;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(187, 70);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(150, 31);
            txtClave.TabIndex = 4;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(15, 177);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(112, 34);
            btnAgendar.TabIndex = 2;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(187, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 115);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 73);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Clave";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 38);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre paciente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMotivo);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dtpFecha);
            groupBox2.Location = new Point(454, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(438, 239);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Cita";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(28, 147);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(337, 74);
            txtMotivo.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 119);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 2;
            label5.Text = "Motivo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 47);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 1;
            label4.Text = "Seleccione la fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(39, 77);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(357, 31);
            dtpFecha.TabIndex = 0;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(12, 268);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 62;
            dgvDatos.Size = new Size(880, 225);
            dgvDatos.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 516);
            Controls.Add(dgvDatos);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnAgendar;
        private Button btnSalio;
        private DataGridView dgvDatos;
        private TextBox txtTelefono;
        private TextBox txtClave;
        private TextBox txtNombre;
        private TextBox txtMotivo;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpFecha;
    }
}
