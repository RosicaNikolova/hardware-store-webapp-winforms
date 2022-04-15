using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class RequestedItemsPieViewModel
    {
        private PlotModel modelP3;
        private RequestManager requestManager = new RequestManager();

        public RequestedItemsPieViewModel()
        {
            modelP3 = new PlotModel { Title = "Requested items" };

            dynamic seriesP1 = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

            foreach (RequestedItemsStatistics statistic in requestManager.GetRequestedItemsStatistics())
            {
                seriesP1.Slices.Add(new PieSlice(statistic.ProductName, statistic.Count) { IsExploded = true });
            }

            modelP3.Series.Add(seriesP1);
        }

        public PlotModel Model3
        {
            get { return modelP3; }
            set { modelP3 = value; }
        }
    }
}
