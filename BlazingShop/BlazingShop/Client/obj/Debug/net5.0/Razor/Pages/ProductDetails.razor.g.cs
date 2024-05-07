#pragma checksum "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\Pages\ProductDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d03d29c505143c88b4c9f5319ff1d0dfd89fa74"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingShop.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\_Imports.razor"
using BlazingShop.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product/{id}")]
    public partial class ProductDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "media");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "media-img-big-wrapper mr-2");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "class", "media-img-big");
            __builder.AddAttribute(6, "src", 
#nullable restore
#line 6 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\Pages\ProductDetails.razor"
                                         _product.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "alt", 
#nullable restore
#line 6 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\Pages\ProductDetails.razor"
                                                               _product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "media-body");
            __builder.OpenElement(11, "h2");
            __builder.AddAttribute(12, "class", "mb-0");
            __builder.AddContent(13, 
#nullable restore
#line 9 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\Pages\ProductDetails.razor"
                          _product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "p");
            __builder.AddContent(16, 
#nullable restore
#line 10 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\Pages\ProductDetails.razor"
            _product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\Pages\ProductDetails.razor"
         if (_product.OriginalPrice > _product.Price)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "h6");
            __builder.AddAttribute(18, "class", "text-muted original-price");
            __builder.AddContent(19, "$");
            __builder.AddContent(20, 
#nullable restore
#line 13 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\Pages\ProductDetails.razor"
                                                    _product.OriginalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\Pages\ProductDetails.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "h4");
            __builder.AddAttribute(22, "class", "price");
            __builder.AddContent(23, "$");
            __builder.AddContent(24, 
#nullable restore
#line 15 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\Pages\ProductDetails.razor"
                            _product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddMarkupContent(26, "<button class=\"btn btn-primary\"><i class=\"oi oi-cart\"></i>&nbsp; &nbsp; &nbsp;Add to Cart</button>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Safak\RiderProjects\E-Commerce\BlazingShop\BlazingShop\Client\Pages\ProductDetails.razor"
       
    private Product _product;
    
    [Parameter]
    public string Id { get; set; }

    protected override void OnInitialized()
    {
        if (ProductService.Products == null || ProductService.Products.Count == 0)
        {
            ProductService.LoadProducts();
            return;
        }

        _product = ProductService.Products.FirstOrDefault(p => p.Id == int.Parse(Id));
        base.OnInitialized();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591