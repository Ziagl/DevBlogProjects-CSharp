using Microsoft.JSInterop;

namespace Blazor3D.Babylon
{
    public class ArcRotateCamera : BabylonObject
    {
        public ArcRotateCamera(IJSRuntime jsRuntime, JsRuntimeObjectRef objRef) : base(jsRuntime, objRef) { }
    }
}
