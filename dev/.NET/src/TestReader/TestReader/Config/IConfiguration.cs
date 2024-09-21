namespace TestReader.Config
{
    internal interface IConfiguration
    {
        (string name, int rowOffset, int colOffset, int rowSize, int colSize) GetConfig();
    }
}
