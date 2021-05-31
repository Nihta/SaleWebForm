using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaleWebForm.helpers
{
    public class HtmlHelpers
    {
        public static string MakeCard(string cardHeader, string cardBody)
        {
            return $"<div class='container-fluid px-4 mt-4'><div class='row'><div class='card mb-4 p-0'><div class='card-header'>{cardHeader}</div><div class='card-body'>{cardBody}</div></div></div></div>";
        }
    }
}