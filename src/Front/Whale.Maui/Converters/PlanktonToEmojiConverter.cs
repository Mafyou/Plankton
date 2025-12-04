using System.Globalization;

namespace Whale.Maui.Converters;

public class PlanktonToEmojiConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is string kind)
        {
            return kind switch
            {
                "Little" => "\U0001F535", // 🔵 Blue Circle
                "Big" => "\U0001F7E2",    // 🟢 Green Circle
                "Average" => "\U0001F7E1", // 🟡 Yellow Circle
                _ => "\u26AA"             // ⚪ White Circle
            };
        }
        return "\u26AA";
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
