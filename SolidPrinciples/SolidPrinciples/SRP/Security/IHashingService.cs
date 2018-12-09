namespace SolidPrinciples.SRP.Security
{
    public interface IHashingService
    {
        byte[] Hash(string value);
    }
}