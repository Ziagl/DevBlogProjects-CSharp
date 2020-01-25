using Avalonia;
using Avalonia.Markup.Xaml;

namespace CSharpAvaloniaBeispiel
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}