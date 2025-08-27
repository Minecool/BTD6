namespace Assets.Scripts.Models.Powers;

[Implementation(typeof(Thrive), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ThriveModel : PowerBehaviorModel
{
	public float cashScale; //Field offset: 0x30
	public IncreaseBloonWorthSimBehaviorModel increaseBloonWorthSimBehaviorModel; //Field offset: 0x38

	public ThriveModel(string name, float cashScale, IncreaseBloonWorthSimBehaviorModel increaseBloonWorthSimBehaviorModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

