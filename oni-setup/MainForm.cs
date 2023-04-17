using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Web;
using System.Management;

namespace oni_setup
{

    

    public partial class MainForm : Form
    {
        //Variaveis
        string CPUName = Convert.ToString(Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\SYSTEM\\CentralProcessor\\0", "ProcessorNameString", null));
        public string path = Application.StartupPath;
        string gpu;

        public MainForm()
        {
            InitializeComponent();

            //Identificação dos Hardwares
            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");
            ManagementObjectSearcher myRamObject = new ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory");

            foreach (ManagementObject obj in myVideoObject.Get())
            {
                gpu = ("" + obj["Name"]);
            }

            UInt64 Capacity = 0;
            foreach (ManagementObject WniPART in myRamObject.Get())
            {
                Capacity += Convert.ToUInt64(WniPART.Properties["Capacity"].Value);
            }
            
            Capacity = Capacity / (1024 * 1024 * 1024);

            //Escrevendo os Hardwares
            lbCPU.Text = CPUName;
            lbRAM.Text = Convert.ToString(Capacity) + "GB RAM";
            lbGPU.Text = gpu;
        }

        #region Barra de titulos

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

        #region Botão Fechar: btClose

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btClose_MouseEnter(object sender, EventArgs e)
        {
            btClose.BackColor = Color.FromArgb(33, 31, 45);
        }

        private void btClose_MouseLeave(object sender, EventArgs e)
        {
            btClose.BackColor = Color.FromArgb(11, 8, 14);
        }

        #endregion

        #region Botão Minimizar: btMini
        private void btMini_MouseEnter(object sender, EventArgs e)
        {
            btMini.BackColor = Color.FromArgb(33, 31, 45);
        }
      
        private void btMini_MouseLeave(object sender, EventArgs e)
        {
            btMini.BackColor = Color.FromArgb(11, 8, 14);
        }

        private void btMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Abre Instaladoress

        //Instalador Discord
        private void btDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path + "\\Programs\\DiscordSetup.exe");
        }

        //Instalador OperaGX
        private void btOpera_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path + "\\Programs\\OperaGXSetup.exe");
        }
        
        //Ativador Windows
        private void button2_Click(object sender, EventArgs e)
        {           
            System.Diagnostics.Process.Start(path + "\\Programs\\Activator.cmd");
        }

        //Instalador Steam
        private void btSteam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path + "\\Programs\\SteamSetup.exe");
        }

        //Baixar Cod BO2
        private void btCod_Click(object sender, EventArgs e)
        {
            //Codar...
            System.Diagnostics.Process.Start(path + "\\Programs\\plutonium.exe");
            System.Diagnostics.Process.Start("https://drive.google.com/u/0/uc?id=1V3nFlf3RbkWDIu_MnG_tNMjvelRMPIP1&amp;export=download&amp;confirm=t&amp;uuid=88247924-7a8d-40cd-a7e7-1ada9c78aa3d&amp;at=ALAFpqwoVESFygFLEgFYDNgkzELZ:1667945931946");
        }

        #endregion

        #region Nao sei oq fazer com isso

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                childForm.BringToFront();
                childForm.Show();
            }
        }
        #endregion

        #region Relogio digital

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbClock.Text = dt.ToString("T");
            lbDate.Text = dt.ToString("dd MMM yyyy");           
        }

        #endregion

        #region Botão Funcionalidades

        //Botão "About"
        private void btAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        #endregion
    }
}
