namespace ExtratoPDFLibrary;

public class Extrator
{

    public string GetVersion()
    {
        return "Versão 1.0";
    }

    public string[] GetBanksList()
    {
        return ["Banco do Brasil", "Bradesco", "Caixa", "Santander", "Inter", "Nubank"];
    }

    public string GetJSONItems(string bank, string text) {
        
        var driver = Factory(bank);

        return driver.Process(text);
    }

    public static IExtractorDriver Factory(string name) {
        if(name == "Banco do Brasil")  {
            return new BancoDoBrasilDriver();
        }
        
        throw new Exception("Driver not created");
    }

}
//D:\projetos\ExtratoPDFLibrary\bin\Debug\net8.0\ExtratoPDFLibrary.pdb