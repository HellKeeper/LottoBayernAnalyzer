using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LottoBayernAnalyzer.Data;


namespace LottoBayernAnalyzer
{
    public partial class LottoButton : Button
    {
        #region AUX classes


        public enum StatisticsStyle
        {
            None = 0,
            DrawDiff = 1,
            TotalDraws = 2,
        }


        #endregion


        #region Fields & Properties


        protected NumberStatistics mStatistics;

        [Description("Lotto number statistics for this control."), Category("Data")]
        public NumberStatistics Statistics
        {
            get
            {
                return mStatistics ?? new NumberStatistics(0);
            }
            set
            {
                mStatistics = value ?? new NumberStatistics(0);

                UpdateProps();
            }
        }


        [Description("Lotto number represented by this control."), Category("Data")]
        public int Number
        {
            get
            {
                return this.Statistics.Number;
            }
            set
            {
                this.Statistics = new NumberStatistics(value);
            }
        }


        protected bool mChecked;

        [Description("Checked state."), Category("Data")]
        public bool Checked
        {
            get
            {
                return mChecked;
            }
            set
            {
                mChecked = value;

                UpdateProps();
            }
        }


        protected StatisticsStyle mStatStyle;

        [Description("Statistics style."), Category("Data")]
        public StatisticsStyle StatStyle
        {
            get
            {
                return mStatStyle;
            }
            set
            {
                mStatStyle = value;

                UpdateProps();
            }
        }


        #endregion


        #region Constructors


        public LottoButton()
        {
            InitializeComponent();

            SetStyle(ControlStyles.Selectable, false);
        }


        public LottoButton(int num)
            : this()
        {
            this.Number = num;
        }


        public LottoButton(NumberStatistics st)
            : this()
        {
            this.Statistics = st;
        }


        #endregion


        #region Overrides


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            PaintStatistics(e);
        }


        #endregion


        #region Implementation


        protected void UpdateProps()
        {
            this.SuspendLayout();

            Name = String.Format("btnN{0:d2}", this.Statistics.Number);

            Text = mStatStyle == StatisticsStyle.None ? this.Statistics.Number.ToString() : String.Empty;
            Image = (StatStyle == StatisticsStyle.None) && mChecked ? Properties.Resources.ButtonChecked : null;

            string tt = String.Empty;
            switch (mStatStyle)
            {
                case StatisticsStyle.DrawDiff:
                    if (this.Statistics.LastDrawDate.HasValue)
                    {
                        tt = String.Format("Last draw: {0:d} ({1:f0} weeks ago)", this.Statistics.LastDrawDate,
                            this.Statistics.LastDrawDateDiff.Value.TotalDays / 7);
                    }
                    break;
                case StatisticsStyle.TotalDraws:
                    tt = String.Format("Total draws: {0}", this.Statistics.DrawTotalCount);
                    break;
            }
            toolTip.SetToolTip(this, tt);

            this.ResumeLayout();
        }


        protected void PaintStatistics(PaintEventArgs e)
        {
            if (mStatStyle == StatisticsStyle.None) return;

            var sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            var font = new Font(Font.FontFamily, Font.Size - 5);

            string text = String.Empty;
            decimal statWeight = 0;
            bool emptyStat = false;

            var r = new Rectangle(e.ClipRectangle.Location, new Size(20, 19));

            switch (mStatStyle)
            {
                case StatisticsStyle.TotalDraws:
                    statWeight = this.Statistics.DrawTotalCountWeight;
                    if (this.Statistics.DrawTotalCount == 0)
                        emptyStat = true;
                    else
                        text = String.Format("{0}", this.Statistics.DrawTotalCount);
                    break;

                case StatisticsStyle.DrawDiff:
                    if (this.Statistics.LastDrawDiff < 0)
                        emptyStat = true;
                    else
                        text = String.Format("{0}", this.Statistics.LastDrawDiff);
                    statWeight = this.Statistics.LastDrawDiffWeight;
                    break;
            }

            if (text.Length > 2)
                r.Width += 10;
            r.Offset(e.ClipRectangle.Size.Width - r.Width - 2, e.ClipRectangle.Size.Height - r.Height - 2);

            //var startingAlpha = emptyStat ? 0 : 20;
            var alpha = emptyStat ? 255 : (int)Math.Round(20 + 200 * statWeight);
            var fillBrush = new SolidBrush(Color.FromArgb(alpha, SystemColors.Highlight));

            // fill bg
            e.Graphics.FillRectangle(fillBrush, e.ClipRectangle);

            // draw main text & checked image, if needed
            if (mStatStyle != StatisticsStyle.None)
            {
                if (mChecked)
                {
                    var imgChecked = Properties.Resources.ButtonChecked;
                    var rChecked = new Rectangle((e.ClipRectangle.Width - imgChecked.Width) / 2,
                        (e.ClipRectangle.Height - imgChecked.Height) / 2, imgChecked.Width, imgChecked.Height);
                    e.Graphics.DrawImage(imgChecked, rChecked);
                }

                var textColor = this.Statistics.LastDrawDiff == 0 ? Color.Red : emptyStat ? SystemColors.ControlDarkDark : ForeColor;
                e.Graphics.DrawString(this.Number.ToString(), Font, new SolidBrush(textColor), e.ClipRectangle, sf);
            }

            // draw statistics text
            //if (emptyStat) text = "-";
            if (!String.IsNullOrEmpty(text))
            {
                e.Graphics.DrawString(text, font, SystemBrushes.HotTrack, r, sf);
                e.Graphics.DrawEllipse(SystemPens.ControlDark, r);
            }

            
        }


        #endregion
    }
}
