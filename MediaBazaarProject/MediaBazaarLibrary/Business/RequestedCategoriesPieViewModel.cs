using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class RequestedCategoriesPieViewModel
    {
        private PlotModel modelP4;
        private RequestManager requestManager = new RequestManager();

        public RequestedCategoriesPieViewModel()
        {
            modelP4 = new PlotModel { Title = "Requested Categories" };

            dynamic seriesP1 = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

            foreach (RequestedCategoriesStatistics statistic in requestManager.GetRequestedCategoriesStatistics())
            {
                seriesP1.Slices.Add(new PieSlice(statistic.CategoryName, statistic.Count) { IsExploded = true });
            }

            modelP4.Series.Add(seriesP1);
        }

        public PlotModel Model4
        {
            get { return modelP4; }
            set { modelP4 = value; }
        }
    }
}
