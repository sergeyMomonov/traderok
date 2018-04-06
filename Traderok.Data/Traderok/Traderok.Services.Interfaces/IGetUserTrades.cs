using System;
using System.Collections.Generic;
using Traderok.Domain.Core;

namespace Traderok
{
    public interface IGetUserTrades: IEntity, ITrade //Получение трейдов пользователя за конкретную дату или диапазон времени, например за май
    {
        DateTime FromDate { get; set; } //Дата начала диапазона времени
        DateTime ToDate { get; set; } //Дата окончания диапазона времени

        List<ITrade> GetUserTrades();
    }
}