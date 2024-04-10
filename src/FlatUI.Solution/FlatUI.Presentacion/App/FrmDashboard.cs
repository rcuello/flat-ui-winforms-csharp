namespace FlatUI.Presentacion.App
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Resize(object sender, EventArgs e)
        {
            //Central panel en el contenedor padre
            this.panelContent.Left = (this.Width - this.panelContent.Width) / 2;
        }


    }
}
