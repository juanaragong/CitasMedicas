using System.Runtime.CompilerServices;

namespace CitasM
{
    public partial class Form1 : Form
    {

        List<CitaMedica> citaMedicas = new List<CitaMedica>();
        public Form1()
        {
            InitializeComponent();
            LlenarGrid();
        }

        private void LlenarGrid()
        {
            dgvDatos.ColumnCount = 6;
            dgvDatos.Columns[0].Name = "Nombre";
            dgvDatos.Columns[1].Name = "Clave";
            dgvDatos.Columns[2].Name = "Telefono";
            dgvDatos.Columns[3].Name = "Fecha";
            dgvDatos.Columns[4].Name = "Hora";
            dgvDatos.Columns[5].Name = "Motivo";

        }

        private void ActualizaGrid()
        {
            dgvDatos.Rows.Clear();
            foreach (CitaMedica cita in citaMedicas)
            {
                dgvDatos.Rows.Add(cita.Paciente.NombrePaciente, cita.Paciente.Clave, cita.Paciente.Telefono
                    , cita.Fecha.ToString("dd/MM/yy"), cita.Hora.ToString(), cita.Motivo);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string clave = txtClave.Text;
            string telefono = txtTelefono.Text;

            Paciente pacientito = new Paciente(nombre, clave, telefono);

            DateTime fechaCita = dtpFecha.Value.Date;
            TimeSpan horaCita = dtpFecha.Value.TimeOfDay;
            string motivo = txtMotivo.Text;

            CitaMedica cita = new CitaMedica(fechaCita, horaCita, pacientito, motivo);

            citaMedicas.Add(cita);
            ActualizaGrid();
            MessageBox.Show("Cita Medica Agendada Satisfactoriamente" + "\r Tu numero de turno es: " + citaMedicas.Count.ToString());

        }

        private void btnSalio_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                int indiceFila = dgvDatos.SelectedRows[0].Index;
                citaMedicas.RemoveAt(indiceFila);
                ActualizaGrid();
                MessageBox.Show("El paciente ya fue atendido");
            }
            else
            {
                MessageBox.Show("No hay elementos en la agenda");
            }
        }
    }
}
