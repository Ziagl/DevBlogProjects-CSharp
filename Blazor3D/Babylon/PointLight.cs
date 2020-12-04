using Microsoft.JSInterop;

namespace Blazor3D.Babylon
{
    public class PointLight : BabylonObject
    {
        public PointLight(IJSRuntime jsRuntime, JsRuntimeObjectRef objRef) : base(jsRuntime, objRef) { }
    }
}
