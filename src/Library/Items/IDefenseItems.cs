using System.Dynamic;

public interface IDefenseItem
{
    string Name {get; set;}
    int DefenseValue {get; set;}

    void SetName(string name);
    void SetDefenseValue(int DefenseValue);
}