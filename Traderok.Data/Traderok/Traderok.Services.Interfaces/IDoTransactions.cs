using System;
using Traderok.Domain.Core;

namespace Traderok
{
    public interface IRefillDeposit : IEntity, IPaymentMethod //Транзакция
    {
        DateTime DateTransaction { get; set; } //Дата транзакции
        double SumTransaction { get; set; } //Сумма транзакции
    }
}