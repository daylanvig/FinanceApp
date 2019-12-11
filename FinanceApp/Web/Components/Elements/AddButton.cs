using Microsoft.AspNetCore.Razor.TagHelpers;

namespace FinanceApp.Web.Components.Elements
{
    public class AddButton : TagHelper
    {
        public string IconClass { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
            output.TagName = "button";
            output.Attributes.SetAttribute("class", "button is-success");
            output.Content.SetHtmlContent(@"<span class=""icon is-small""><i class=""fas fa-check""></i></span><span>Add</span>");
        }
    }
}
