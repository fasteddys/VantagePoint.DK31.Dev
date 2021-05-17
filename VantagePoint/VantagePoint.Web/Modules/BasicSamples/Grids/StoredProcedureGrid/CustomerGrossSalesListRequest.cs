using Serenity.Services;
using System;

namespace VantagePoint.BasicSamples
{
    public class CustomerGrossSalesListRequest : ListRequest
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}