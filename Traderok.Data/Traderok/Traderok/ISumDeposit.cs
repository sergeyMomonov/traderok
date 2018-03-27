namespace Traderok
{
    public interface ISumDeposit : IEntity, IDeposit //Сумма на депозите
    {
        double Sum { get; set; }
    }
}