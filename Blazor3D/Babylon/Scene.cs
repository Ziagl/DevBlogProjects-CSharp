using Microsoft.JSInterop;

namespace Blazor3D.Babylon
{
    public class Scene : BabylonObject
    {
        public Scene(IJSRuntime jsRuntime, JsRuntimeObjectRef objRef) : base(jsRuntime, objRef) { }
    }
}
