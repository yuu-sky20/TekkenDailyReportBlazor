using Microsoft.AspNetCore.SignalR;

namespace TekkenDailyReport.Datas
{
    public class DataDailyReportContexts
    {
        private string[] context =
        {
            "01. 作図",
            "01. 訂正",
            "02. 材料注文",
            "02. 加工指示書",
            "03. 工事ミーティング"
        };
        public string[] GetContext()
        {
            return context;
        }
    }
}
