namespace Traderok
{
    
    public enum UserType 
    {
        Client,
        Admin
    }
    
    public interface IUser : IEntity, ISumDeposit, IAccoutType
    {
        string Nik { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string AvatarURL { get; set; }
    }
}