using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EjFormu05
{
	public partial class MainForm : Form
	{
		private Beisbol ball = new Beisbol();

		public MainForm()
		{
			InitializeComponent();
			Buscar.Click += new EventHandler(Buscar_Click);
			// Evento anónimo

			Registrar.Click += new EventHandler(Registrar_Click);
			Actualizar.Click += new EventHandler(Actualizar_Click);
			Reiniciar.Click += delegate
			{
				Buscar.Enabled = true;
				Registrar.Enabled = true;
				Actualizar.Enabled = false;
				Nombre.Text = "";
				Ciudad.Text = "";
				GanadosCount.Text = "";
				PerdidosCount.Text = "";
				Nacional.Checked = false;
				Americana.Checked = false;
				Nombre.Focus();
			};
		}

		private void Buscar_Click(object sender, EventArgs e)
		{
			String nombre = Nombre.Text;
			if (ball.Buscar(nombre) == true)
			{
				Baseball m = ball.Consultar(nombre);




				Ciudad.Text = m.NombreCiudad;
				GanadosCount.Text = m.JuegosGanados;
				PerdidosCount.Text = m.JuegosPerdidos;
				if (m.Liga == true)
				{
					Nacional.Checked = true;
				}
				else
				{
					Americana.Checked = true;
				}
				Registrar.Enabled = false;
				Actualizar.Enabled = true;

			}
			else
			{
				MessageBox.Show("El Equipo aún no ha sido registrado", "AVISO");
				Nacional.Checked = false;
				Americana.Checked = false;
				Registrar.Enabled = true;
				Actualizar.Enabled = false;
			}
		}

		private void Registrar_Click(object sender, EventArgs e)
		{
			String nombre = Nombre.Text;
			if (ball.Buscar(nombre) == false)
			{
				Baseball x = new Baseball();
				x.Nombre = Nombre.Text;
				x.NombreCiudad = Ciudad.Text;
				x.Liga = Nacional.Checked;
				x.JuegosPerdidos = PerdidosCount.Text;
				x.JuegosGanados = GanadosCount.Text;
				ball.Registrar(x);
				MessageBox.Show("El equipo fue registrado correctamente", "AVISO");
			}
			else
			{
				MessageBox.Show("El equipo que intentó registrar, previamente ya fue registrado", "AVISO");
			}
		}

		private void Actualizar_Click(object sender, EventArgs e)
		{
			Baseball x = new Baseball();
			x.Nombre = Nombre.Text;
			x.NombreCiudad = Ciudad.Text;
			x.Liga = Nacional.Checked;
			x.JuegosPerdidos = PerdidosCount.Text;
			x.JuegosGanados = GanadosCount.Text;

			if (ball.Buscar(x.Nombre) == true)
			{
				ball.Actualizar(x);
				MessageBox.Show("Los datos del Equipo fueron actualizados correctamente", "AVISO");
			}
			else
			{
				MessageBox.Show("El Nombre del Equipo ingresado, está incorrecto o no existe en nuestros datos.", "AVISO");
			}

		}


		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show("Está apunto de registrar un equipo, ¿desea continuar?", "AVISO", MessageBoxButtons.YesNo);

			if (r == DialogResult.Yes)
			{
				MessageBox.Show("El equipo fue registrado exitosamente", "AVISO");
			}
			button4.Enabled = true;
		}

        private void button4_Click(object sender, EventArgs e)
        {
			DialogResult r = MessageBox.Show("Al presionar al botón de aceptar actualizara los datos del equipo, sin embargo no tendrá acceso a los datos anteriores.", "AVISO", MessageBoxButtons.YesNo);

			if (r == DialogResult.Yes)
			{
				MessageBox.Show("Los datos del equipo fueron exitosamente actualizados", "AVISO");
			}


		}

        private void button2_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Las cajas de textos fueron reiniciadas para que pueda escribir nuevos equipos", "AVISO");
			button4.Enabled = false;

			textBox2.Text = "";
			textBox3.Text = "";
			textBox5.Text = "";
			comboBox1.Items.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
			DialogResult r = MessageBox.Show("¿Desea salir del programa?", "Salida del programa", MessageBoxButtons.OKCancel);

			if (r == DialogResult.OK)
			{
				Application.Exit();
			}
		}

        private void button5_Click(object sender, EventArgs e)
        {
			DialogResult r = MessageBox.Show("¿El Equipo que intenta buscar ya fue registrado previamente?", "ATENCIÓN", MessageBoxButtons.YesNo);

			if (r == DialogResult.Yes)
            {
				MessageBox.Show("El equipo fue buscado y encontrado con éxito.", "AVISO");
            }
			
			else
            {
				MessageBox.Show("El equipo debe ser previamente registrado.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
			DialogResult r = MessageBox.Show("¿Desea eliminar por completo los datos del equipo ingresado? RECUERDE: Los datos no podrán ser recuperados", "ATENCIÓN", MessageBoxButtons.YesNo);
		
			if(r == DialogResult.Yes)
            {
				MessageBox.Show("Los datos del equipo fueron eliminados correctamente","MENSAJE");
            }
		}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Todos los integrantes del IUJO le damos un gran saludo a " + textBox4.Text, "¡Saludos!");
        }
    }
    }

