using Traderok.Domain.Core;

namespace Traderok
{
    public enum AccountType
    {
        Standart,
        Pro
    }
    public interface IAccoutType //тип аккаута платный или бесплатный
    {
        AccountType Type { get; }
    }
}