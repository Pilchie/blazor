// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    public class TestComponent : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenComponent<Test.MyComponent>(0);
            builder.AddAttribute(1, "IntProperty", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<System.Int32>(123));
            builder.AddAttribute(2, "BoolProperty", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<System.Boolean>(true));
            builder.AddAttribute(3, "StringProperty", "My string");
            builder.AddAttribute(4, "ObjectProperty", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<Test.SomeType>(new SomeType()));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591