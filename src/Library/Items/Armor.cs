namespace Ucu.Poo.RoleplayGame;

public class Armor : IDefenseItem
{
    public string Name { get; set;}
    public int DefenseValue {get; set;}

    public void SetName(string name)
    {
        Name = name;
    }
    public void SetDefenseValue(int defenseValue)
    {
        DefenseValue = defenseValue;
    }   
}
