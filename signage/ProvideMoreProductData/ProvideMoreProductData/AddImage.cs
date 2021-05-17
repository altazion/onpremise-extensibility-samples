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
    public class AddImage : IProvideMoreProductData
    {
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

        public void AddInfoToList(int rjs_id, int sit_pk, ArticlePhygitalBase[] items)
        {
            throw new NotImplementedException();
        }
    }
}
