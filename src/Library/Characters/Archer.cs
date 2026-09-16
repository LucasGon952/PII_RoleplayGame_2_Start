namespace Ucu.Poo.RoleplayGame;

public class Archer : ICharacter
{
    private int health = 100;

    public List<IAttackItem> ItemsAtaque { get; } = new List<IAttackItem>();
    public List<IDefenseItem> ItemsDefensa { get; } = new List<IDefenseItem>();

    public void AgregarItemAtaque (IAttackItem item)
    {
        ItemsAtaque.Add(item);
    }

    public void QuitarAgregarItemAtaque (IAttackItem item)
    {
        ItemsAtaque.Add(item);
    }

    public void AgregarItemDefensa (IDefenseItem item)
    {
        ItemsDefensa.Add(item);
    }

    public void QuitarAgregarItemDefensa (IDefenseItem item)
    {
        ItemsDefensa.Add(item);
    }
    public Archer(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
    
    public Bow Bow { get; set; }

    public Helmet Helmet { get; set; }

    public int AttackValue
    {
        get
        {
            return Bow.AttackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return Helmet.DefenseValue;
        }
    }

    public int Health
    {
        get
        {
            return this.health;
        }
        public set
        {
            this.health = value < 0 ? 0 : value;
        }
    }

    public void ReceiveAttack(int power)
    {
        if (this.DefenseValue < power)
        {
            this.Health -= power - this.DefenseValue;
        }
    }

    public void Cure()
    {
        this.Health = 100;
    }
}
