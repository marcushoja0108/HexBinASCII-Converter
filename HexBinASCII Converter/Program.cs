using HexBinASCII_Converter;

UserInterface userInterface = new UserInterface();
Converter converter = new Converter();
while (true)
{
        userInterface.MainMenu();
        string userInput = Console.ReadLine().ToLower();
        if (converter.SetInputType(userInput) == true)
        {
            
                userInterface.ConversionValueInput();
                userInput = Console.ReadLine();
                converter.ConvertInput(userInput);
        }
        else userInterface.InvalidType("input");
}

