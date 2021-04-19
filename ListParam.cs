using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webapi_swagger
{
    public class ListParam
    {
        [Required]
        public int recordStart { get; set; }
        [Required]
        public int recordEnd { get; set; }

        public FilterApi? filter { get; set; }
    }

    public class FilterApi
    {
        public bool IsExempted { get; set; }
        public List<string> CustomerCode { get; set; } = new List<string>();
    }
}
