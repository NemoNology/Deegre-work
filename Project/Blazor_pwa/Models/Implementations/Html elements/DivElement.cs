using Blazor_pwa.Models.Emums;
using Blazor_pwa.Models.Interfaces;

namespace Blazor_pwa.Models.Implementations
{
    public class DivElement : HtmlElement
    {
        public override HtmlElementType Type => HtmlElementType.Div;

        public DivElement() : base() { }
    }
}