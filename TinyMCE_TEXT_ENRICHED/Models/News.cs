using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TinyMCE_TEXT_ENRICHED.Models
{
    public class News
    {
        [DisplayName("Titulo")]
        public string NewsTitle { get; set; }

        [DisplayName("Contenido")]
        [AllowHtml]
        public string Content { get; set; }
    }
}