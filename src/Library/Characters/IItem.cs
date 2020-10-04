namespace RoleplayGame
{   
    /*Llegamos a esta interfaz al boservar que todos los items compartían estas bases*/
    public interface IItem
    {
        int AttackValue { get; }
        int DefenseValue { get; }
    }
}