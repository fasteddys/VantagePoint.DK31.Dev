using Serenity.Services;

namespace VantagePoint.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}