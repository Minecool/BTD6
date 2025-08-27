namespace Assets.Scripts.Unity.CorvusSpells.OnEnd;

public abstract class CorvusOnSpellEnd : TowerBehavior
{
	public CorvusSpell corvusSpell; //Field offset: 0x98
	public CorvusSpell expCorvusSpell; //Field offset: 0xA0

	protected CorvusOnSpellEnd() { }

	public CorvusSpellType GetSpellType() { }

}

