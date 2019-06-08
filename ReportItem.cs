using System;

namespace linq
{
    public class ReportItem : Customer
    {
        public string CustomerName { get; set; }
        public string BankName { get; set; }

        public string GetLastName => this.CustomerName.Split(" ")[1];
    }
}