#pragma checksum "G:\SDP\Project\Shop-Management-System\SDP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "360cc1bd2d696da33ed142df09874e89a7e45643"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "G:\SDP\Project\Shop-Management-System\SDP\Views\_ViewImports.cshtml"
using SDP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\SDP\Project\Shop-Management-System\SDP\Views\_ViewImports.cshtml"
using SDP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"360cc1bd2d696da33ed142df09874e89a7e45643", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05cba2b556eab87c229afa8de49a53b5eb5e26e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/AdminFeature.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-animation", new global::Microsoft.AspNetCore.Html.HtmlString("fadeInUp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-delay", new global::Microsoft.AspNetCore.Html.HtmlString("500ms"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn oneMusic-btn mt-50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddStaff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Staff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\SDP\Project\Shop-Management-System\SDP\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "360cc1bd2d696da33ed142df09874e89a7e456438470", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<section class=""hero-area"">
    <div class=""hero-slides owl-carousel"">
        <!-- Single Hero Slide -->
        <div class=""single-hero-slide d-flex align-items-center justify-content-center"">
            <!-- Slide Img -->
            <div class=""slide-img bg-img"" style=""background-image: url(/img/bg-img/shop-bg.jpg);""></div>
            <!-- Slide Content -->
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""hero-slides-content text-center"">
");
            WriteLiteral("                            <h2 data-animation=\"fadeinup\" data-delay=\"300ms\">latest products <span></span></h2>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "360cc1bd2d696da33ed142df09874e89a7e4564310338", async() => {
                WriteLiteral("Discover <i class=\"fa fa-angle-double-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Single Hero Slide -->
        <div class=""single-hero-slide d-flex align-items-center justify-content-center"">
            <!-- Slide Img -->
            <div class=""slide-img bg-img"" style=""background-image: url(img/bg-img/shop-bg-1.jpg);""></div>
            <!-- Slide Content -->
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""hero-slides-content text-center"">
                            <h2 data-animation=""fadeInUp"" data-delay=""300ms"">Enjoy our Service <span>Enjoy our Service</span></h2>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "360cc1bd2d696da33ed142df09874e89a7e4564312779", async() => {
                WriteLiteral("Discover <i class=\"fa fa-angle-double-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            WriteLiteral(@"<section class=""three-extradiv"">
    <div class=""container"">
        <h1 class=""text-center font-weight-bold""> OUR QUALITY FACTORS</h1>
        <div class=""row rowsetting"">
            <div class=""col-lg-4 col-md-4 col-sm-4 col-12 extra-div "" data-toggle=""modal""
                 data-target=""#exampleModalCenter1"">
                <a href=""#""><img src=""/img/bg-img/customer.svg"" width=""70"" height=""70""");
            BeginWriteAttribute("alt", " alt=\"", 6599, "\"", 6605, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>

                <h2 class=""text-center"">CUSTOMER</h2>

            </div>
            <div class=""col-lg-4 col-md-4 col-sm-4 col-12 extra-div"" data-toggle=""modal"" data-target=""#exampleModalCenter2"">
                <a href=""#""><img src=""/img/bg-img/groceryy.svg"" width=""70"" height=""70""");
            BeginWriteAttribute("alt", " alt=\"", 6904, "\"", 6910, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                <h2 class=""text-center"">PRODUCT</h2>


            </div>

            <div class=""col-lg-4 col-md-4 col-sm-4 col-12 extra-div"" data-toggle=""modal"" data-target=""#exampleModalCenter3"">
                <a href=""#"" class=""center""><img src=""/img/bg-img/leaderr.svg"" width=""70"" height=""70""");
            BeginWriteAttribute("alt", " alt=\"", 7224, "\"", 7230, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>

                <h2 class=""text-center"">STAFF</h2>

            </div>
        </div>

    </div>
</section>

<!-- Modal for customer -->
<div class=""modal fade"" id=""exampleModalCenter1"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle""
     aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Customer</h5>
                <div type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true""><i class=""fa fa-times""></i></span>
                </div>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col"" style=""margin-left: 100px"">
                        <div class=""my-icon"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "360cc1bd2d696da33ed142df09874e89a7e4564317096", async() => {
                WriteLiteral("<i class=\"fa fa-plus \"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
                        <div class=""my-text"">Add</div>
                    </div>
                    <div class=""col "" style=""margin-left: 100px"">
                        <div class=""my-icon""><i class=""fa fa-pencil ""></i></a></div>
                        <div class=""my-text"">Update</div>
                    </div>
                </div>
            </div>
            <!-- <div class=""modal-footer"">
              <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
              <button type=""button"" class=""btn btn-primary"">Save changes</button>
            </div> -->
        </div>
    </div>
</div>

<!-- Modal for product -->
<div class=""modal fade"" id=""exampleModalCenter2"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle""
     aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title");
            WriteLiteral(@""" id=""exampleModalLongTitle"">Product</h5>
                <div type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true""><i class=""fa fa-times""></i></span>
                </div>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col"" style=""margin-left: 100px"">
                        <div class=""my-icon"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "360cc1bd2d696da33ed142df09874e89a7e4564320047", async() => {
                WriteLiteral("<i class=\"fa fa-plus \"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                        <div class=\"my-text\" >Add</div>\r\n                    </div>\r\n                    <div class=\"col \" style=\"margin-left: 100px\">\r\n                        <div class=\"my-icon\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "360cc1bd2d696da33ed142df09874e89a7e4564321649", async() => {
                WriteLiteral("<i class=\"fa fa-pencil \"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
                        <div class=""my-text"" >Update</div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Modal for staff -->
<div class=""modal fade"" id=""exampleModalCenter3"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle""
     aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Staff</h5>
                <div type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true""><i class=""fa fa-times""></i></span>
                </div>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col"" style=""margin-left: 100px"">
                        <div class=""my-icon"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "360cc1bd2d696da33ed142df09874e89a7e4564324059", async() => {
                WriteLiteral("<i class=\"fa fa-plus \"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
                        <div class=""my-text"" >Add</div>
                    </div>
                    <div class=""col"" style=""margin-left: 100px"">
                        <div class=""my-icon""><i class=""fa fa-pencil ""></i></div>
                        <div class=""my-text"">Update</div>
                    </div>
                </div>
            </div>
            <!-- <div class=""modal-footer"">
              <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
              <button type=""button"" class=""btn btn-primary"">Save changes</button>
            </div> -->
        </div>
    </div>
</div>

<!-- ========== Milestones ========== -->
<!-- ##### Contact Area Start ##### -->
<section class=""contact-area section-padding-100 bg-img bg-overlay bg-fixed has-bg-img"" style=""background-image: url(img/bg-img/bg-2.jpg);"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""section-heading whi");
            WriteLiteral(@"te wow fadeInUp"" data-wow-delay=""100ms"">
                    <p>See what’s new</p>
                    <h2>Get In Touch</h2>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-12"">
                <!-- Contact Form Area -->
                <div class=""contact-form-area"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "360cc1bd2d696da33ed142df09874e89a7e4564326909", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-md-6 col-lg-4"">
                                <div class=""form-group wow fadeInUp"" data-wow-delay=""100ms"">
                                    <input type=""text"" class=""form-control"" id=""name"" placeholder=""Name"">
                                </div>
                            </div>
                            <div class=""col-md-6 col-lg-4"">
                                <div class=""form-group wow fadeInUp"" data-wow-delay=""200ms"">
                                    <input type=""email"" class=""form-control"" id=""email"" placeholder=""E-mail"">
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""form-group wow fadeInUp"" data-wow-delay=""300ms"">
                                    <input type=""text"" class=""form-control"" id=""subject"" placeholder=""Subject"">
                                </div>
");
                WriteLiteral(@"                            </div>
                            <div class=""col-12"">
                                <div class=""form-group wow fadeInUp"" data-wow-delay=""400ms"">
                                    <textarea name=""message"" class=""form-control"" id=""message"" cols=""30"" rows=""10"" placeholder=""Message""></textarea>
                                </div>
                            </div>
                            <div class=""col-12 text-center wow fadeInUp"" data-wow-delay=""500ms"">
                                <button class=""btn oneMusic-btn mt-30"" type=""submit"">Send <i class=""fa fa-angle-double-right""></i></button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
