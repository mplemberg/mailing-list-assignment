using System.ComponentModel.DataAnnotations;

namespace webapi.Application.RetrieveContacts
{
    public class RetrieveContactsQuery
    {
        public const string ORDER_ASCENDING = "asc";
        public const string ORDER_DESCENDING = "desc";

        public string? lastName { get; set; }

        [RegularExpression("asc|desc", ErrorMessage = "Invalid order")]
        public string? order { get; set; }
    }
}
