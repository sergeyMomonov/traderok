using System.Collections.Generic;
using Traderok.Domain.Core;

namespace Traderok
{
    public interface IAllUserTrade : IEntity
    {
        List<ITrade> Trades { get; set; }
    }
}