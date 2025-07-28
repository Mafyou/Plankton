namespace Plankton.API.Helpers;

public class ValidatingPlanklon
{
    public static bool IsValidToDecrypt(FeedCryptedDTO? plankton)
    {
        // Check if the plankton object & its fields are null
        if (plankton is null ||
            !plankton.HasValue)
        {
            return false;
        }
        // Check if the Kind or Count properties are null or empty
        if (string.IsNullOrEmpty(plankton.Value.Kind) ||
            string.IsNullOrEmpty(plankton.Value.Count))
        {
            return false;
        }
        // Check if the Feed properties contains only alphanumeric characters
        if (!CheckValidCaracters(plankton.Value.Kind) || !CheckValidCaracters(plankton.Value.Count))
        {
            return false;
        }
        // If all checks passed, the plankton is valid to feed the whale
        return true;
    }

    private static bool CheckValidCaracters(string field)
    {
        foreach (char c in field)
        {
            if (!char.IsLetter(c))
            {
                return false;
            }
        }
        return true;
    }
}