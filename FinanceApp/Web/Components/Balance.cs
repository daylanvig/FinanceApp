using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Globalization;

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
            var styleClass = Value >= 0 ? "has-text-success" : "has-text-danger"; // bulma styles
            if (output.Attributes.TryGetAttribute("class", out TagHelperAttribute existingClasses)) // this might make sense as a static or extension method
            {
                styleClass += " " + existingClasses.Value;
            }
            styleClass += " has-text-right";
            output.Attributes.SetAttribute("class", styleClass);
        }
    }
}
