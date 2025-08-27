namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells;

public abstract class CorvusInstantSpell : CorvusSpell
{
	public float duration; //Field offset: 0x80
	public float cooldown; //Field offset: 0x84

	protected CorvusInstantSpell() { }

}

