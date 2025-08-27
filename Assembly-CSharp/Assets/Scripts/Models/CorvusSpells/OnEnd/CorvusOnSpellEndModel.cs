namespace Assets.Scripts.Models.CorvusSpells.OnEnd;

public abstract class CorvusOnSpellEndModel : TowerBehaviorModel
{
	public CorvusSpellType spellType; //Field offset: 0x30

	public CorvusOnSpellEndModel(string name, CorvusSpellType spellType) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

