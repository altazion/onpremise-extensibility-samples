using CPointSoftware.Equihira.Common;
using CPointSoftware.Equihira.Extensibility.ECommerce;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartLineCustomData
{
    [Export(typeof(IInfoLignePanierProvider))]
    public class AddNoteToCartLine : IInfoLignePanierProvider
    {
        public InfoLignePanier GetInfos(Guid ebc_guid, Guid elbGuid, ArticleQuantiteEtPrix article)
        {
            var note = new Random().Next(4) + 1;

            // add a random note to the line
            // using unicode star symbols 
            return new InfoLignePanier()
            {
                DonneePersonnalisee1 = new string('\u2605', note).PadRight(5, '\u2606')
            };
        }
    }
}
