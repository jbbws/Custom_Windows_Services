using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace Lab2
{
    public partial class ServiceControl : UserControl
    {
        BindingSource source;
        ServiceProvider localProvider;
        public ServiceControl()
        {
            InitializeComponent();
            dataGridService.MultiSelect = true;
            localProvider = new ServiceProvider();
            source = new BindingSource();
            localProvider.GetServices();
            source.DataSource = localProvider.ServiceList;
            this.dataGridService.DataSource = localProvider.ServiceList;

        }
        //EVENT HANDLERS
        #region 
        private void startServicebtn_Click(object sender, EventArgs e)
        {
            exec(0);
        }

        private void stopServicebtn_Click(object sender, EventArgs e)
        {
            exec(1);
        }
        private void refreshbtn_Click(object sender, EventArgs e)
        {
            exec(2);
        }
        private void startItem_Click(object sender, EventArgs e)
        {
            exec(0);
        }

        private void stopItem_Click(object sender, EventArgs e)
        {
            exec(1);
        }

        private void updateItem_Click(object sender, EventArgs e)
        {
            exec(2);
        }
        private void dataGridService_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridService.ClearSelection();
        }
        private void dataGridService_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            DataGridView.HitTestInfo hit = dataGridService.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.Cell)
            {
                dataGridService.ClearSelection();
                dataGridService.Rows[hit.RowIndex].Selected = true;
                var Item = dataGridService.SelectedRows[0].DataBoundItem;
                switch((Item as Services).Status)
                {
                    case "Running":
                        contextMenuStrip1.Items[0].Enabled = false;
                        contextMenuStrip1.Items[1].Enabled = true;
                        break;
                    case "Stopped":
                        contextMenuStrip1.Items[1].Enabled = false;
                        contextMenuStrip1.Items[0].Enabled = true;
                        break;
                }
            }

        }
        #endregion
        //FUNCTIONS
        #region
        private void exec(int type)
        {
            Cursor = Cursors.WaitCursor;
            var rows = dataGridService.SelectedRows;
            if (rows != null)
            {
                switch (type)
                {
                    case 0:
                        foreach (DataGridViewRow ser in rows)
                        {
                            (ser.DataBoundItem as Services).StartService();
                        }
                        break;
                    case 1:
                        foreach (DataGridViewRow ser in rows)
                        {
                            (ser.DataBoundItem as Services).StopService();
                        }
                        break;
                    case 2:
                        foreach (DataGridViewRow ser in rows)
                        {
                            (ser.DataBoundItem as Services).Refresh();
                        }
                        break;
                } 
            }
            RefreshService();
            Cursor = Cursors.Default;
        }
       
        private void RefreshService()
        {
            dataGridService.Refresh();
        }
        private void EnableAllMenuStripItem() {
            foreach(var item in contextMenuStrip1.Items)
            {
                (item as ToolStripMenuItem).Enabled = true; 
            }
        }
        #endregion
    }
}
