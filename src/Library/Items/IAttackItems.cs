using System.Dynamic;

public interface IAttackItem
{
    string Name {get; set;}
    int AttackValue {get; set;}

    void SetName(string name);
    void SetAttackValue(int attackValue);
}