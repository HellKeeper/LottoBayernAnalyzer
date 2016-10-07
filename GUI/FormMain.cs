using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LottoBayernAnalyzer.Data;


namespace LottoBayernAnalyzer
{
    public partial class FormMain : Form
    {
        #region Fields & Properties



        private List<Lotto6from49.DataEntry> mLotto6from49Data = null;

        public List<Lotto6from49.DataEntry> Lotto6from49Data
        {
            get
            {
                if (mLotto6from49Data == null)
                    mLotto6from49Data = GetLotto6from49Data();
                return mLotto6from49Data;
            }
            set
            {
                mLotto6from49Data = value;
            }

        }


        public List<Lotto6from49.DataEntry> Lotto6from49DataFiltered
        {
            get
            {
                return FilterData(this.Lotto6from49Data);
            }
        }


        #endregion


        #region Event Handlers


        public FormMain()
        {
            InitializeComponent();

            this.Text = AssemblyInfo.OneStringInfo;
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            btnAllDates_Click(this, EventArgs.Empty);
        }


        private void ImgType_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Resources.Lotto6from49Url);
        }


        private void btnLottoN_Click(object sender, EventArgs e)
        {
            var b = (sender as LottoButton);
            if (b == null) return;

            if (!b.Checked)
            {
                var curCnt = GetButtons(b.Parent as TableLayoutPanel).Where(bi => bi.Checked).Count();
                if (curCnt >= Lotto6from49.MaxNumberCount)
                    return;
            }

            // toggle checked state
            b.Checked = !b.Checked;
            b.Refresh();
        }


        private void filters_Changed(object sender, EventArgs e)
        {
            InitData(tlpLotto6from49, this.Lotto6from49DataFiltered);
        }


        private void btnLastYear_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now.Date.AddYears(-1);
        }


        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now.Date.AddMonths(-1);
        }


        private void btnLastWeek_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now.Date.AddDays(-7);
        }


        private void btnAllDates_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = this.Lotto6from49Data.Min(d => d.Date);
        }


        #endregion


        #region Implementation


        private List<Lotto6from49.DataEntry> GetLotto6from49Data()
        {
            var data = new List<Lotto6from49.DataEntry>();

            try
            {
                data = Lotto6from49.GetArchiveData(
                    Properties.Resources.Lotto6from49ArchiveUrl,
                    Properties.Resources.Lotto6from49Filename);
            }
            catch (Exception ex)
            {
                MsgBox.Error("Error getting data: {0}", ex.Message);
            }

            return data;
        }


        private void InitData(TableLayoutPanel tlp, List<Lotto6from49.DataEntry> data)
        {
            var sts = NumberStatistics.CreateAllFromLottoData(data);

            try
            {
                tlp.SuspendLayout();
                tlp.Controls.Clear();

                //TODO: ! preserve the currently selected numbers

                int curNum = 0;
                for (int iRow = 0; iRow < tlp.RowCount; ++iRow)
                {
                    for (int iCol = 0; iCol < tlp.ColumnCount; ++iCol)
                    {
                        var b = new LottoButton(sts[curNum++]);
                        var style = LottoButton.StatisticsStyle.None;
                        try
                        {
                            var rb = panelMode.Controls.Cast<Control>()
                                .Where(c => c is RadioButton && (c as RadioButton).Checked)
                                .FirstOrDefault();
                            style = (LottoButton.StatisticsStyle)Enum.Parse(style.GetType(), rb.Tag.ToString());
                        }
                        catch { }
                        b.StatStyle = style;
                        b.Click += btnLottoN_Click;

                        tlp.Controls.Add(b, iCol, iRow);
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBox.Error("Error initializing data: {0}", ex.Message);
            }
            finally
            {
                tlp.ResumeLayout();
            }
        }


        private IEnumerable<LottoButton> GetButtons(TableLayoutPanel tlp)
        {
            if (tlp == null)
                return new LottoButton[0];

            return tlp.Controls.Cast<Control>()
                .Where(c => c is LottoButton)
                .Select(c => c as LottoButton);
        }


        private List<Lotto6from49.DataEntry> FilterData(List<Lotto6from49.DataEntry> data)
        {
            return data
                .Where(d => (d.Date >= dtpStartDate.Value) &&
                            ((d.IsOnWednesday && cbWednesdays.Checked) || (d.IsOnSaturday && cbSaturdays.Checked)))
                .ToList();
        }


        #endregion
    }
}
