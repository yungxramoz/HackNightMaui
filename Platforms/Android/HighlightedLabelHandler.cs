using Android.Widget;
using HackNightMaui.CustomRenderer;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace HackNightMaui.Platforms
{
    public class HighlightedLabelHandler : ViewHandler<IHighlightedLabel, TextView>
    {

        public static IPropertyMapper<IHighlightedLabel, HighlightedLabelHandler> PropertyMapper = new PropertyMapper<IHighlightedLabel, HighlightedLabelHandler>(ViewMapper)
        {
            [nameof(IHighlightedLabel.HighlightColor)] = MapRed
        };

        static void MapRed(HighlightedLabelHandler handler, IHighlightedLabel redLabel)
        {
            if (handler.PlatformView != null)
            {
                handler.PlatformView.Text = redLabel.Text;
                handler.PlatformView.SetBackgroundColor(redLabel.HighlightColor.ToPlatform());
            }
        }

        public HighlightedLabelHandler() : base(PropertyMapper)
        {
        }

        protected override TextView CreatePlatformView()
        {
            return new TextView(Context);
        }

    }
}

