public interface ICharacter
{
    public string Name {get; set;}
    public int AttackValue {get;set;}
    public int DefenseValue{get; set;}
    public int Health {get; set;}

    private List<IItem>



    public void GetName(string name)
    {
        this.Name = name;
    }

    public void ReceiveAttack(int power)
    {
        this.Health -= power - this.DefenseValue;
    }


}