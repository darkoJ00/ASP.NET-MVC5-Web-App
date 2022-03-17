using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekat.Helpers
{
    public static class HelperMailDisplay
    {
        public static MvcHtmlString MailDisplay(string mail)
        {
            var builder =new TagBuilder("div");
            
            if (mail != null) 
            {
                builder.InnerHtml = "<p>Hvala na poverenju!<br /> Dobijaćete redovna obaveštenja o novostima na adresi:</p>" + mail;
            }
            else 
            {
                builder.InnerHtml = "<p>Niste uneli email adresu </p>";
            }
            return new MvcHtmlString(builder.ToString());
        }
    }
}