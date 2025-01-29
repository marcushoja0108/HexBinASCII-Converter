namespace HexBinASCII_Converter;

public class UserInterface
{
    public void MainMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to Hex Bin ASCII Converter");
        Console.WriteLine("Choose your input");
        Console.WriteLine("Hex || Bin || ASCII");
    }

    public void InvalidType(string type)
    {
        Console.WriteLine($"Invalid {type}type");
    }

    public void ConversionValueInput()
    {
        Console.WriteLine("Type your value");
    }
}
