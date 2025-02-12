using System.Text.RegularExpressions;

namespace Domain.Vehicles.ValueObject;

public class NumberPlate
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
    public bool Validate(string value)
    {
        return Regex.IsMatch(value, @"^[A-Z]{3}-\d{4}$|^[A-Z]{3}\d[A-Z]\d{2}$");
    }
}
