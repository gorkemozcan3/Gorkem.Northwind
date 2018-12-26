using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorkem.Northwind.MvcWebUI.TagHelpers
{
    [HtmlTargetElement("product-list-pager")]
    public class PagingTagHelper : TagHelper
    {
        [HtmlAttributeName("page-size")]
        public int PageSize { get; set; }
        [HtmlAttributeName("page-count")]
        public int PageCount { get; set; }
        [HtmlAttributeName("current-category")]
        public int CurrentCategory { get; set; }
        [HtmlAttributeName("current-page")]
        public int CurrentPage { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div"; // bir div in içine yazar

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<ul class='pagination'>");

            stringBuilder.AppendFormat("<li class='{0}'><a href = '/product/index?page={1}&category={2}'" +
                "aria-label = \"Previous\" ><span aria-hidden = 'true' > &laquo;</span></a></li>",
                CurrentPage == 1 ? "disabled" : "", CurrentPage - 1, CurrentCategory);
            for (int i = 1; i <= PageCount; i++)
            {
                stringBuilder.AppendFormat("<li class='{0}'><a href='/product/index?page={1}&category={2}'>{3}</a></li>",
                    i == CurrentPage ? "active" : "", i, CurrentCategory, i);
            }
            stringBuilder.AppendFormat("<li class='{0}'><a href = '/product/index?page={1}&category={2}' " +
                "aria-label = \"Next\" ><span aria-hidden = 'true'>&raquo;</span></a></li></ul>",
                CurrentPage == PageCount ? "disabled" : "", CurrentPage + 1, CurrentCategory);

            output.Content.SetHtmlContent(stringBuilder.ToString());

            base.Process(context, output);
        }
    }
}
