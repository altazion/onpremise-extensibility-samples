using CPointSoftware.Equihira.Common;
using CPointSoftware.Equihira.Extensibility.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace DossierArticleExtensions
{
    [Export(typeof(IWebDossierArticlePart))]
    public class EspageGeneral : IWebDossierArticlePart
    {
        public string Group => "Generales";

        public System.Web.UI.Control GetControl(ArticleBase article)
        {
            StringBuilder blr = new StringBuilder();

            // on construit de l'html de façon très basique
            blr.Append("<div style='background:firebrick;text:#efefef;padding:10px;'>");
            blr.Append("Extension de démo sur : ");
            blr.Append(article.Libelle);
            blr.Append("</div>");

            // et on l'ajoute sans tag particulier
            var ct = new Literal();
            ct.Text = blr.ToString();
            return ct;
        }
    }
}
