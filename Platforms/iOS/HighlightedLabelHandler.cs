using CoreGraphics;
using HackNightMaui.CustomRenderer;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using UIKit;

namespace HackNightMaui.Platforms
{
    public class HighlightedLabelHandler : ViewHandler<IHighlightedLabel, UILabel>
    {

        public static IPropertyMapper<IHighlightedLabel, HighlightedLabelHandler> PropertyMapper = new PropertyMapper<IHighlightedLabel, HighlightedLabelHandler>(ViewMapper)
        {
            [nameof(HighlightedLabel.HighlightColor)] = MapRed
        };

        static void MapRed(HighlightedLabelHandler handler, IHighlightedLabel redLabel)
        {
            if (handler.PlatformView != null)
            {
                handler.PlatformView.Text = redLabel.Text;
                handler.PlatformView.BackgroundColor = redLabel.HighlightColor.ToPlatform();
            }
        }

        public HighlightedLabelHandler() : base(PropertyMapper)
        {
        }

        protected override UILabel CreatePlatformView()
        {
            return new UILabel(new CGRect(0, 0, 150, 28));
        }

    }
}

