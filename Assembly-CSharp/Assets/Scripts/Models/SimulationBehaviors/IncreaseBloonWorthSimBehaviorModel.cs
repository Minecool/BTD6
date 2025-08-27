namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(IncreaseBloonWorthSimBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class IncreaseBloonWorthSimBehaviorModel : SimulationBehaviorModel
{
	public float cashScale; //Field offset: 0x30
	public bool isUnique; //Field offset: 0x34

	public IncreaseBloonWorthSimBehaviorModel(string name, float cashScale, bool isUnique) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

