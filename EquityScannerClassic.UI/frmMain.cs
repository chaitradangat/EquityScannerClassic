using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EquityScannerClassic.Application;

namespace EquityScannerClassic.UI
{
    public partial class frmMain : Form
    {
        DataTable dtsymbolData;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            lblNotification.Text = "Started saving data to disk";

            Scanner scanner = new Scanner();

            scanner.SaveDataToDisk(true);

            lblNotification.Text = "Completed saving data to disk";
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            long volume = long.Parse(txtVolume.Text);

            int timelimit = int.Parse(txtFrequency.Text);

            Scanner scanner = new Scanner();

            var symbolDatas = scanner.ScanForStocks();

            symbolDatas = scanner.AnalyzeContinousFallNew(symbolDatas, volume, timelimit);

            foreach (var symbolData in symbolDatas)
            {
                var dr = dtsymbolData.NewRow();

                dr["SYM_NAME"] = symbolData.SymbolName;

                dr["POS_STREAK"] = symbolData.positive_streak;

                dr["NEG_STREAK"] = symbolData.negative_streak;

                dr["RECENT_STREAK"] = symbolData.recent_streak;

                dr["VOLUME"] = symbolData.Volume;

                dr["SCORE"] = symbolData.FallFrequency - symbolData.RiseFrequency;

                dtsymbolData.Rows.Add(dr);

                dtsymbolData.AcceptChanges();
            }

            grdEquities.DataSource = dtsymbolData;

            lblNotification.Text = "Analysis Complete";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dtsymbolData = new DataTable();

            DataColumn[] dataColumns = new DataColumn[]{

                new DataColumn("SYM_NAME",typeof(string)),
                new DataColumn("POS_STREAK",typeof(int)),
                new DataColumn("NEG_STREAK",typeof(int)),
                new DataColumn("RECENT_STREAK",typeof(int)),
                new DataColumn("VOLUME",typeof(int)),
                new DataColumn("SCORE",typeof(int))
            };

            dtsymbolData.Columns.AddRange(dataColumns);





        }
    }
}
