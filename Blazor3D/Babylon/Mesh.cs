using Microsoft.JSInterop;

namespace Blazor3D.Babylon
{
    public class Mesh : BabylonObject
    {
        public Mesh(IJSRuntime jsRuntime, JsRuntimeObjectRef objRef) : base(jsRuntime, objRef) { }
    }
}
