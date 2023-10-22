using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormMenuPrincipal : Form
    {
        readonly ClassChilde newform = new();
        bool sidebarExpand;
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            newform.AbrirFormulario<FormInicio>(panelCentral);
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void btnPanelInicio_Click(object sender, EventArgs e)
        {
            sideBar.Width = sideBar.MinimumSize.Width;
            newform.AbrirFormulario<FormInicio>(panelCentral);
        }

        private void btnPanelUsuarios_Click(object sender, EventArgs e)
        {
            sideBar.Width = sideBar.MinimumSize.Width;
            newform.AbrirFormulario<FormUsuarios>(panelCentral);
        }

        private void btnPanelMaquinas_Click(object sender, EventArgs e)
        {
            //dropDownMenu1.Show(btnPanelMaquinas, btnPanelMaquinas.Width, 0);
            newform.abrir(new FormMaquinas(), panelCentral);
        }

        private void FormMenuPrincipal_ResizeEnd(object sender, EventArgs e)
        {
            newform.FormResize();
        }

        private void btnPanelReservas_Click(object sender, EventArgs e)
        {
            newform.abrir(new FormReserva(), panelCentral);
        }

        private void btnPanelTarifas_Click(object sender, EventArgs e)
        {
            newform.abrir(new FormTarifas(), panelCentral);
        }

        private void BtnPanelBackUp_Click(object sender, EventArgs e)
        {
            newform.abrir(new FormBackup(), panelCentral);
        }

        private void BtnPanelInformes_Click(object sender, EventArgs e)
        {
            newform.abrir(new FormInformes(), panelCentral);
        }
    }
}
