using System.Text.RegularExpressions;

namespace Domain.Vehicles.ValueObject;

public partial class NumberPlate
{
    public string Value { get; private set; }
    public NumberPlate(string value)
    {
        if (!Validate(value))
        {
            throw new Exception("");
        }
        Value = value;
    }
    public static bool Validate(string value)
    {
        return MyRegex().IsMatch(value);
    }

    [GeneratedRegex(@"^[A-Z]{3}-\d{4}$|^[A-Z]{3}\d[A-Z]\d{2}$")]
    private static partial Regex MyRegex();
}