using System.Text.RegularExpressions;

namespace Domain.Customers.ValueObject;

public sealed partial class DocumentNumber
{
    public string Value { get; set; }

    public DocumentNumber(string value)
    {
        if (!Validate(value))
        {
            throw new Exception("");
        }

        Value = value;

    }

    private static bool Validate(string value)
    {
        return MyRegex().IsMatch(value);
    }

    [GeneratedRegex(@"^\d{3}.\d{3}.\d{3}-\d{2}$")]
    private static partial Regex MyRegex();
}
