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
    [Export(typeof(IProvideMoreProductData))]
    public class ChangeNameOfProducts : IProvideMoreProductData
    {
        public void AddInfoToDetails(int rjs_id, int sit_pk, ArticlePhygitalDetail details)
        {
            if (details.Libelle != null)
                details.Libelle = new string(details.Libelle.Reverse().ToArray());
        }

        public void AddInfoToList(int rjs_id, int sit_pk, ArticlePhygitalBase[] items)
        {
            if (items == null)
                return;

            foreach (var details in items)
            {
                if (details.Libelle != null)
                    details.Libelle = new string(details.Libelle.Reverse().ToArray());
            }
        }
    }
}
