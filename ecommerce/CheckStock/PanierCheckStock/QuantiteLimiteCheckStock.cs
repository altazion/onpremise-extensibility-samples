using CPointSoftware.Equihira.Extensibility.ECommerce;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanierCheckStock
{
    [Export(typeof(IPanierStockCheck))]
    public class QuantiteLimiteCheckStock : IPanierStockCheck
    {
        public bool CheckStock(Guid art_guid, ref decimal quantite, Guid? magasin, string typeCommandable)
        {
            // Really simple "fake check" : if guid is odd
            // then only 1 is available, if even, 2 is available
            // if >= 'a' then 3
            var t = art_guid.ToString("N");
            t = t.Substring(t.Length - 1);
            if (t[0] >= '0' && t[0] <= '9')
            {
                int i = int.Parse(t);
                if (i % 2 == 1)
                {
                    if (quantite > 1)
                    {
                        quantite = 1;
                        return false;
                    }
                    else
                        return true;
                }
                else
                {
                    if (quantite > 2)
                    {
                        quantite = 2;
                        return false;
                    }
                    else
                        return true;
                }
            }
            else
            {
                if (quantite <= 3)
                    return true;
                else
                {
                    quantite = 3;
                    return false;
                }
            }
        }
    }
}
