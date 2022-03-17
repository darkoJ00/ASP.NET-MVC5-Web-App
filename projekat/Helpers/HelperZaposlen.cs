using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekat.Helpers
{
    public static class HelperZaposlen
    {
        public static MvcHtmlString StatusZaposlen(bool zaposlen)
        {
            var builder = new TagBuilder("div");

            if (zaposlen == false)
            {
                builder.InnerHtml = "<p>*Napomena - Kandidat nije zaposlen</p>";
            }
            else
            {
                builder.InnerHtml = "<p>Kandidat je zaposlen.</p>";
            }
            return new MvcHtmlString(builder.ToString());
        }
    }
}