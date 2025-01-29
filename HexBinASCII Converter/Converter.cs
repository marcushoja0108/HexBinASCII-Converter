using System.Text;

namespace HexBinASCII_Converter;

public class Converter
{
    private string inputType { get; set; }
    private string BinOutPut { get; set; }
    private string HexOutPut { get; set; }
    private string ASCIIOutPut { get; set; }

    public bool SetInputType(string input)
    {
        bool result;
        if (input == "hex" || input == "bin" || input == "ascii")
        {
            inputType = input;
            result = true;
        }
        else result = false;
        return result;
    }

    public void ConvertInput(string userInput)
    {
        HexOutPut = "";
        ASCIIOutPut = "";
        BinOutPut = "";
        
        switch (inputType)
        {
            case "hex":
                ConvertFromHex(userInput);
                break;
            case "bin":
                ConvertFromBin(userInput);
                break;
            case "ascii":
                ConvertFromASCII(userInput);
                break;
        }
        ShowOutput();
    }

    public void ShowOutput()
    {
        Console.WriteLine();
        Console.WriteLine($"Hexadecimal: {HexOutPut}");
        Console.WriteLine($"Binary: {BinOutPut}");
        Console.WriteLine($"ASCII: {ASCIIOutPut}");
    }
    
    private void ConvertFromASCII(string userInput)
    {
        ASCIIOutPut = userInput;
        ASCIIToHex(userInput);
        HexToBinary(HexOutPut);
    }

    private void ConvertFromHex(string userInput)
    {
        HexOutPut = userInput;
        HexToASCII(userInput);
        HexToBinary(userInput);
    }

    private void ConvertFromBin(string userInput)
    {
        BinOutPut = userInput;
        BinaryToHex(userInput);
        HexToASCII(HexOutPut);
    }

    private void ASCIIToHex(string ASCIIString)
    {
        char[]characters = ASCIIString.ToUpper().ToCharArray();
        foreach (char character in characters)
        {
            HexOutPut += ((int)character).ToString("X2");
        }
    }
    private void BinaryToHex(string BinaryString)
    {
        for (int i = 0; i < BinaryString.Length; i += 4)
        {
            string characters = BinaryString.Substring(i, 4);
            {
                switch (characters)
                {
                    case "0000":
                        HexOutPut += "0";
                        break;
                    case "0001":
                        HexOutPut += "1";
                        break;
                    case "0010":
                        HexOutPut += "2";
                        break;
                    case "0011":
                        HexOutPut += "3";
                        break;
                    case "0100":
                        HexOutPut += "4";
                        break;
                    case "0101":
                        HexOutPut += "5";
                        break;
                    case "0110":
                        HexOutPut += "6";
                        break;
                    case "0111":
                        HexOutPut += "7";
                        break;
                    case "1000":
                        HexOutPut += "8";
                        break;
                    case "1001":
                        HexOutPut += "9";
                        break;
                    case "1010":
                        HexOutPut += "A";
                        break;
                    case "1011":
                        HexOutPut += "B";
                        break;
                    case "1100":
                        HexOutPut += "C";
                        break;
                    case "1101":
                        HexOutPut += "D";
                        break;
                    case "1110":
                        HexOutPut += "E";
                        break;
                    case "1111":
                        HexOutPut += "F";
                        break;
                }
            }
        }
    }
   

    private void HexToASCII(string HexString)
    {
        StringBuilder ascii = new StringBuilder();
        for (int i = 0; i < HexString.Length; i += 2)
        {
            string characters = HexOutPut.Substring(i, 2);
            int asciiValue = Convert.ToInt32(characters, 16);
            ascii.Append((char)asciiValue);
        }
        ASCIIOutPut = ascii.ToString();
    }

    private void HexToBinary(string HexString)
    {
        char[] hexArray = HexString.ToUpper().ToCharArray();
        foreach (var element in hexArray)
        {
            switch (element)
            {
                case '0':
                    BinOutPut += "0000";
                    break;
                case '1':
                    BinOutPut += "0001";
                    break;
                case '2':
                    BinOutPut += "0010";
                    break;
                case '3':
                    BinOutPut += "0011";
                    break;
                case '4':
                    BinOutPut += "0100";
                    break;
                case '5':
                    BinOutPut += "0101";
                    break;
                case '6':
                    BinOutPut += "0110";
                    break;
                case '7':
                    BinOutPut += "0111";
                    break;
                case '8':
                    BinOutPut += "1000";
                    break;
                case '9':
                    BinOutPut += "1001";
                    break;
                case 'A':
                    BinOutPut += "1010";
                    break;
                case 'B':
                    BinOutPut += "1011";
                    break;
                case 'C':
                    BinOutPut += "1100";
                    break;
                case 'D':
                    BinOutPut += "1101";
                    break;
                case 'E':
                    BinOutPut += "1110";
                    break;
                case 'F':
                    BinOutPut += "1111";
                    break;
                default:
                    Console.WriteLine($"Invalid hexadecimal {element}");
                    break;
            }
        }
    }

}

