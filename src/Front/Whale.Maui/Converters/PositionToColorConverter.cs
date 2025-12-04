using System.Globalization;

namespace Whale.Maui.Converters;

public class PositionToColorConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values[0] is int position)
        {
            return position switch
            {
                1 => Color.FromArgb("#FFD700"), // Gold
                2 => Color.FromArgb("#C0C0C0"), // Silver
                3 => Color.FromArgb("#CD7F32"), // Bronze
                _ => Color.FromArgb("#3E92CC")  // Ocean Light
            };
        }
        return Color.FromArgb("#3E92CC");
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
