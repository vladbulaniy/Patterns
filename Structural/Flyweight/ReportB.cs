using Structural.Flyweight.Interfaces;

namespace Structural.Flyweight
{
    public class ReportB: IReport
    {
        private CompanyInformation company;

        public string ReportName { get; set; }

        public CompanyInformation CompanyInformation
        {
            get
            {
                return this.company;
            }
        }

        public void SetCompanyInformation(CompanyInformation company)
        {
            this.company = company;
        }
    }
}
