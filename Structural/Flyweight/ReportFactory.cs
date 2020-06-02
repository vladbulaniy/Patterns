using Structural.Flyweight.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Structural.Flyweight
{
    public class ReportFactory
    {
        static Dictionary<string, IReport> reports = new Dictionary<string, IReport>();

        public static IReport GetReport(string key)
        {
            if (reports.Keys.Contains(key))
            {
                return reports[key];
            }
            switch (key)
            {
                case "A":
                    IReport reportA = new ReportA();
                    reports.Add(key, reportA);
                    return reportA;
                case "B":
                    IReport reportB = new ReportB();
                    reports.Add(key, reportB);
                    return reportB;

            }
            return null;
        }
    }
}
