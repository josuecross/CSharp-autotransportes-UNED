using Tarea1;
using LibreriaCliente;
using GUI_Cliente.WindowsForm;

namespace GUI_Cliente
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ApplicationConfiguration.Initialize();
            while (true)
            {
                Cliente cliente = new Cliente();

                Thread iniciarCliente = new Thread(cliente.iniciarCliente);
                iniciarCliente.Start();

                SolicitarCedula formularioAuth = new SolicitarCedula(cliente);

                DialogResult stateAuth = formularioAuth.ShowDialog();

                if (stateAuth == DialogResult.OK)
                {
                    Application.Run(new Menu(cliente));
                }
                else if (stateAuth == DialogResult.No)
                {
                    MessageBox.Show("Su numero de cedula no esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (stateAuth == DialogResult.Cancel)
                {
                    Environment.Exit(0);
                }

            }


        }

        public static void closeMenu(Menu _menu, Cliente cliente
            )
        {
            _menu.Hide();

            SolicitarCedula formularioAuth = new SolicitarCedula(cliente);

            if (formularioAuth.ShowDialog() == DialogResult.OK)
            {
                _menu.Show();
            }


        }
    }
}