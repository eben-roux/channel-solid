namespace SolidPrinciples.Incorrect.ISP
{
    public interface IAmTooBroad
    {
        void GenerateReport();
        void SendEMail();
        void Subscribe();
        void Save();
        void Load();
        void AsXml();
    }
}