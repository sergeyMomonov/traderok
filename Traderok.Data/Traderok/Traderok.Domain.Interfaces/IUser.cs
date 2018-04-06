using Traderok.Domain.Core;

namespace Traderok
{
    
    public enum UserType 
    {
        Client,
        Admin
    }
    
    public interface IUser : IEntity, IAccoutType
    {
        string Nik { get; set; } //Никнэйм
        double SumDeposit { get; set; } //Сумма на депозите
        string Email { get; set; } 
        string Password { get; set; }
        string AvatarURL { get; set; }
        string Broker { get; set; }
        
    }
}