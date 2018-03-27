using System;

namespace Traderok
{
    public interface IDeposit : IEntity
    {
        DateTime Refill { get; set; } //Дата пополнения
        double SumRefill { get; set; } //Сумма пополнения
        DateTime DebitTheAccount { get; set; } //Дата списания со счета
        double SumDebitTheAccount { get; set; } //Сумма списания со счета
    }
}