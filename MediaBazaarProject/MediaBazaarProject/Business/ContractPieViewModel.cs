using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

namespace MediaBazaarProject.Business
{
    public class ContractPieViewModel
    {
        private PlotModel modelP2;
        private EmployeeManager employeeManager = new EmployeeManager();

        public ContractPieViewModel()
        {
            modelP2 = new PlotModel { Title = "Contract" };

            dynamic seriesP2 = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

            foreach (ContractStatistics statistic in employeeManager.GetContractStatistics())
            {
                if (statistic.ContractType == "True")
                {
                    seriesP2.Slices.Add(new PieSlice("Permanent", statistic.Count) { IsExploded = true });
                }
                else
                {
                    seriesP2.Slices.Add(new PieSlice("Temporary", statistic.Count) { IsExploded = true });
                }
            }

            modelP2.Series.Add(seriesP2);
        }

        public PlotModel Model2
        {
            get { return modelP2; }
            set { modelP2 = value; }
        }
    }
}
