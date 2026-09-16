namespace Ucu.Poo.RoleplayGame;

public class Sword : IAttackItem
{
    public string Name { get; set; }
    public int AttackValue { get; set; }

    public void SetName(string name)
    {
        Name = name;
    }

    public void SetAttackValue(int attackValue)
    {
        AttackValue = attackValue;
    }
}
