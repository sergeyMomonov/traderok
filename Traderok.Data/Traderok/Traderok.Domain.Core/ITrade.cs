using System;

namespace Traderok.Domain.Core
{
    public enum Side
    {
        longSide,
        shortSide  
    };

    public interface ITrade //Поля для универсального трейда  
    {
        DateTime DateTrade { get; set; } //Дата и время трейда
        string Name { get; set; } //Название акции
        Side Side { get; } //Направление
        double Price { get; set; } //Цена входа/выхода
        int AmountShares { get; set; } //Количество акций
        double Commition { get; set; } //Коммиссия за трейд

    }
}