namespace ExtratoPDFLibrary;

public interface IExtractorDriver {
    abstract public string Process(string text);
}