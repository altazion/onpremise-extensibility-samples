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
    /// Cette classe modifie les contenus de la
    /// fiche produit et des descentes en inversant
    /// tous les caractères du libellé des articles
    /// </summary>
    [Export(typeof(IProvideMoreProductData))] // ne pas oublier l'export !
    public class ChangeNameOfProducts : IProvideMoreProductData
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
            // comme exemple : on inverse le libellé de l'article
            if (details.Libelle != null)
                details.Libelle = new string(details.Libelle.Reverse().ToArray());
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
            if (items == null)
                return;

            // comme exemple : on inverse le libellé de l'article
            foreach (var details in items)
            {
                if (details.Libelle != null)
                    details.Libelle = new string(details.Libelle.Reverse().ToArray());
            }
        }
    }
}
