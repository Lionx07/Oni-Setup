using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace oni_setup
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();           
        }

        #region Barra de Titulos

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region BtClose: Fechar

        //Botão icone Fechar
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Animação ao selicionar o icone Fechar ==============================
        private void btClose_MouseEnter(object sender, EventArgs e)
        {
            btClose.BackColor = Color.FromArgb(33, 31, 45);
        }

        private void btClose_MouseLeave(object sender, EventArgs e)
        {
            btClose.BackColor = Color.FromArgb(11, 8, 14);
        }
        //=====================================================================

        //Botão OK
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Animação Nome "Ayame"

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (lbName.ForeColor == Color.FromArgb(11, 8, 14))
            {
                lbName.ForeColor = Color.FromArgb(120, 6, 48);
            }
            else
            {
                lbName.ForeColor = Color.FromArgb(11, 8, 14);
            }
        }

        #endregion
    }
}
