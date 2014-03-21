using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiveCamp.UI.Helpers
{
    public class PanelHelper : IDisposable
    {
        private readonly HtmlHelper _htmlHelper;

        public PanelHelper(HtmlHelper htmlHelper, string heading = null)
        {
            _htmlHelper = htmlHelper;

            const string panelFormat = @"<div class=""panel"">{0}<div class=""panel-body"">";
            const string panelHeadingFormat = @"<div class=""panel-heading""><h3 class=""panel-title"">{0}</h3></div>";

            var headingOutput = (heading != null)
                ? string.Format(panelHeadingFormat, heading)
                : string.Empty;

            var output = string.Format(panelFormat, headingOutput);

            htmlHelper.ViewContext.Writer.Write(output);
        }

        public void Dispose()
        {
            _htmlHelper.ViewContext.Writer.Write("</div></div>");
        }
    }
}