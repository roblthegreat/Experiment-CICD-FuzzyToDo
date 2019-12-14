using Avalonia;
using Avalonia.Markup.Xaml;

namespace FuzzyToDo
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}