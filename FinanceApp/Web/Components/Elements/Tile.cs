using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.Components
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="https://bulma.io/documentation/layout/tiles/"/>
    public class Tile : TagHelper
    {
        public int? Size { get; set; }
        [HtmlAttributeName("vertical")]
        public bool IsVertical { get; set; }
        [HtmlAttributeName("parent")]
        public bool IsParent { get; set; }
        public string Colour { get; set; } // notification, info, message, success
        public string ContentClass { get; set; }
        public string HoverColour { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
            List<string> classes = new List<string>() { "tile", "component" };
            if (Size.HasValue)
            {
                classes.Add($"is-{Size.Value}");
            }
            if (IsParent) // a tile can be a parent or a child or neither. 
            {
                classes.Add($"is-parent");

            } else if (ContentClass != null)
            {
                classes.Add($"is-child {ContentClass}");
            }
            if (IsVertical)
            {
                classes.Add("is-vertical");
            }
            if(Colour != null)
            {
                classes.Add($"has-background-{Colour}");
            }
            if(HoverColour != null)
            {
                classes.Add($"has-background-{HoverColour}--hover");
            }
            output.Attributes.SetAttribute("class", string.Join(' ', classes));
            output.TagName = "div";
        }

    }
}
