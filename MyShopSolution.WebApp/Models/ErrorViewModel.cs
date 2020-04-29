using System;

namespace MyShopSolution.WebApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public string mess { set; get; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
