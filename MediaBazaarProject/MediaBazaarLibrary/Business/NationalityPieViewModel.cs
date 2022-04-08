using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MediaBazaarLibrary.Business
{
    public class NationalityPieViewModel
    {
        private PlotModel modelP1;
        private EmployeeManager employeeManager = new EmployeeManager();

        public NationalityPieViewModel()
        {
            modelP1 = new PlotModel { Title = "Nationality" };

            dynamic seriesP1 = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

            foreach (NationalityStatistics statistic in employeeManager.GetNationalityStatistics())
            {
                seriesP1.Slices.Add(new PieSlice(statistic.Nationality, statistic.Count) { IsExploded = true });
            }

            modelP1.Series.Add(seriesP1);
        }

        public PlotModel Model1
        {
            get { return modelP1; }
            set { modelP1 = value; }
        }
    }
}
