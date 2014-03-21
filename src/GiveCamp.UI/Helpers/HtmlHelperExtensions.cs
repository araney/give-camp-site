using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiveCamp.UI.Helpers
{
    public static class HtmlHelperExtensions
    {
        public static PanelHelper BeginPanel(this HtmlHelper htmlHelper)
        {
            return new PanelHelper(htmlHelper);
        }

        public static PanelHelper BeginPanel(this HtmlHelper htmlHelper, string heading)
        {
            return new PanelHelper(htmlHelper, heading);
        }
    }
}