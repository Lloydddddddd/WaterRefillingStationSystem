using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterRefillingStationSystem.Forms2
{
    public partial class FormAddDispenserRent : DevExpress.XtraEditors.XtraForm
    {
        public FormAddDispenserRent()
        {
            InitializeComponent();
        }

        private void FormAddDispenserRent_Load(object sender, EventArgs e)
        {
            SetLatestOrderDate();
        }
        private void SetLatestOrderDate()
        {
            //labelOrderDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}