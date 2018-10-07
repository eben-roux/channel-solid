namespace SolidPrinciples.SRP.Security
{
    public interface IHasingService
    {
        byte[] Hash(string value);
    }
}