

using Xunit;

namespace ReportPortal.XUnitReporter.LogHandler
{
    public static class OutputHelperExtensions
    {
        public static ITestOutputHelper WithReportPortal(this ITestOutputHelper outputHelper)
        {
            LogHandler.XunitTestOutputHelper = outputHelper;

            return outputHelper;
        }
    }
}
