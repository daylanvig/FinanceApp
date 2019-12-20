using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;
using System.Text.Encodings.Web;

namespace FinanceApp.Web.Components
{
    /// <summary>
    /// Decorates the navbar item with bulma css classes
    /// </summary>
    [HtmlTargetElement("a", Attributes ="navbar-item")]
    public class NavbarItem : TagHelper
    {
        public string Controller { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
            output.AddClass("navbar-item", HtmlEncoder.Default);
            output.Attributes.Remove(output.Attributes.First(a => a.Name == "navbar-item"));
            output.Attributes.SetAttribute("href", $"/{Controller}/");
        }
    }
}
