using System.Text.RegularExpressions;

namespace Domain.Customers.ValueObject;

public sealed class DocumentNumber
{
    public string Value { get; set; }

    public DocumentNumber(string value)
    {
        if (!Validate(value)) throw new Exception("");
        Value = value;

    }

    private bool Validate(string value)
    {
        return Regex.IsMatch(value, @"^\d{3}.\d{3}.\d{3}-\d{2}$");
    }
}
