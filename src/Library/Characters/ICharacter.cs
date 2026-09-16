public interface ICharacter
{
    string Name { get; set; }

    public int AttackValue {get;}
    public int DefenseValue{get;}
    int Health { get; set;}

    List<IAttackItem> ItemsAtaque{get;}
    List<IDefenseItem> ItemsDefensa{get;}

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

    public void ReceiveAttack(int power)
    {
        Health -= power - this.DefenseValue;
    }

     public void Cura(int cura)
    {
        Health = 100;
    }


}