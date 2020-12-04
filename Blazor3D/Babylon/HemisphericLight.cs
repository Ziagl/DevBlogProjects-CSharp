using Microsoft.JSInterop;

namespace Blazor3D.Babylon
{
    public class HemisphericLight : BabylonObject
    {
        public HemisphericLight(IJSRuntime jsRuntime, JsRuntimeObjectRef objRef) : base(jsRuntime, objRef) { }
    }
}
