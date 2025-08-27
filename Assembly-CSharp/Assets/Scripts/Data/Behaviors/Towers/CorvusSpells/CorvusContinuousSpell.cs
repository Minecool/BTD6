namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells;

public abstract class CorvusContinuousSpell : CorvusSpell
{
	public int ongoingManaCost; //Field offset: 0x80
	public float manaDrainInterval; //Field offset: 0x84

	protected CorvusContinuousSpell() { }

}

