using CPointSoftware.Equihira.Extensibility;
using CPointSoftware.Equihira.Extensibility.PointOfSale.DigitalSignage;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvideMoreProductData
{
    /// <summary>
    /// Cette classe ajoute une images dans la partie
    /// "images complémentaires" de la fiche produit
    /// </summary>
    [Export(typeof(IProvideMoreProductData))] // ne pas oublier l'export !
    public class AddImage : IProvideMoreProductData
    {
        /// <summary>
        /// Méthode à implémenter pour modifier le contenu
        /// de la fiche produit
        /// </summary>
        /// <param name="rjs_id">La raison juridique concernée</param>
        /// <param name="sit_pk">Le site affichant les données</param>
        /// <param name="details">La fiche produit à compléter/modifier</param>
        public void AddInfoToDetails(int rjs_id, int sit_pk, ArticlePhygitalDetail details)
        {
            List<ArticleImage> imgs = new List<ArticleImage>();
            if (details.MoreImages != null)
                imgs.AddRange(details.MoreImages);
            imgs.Add(new ArticleImage()
            {
                UrlBig = "https://altazion.blob.core.windows.net/public/roadmap/noimageforrelease.png",
                UrlSmall = "https://altazion.blob.core.windows.net/public/roadmap/noimageforrelease.png"
            });
            details.MoreImages = imgs.ToArray();
        }

        /// <summary>
        /// Méthode à implémenter pour modifier le contenu
        /// la descente produits
        /// </summary>
        /// <param name="rjs_id">La raison juridique concernée</param>
        /// <param name="sit_pk">Le site affichant les données</param>
        /// <param name="items">Les produits de la descente</param>
        public void AddInfoToList(int rjs_id, int sit_pk, ArticlePhygitalBase[] items)
        {
            // on ne modifie rien sur les descentes : 
            // on peut au choix, soit laisser le corps
            // de la méthode vide ou lever une NotImplementedException
            throw new NotImplementedException();
        }
    }
}
