namespace Assets.Scripts.Models.SimulationBehaviors;

public class TowerTierRestrictionModel : Model
{
	public string towerBaseId; //Field offset: 0x30
	public int path; //Field offset: 0x38
	public int tier; //Field offset: 0x3C
	public int maxCountModifier; //Field offset: 0x40

	public TowerTierRestrictionModel(string name, string towerBaseId, int path, int tier, int maxCountModifier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

