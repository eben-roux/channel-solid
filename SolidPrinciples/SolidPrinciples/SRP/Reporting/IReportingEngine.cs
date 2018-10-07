using System.IO;

namespace SolidPrinciples.SRP.Reporting
{
    public interface IReportingEngine
    {
        Stream Render(ReportDefinition definition);
    }
}