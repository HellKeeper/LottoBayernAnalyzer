using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoBayernAnalyzer.Data
{
    public class NumberStatistics
    {
        #region Fields and Properties


        public int Number { get; set; }



        public Lotto6from49.DataEntry LastDraw { get; set; }

        public DateTime? LastDrawDate { get { return this.LastDraw == null ? (DateTime?)null : this.LastDraw.Date; } }

        public TimeSpan? LastDrawDateDiff { get { return this.LastDraw == null ? (TimeSpan?)null : DateTime.Now - this.LastDraw.Date; } }


        public int LastDrawDiff { get; set; }

        public int LastDrawDiffMax { get; set; }

        public decimal LastDrawDiffWeight
        {
            get
            {
                return this.LastDrawDiff < 0 ? 1 :
                        (decimal)this.LastDrawDiff / (this.LastDrawDiffMax + 1);
            }
        }


        public int DrawTotalCount { get; set; }

        public int DrawTotalCountMin { get; set; }
        public int DrawTotalCountMax { get; set; }

        public decimal DrawTotalCountWeight
        {
            get
            {
                //return (this.DrawTotalCountMax - this.DrawTotalCountMin) == 0 ? 0 :
                //        (decimal)(this.DrawTotalCount - this.DrawTotalCountMin) /
                //                 (this.DrawTotalCountMax - this.DrawTotalCountMin);
                return (this.DrawTotalCountMax - this.DrawTotalCountMin) == 0 ? 1 :
                        1 - (decimal)(this.DrawTotalCount - this.DrawTotalCountMin) /
                                     (this.DrawTotalCountMax - this.DrawTotalCountMin);
            }
        }


        #endregion


        public NumberStatistics (int num)
        {
            this.Number = num;
        }



        #region Static methods


        public static NumberStatistics CreateFromLottoData(List<Lotto6from49.DataEntry> data, int num)
        {
            var ns = new NumberStatistics(num);

            var draws = data
                .Where(d => d.Numbers.Contains(num))
                .OrderByDescending(d => d.Date)
                .ToList();

            ns.LastDraw = draws.FirstOrDefault();

            ns.DrawTotalCountMax = ns.DrawTotalCount = draws.Count();

            if (ns.LastDraw != null)
            {
                ns.LastDrawDiffMax = ns.LastDrawDiff = data
                    .Where(d => d.Date >= ns.LastDraw.Date)
                    .Count() - 1;
            }
            else
                ns.LastDrawDiff = -1;




            return ns;
        }


        public static List<NumberStatistics> CreateAllFromLottoData(List<Lotto6from49.DataEntry> data)
        {
            var sts = new List<NumberStatistics>();

            // greate statistics for teach number
            for (int num = Lotto6from49.MinNumber; num <= Lotto6from49.MaxNumber; ++num)
                sts.Add(NumberStatistics.CreateFromLottoData(data, num));

            // update statistics regarding values in the whole collection
            int drawTotalMin = sts.Min(st => st.DrawTotalCount);
            int drawTotalMax = sts.Max(st => st.DrawTotalCount);
            int drawDiffMax = sts.Max(st => st.LastDrawDiff);
            sts.ForEach((st) =>
            {
                st.DrawTotalCountMin = drawTotalMin;
                st.DrawTotalCountMax = drawTotalMax;
                st.LastDrawDiffMax = drawDiffMax;
            });

            return sts;
        }


        #endregion
    }
}
