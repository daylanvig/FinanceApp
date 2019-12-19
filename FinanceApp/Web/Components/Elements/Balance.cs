using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Globalization;
using System.Text.Encodings.Web;

namespace FinanceApp.Web.Components
{
    public class Balance : TagHelper
    {
        public decimal Value { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
            output.TagName = "div";
            output.Content.SetContent(Value.ToString("C", CultureInfo.CurrentCulture));
            output.AddClass(Value >= 0 ? "has-text-success" : "has-text-danger", HtmlEncoder.Default); // bulma styles
            output.AddClass("has-text-right is-size-5", HtmlEncoder.Default);
        }
    }
}
