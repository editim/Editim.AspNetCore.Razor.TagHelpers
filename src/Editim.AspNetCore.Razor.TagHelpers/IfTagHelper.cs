using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Editim.AspNetCore.Razor.TagHelpers
{
    [HtmlTargetElement(Attributes = "asp-if")]
    public class IfTagHelper : TagHelper
    {
        [HtmlAttributeName("asp-if")]
        public bool Condition { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!Condition)
            {
                output.SuppressOutput();
            }
        }
    }
}
