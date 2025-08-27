namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.OnEnd;

public abstract class CorvusOnSpellEnd : TowerBehavior
{
	public CorvusOnSpellEnd parent; //Field offset: 0x30
	public CorvusSpell corvusSpell; //Field offset: 0x38

	protected CorvusOnSpellEnd() { }

	public CorvusSpellType GetSpellType() { }

}

