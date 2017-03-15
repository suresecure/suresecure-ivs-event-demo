using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRZNPlatTest
{
    public partial class FormDetail : DevComponents.DotNetBar.OfficeForm
    {
        List<SendRecord> records = null;
        DateTime dtStart = DateTime.Now;
        DateTime dtEnd = DateTime.Now;
        public FormDetail(DateTime dt1,DateTime dt2, List<SendRecord> records)
        {
            InitializeComponent();
            dtStart = dt1;
            dtEnd = dt2;
            this.records = records;
        }

        private void FormDetail_Load(object sender, EventArgs e)
        {
            lbStartTime.Text = dtStart.ToString("yyyy/MM/dd HH:mm:ss.fff");
            lbEndTime.Text =dtEnd.ToString("yyyy/MM/dd HH:mm:ss.fff");
            lbTimes.Text = (dtEnd - dtStart).TotalSeconds.ToString();
            dataGridViewX1.DataSource = records;
        }

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                DataGridView grid = sender as DataGridView;
                if (grid == null)
                    return;
                System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
                    e.RowBounds.Location.Y,
                    grid.RowHeadersWidth - 4,
                    e.RowBounds.Height);

                TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                    grid.RowHeadersDefaultCellStyle.Font,
                    rectangle,
                    grid.RowHeadersDefaultCellStyle.ForeColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Right);

                if (grid.Columns.Count > 0)
                    grid.Columns[grid.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception exp)
            {
                Logger.AddLog(this.GetType(), "dgv_RowPostPaint()", "", exp);
            }
        }
    }
}
