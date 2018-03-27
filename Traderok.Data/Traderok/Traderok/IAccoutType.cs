namespace Traderok
{
    public enum AccountType
    {
        Standart,
        Pro
    }
    public interface IAccoutType : IEntity //тип аккаута платный или бесплатный
    {
        AccountType Type { get; }
    }
}