using TekkenDailyReport.Datas;
using TekkenDailyReport.Models;

namespace TekkenDailyReport.DTOs
{
    public class DtoDailyReport
    {
        private DataDailyReportTimes dataDailyReportTimes = new DataDailyReportTimes();
        private List<ModelDailyReport> dailyReports = new List<ModelDailyReport>();

        public DtoDailyReport()
        {
            string[] times = dataDailyReportTimes.getTimes();
            for (int i = 0; i < times.Length; i++)
            {
                dailyReports.Add(new ModelDailyReport()
                {
                    Time = times[i],
                    Number = null,
                    Context = null,
                });
            }
        }

        public ModelDailyReport[] GetDailyReports()
        {
            return dailyReports.ToArray();
        }
        public void ReplaceDailyReport(ModelDailyReport model)
        {
            dailyReports.ForEach((dailyReport) =>
            {
                if (dailyReport.Time == model.Time)
                {
                    dailyReport = model;
                }
            });
        }
    }
}
