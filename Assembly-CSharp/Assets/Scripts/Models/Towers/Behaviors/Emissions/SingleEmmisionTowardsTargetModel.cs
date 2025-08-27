namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(SingleEmmisionTowardsTarget), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SingleEmmisionTowardsTargetModel : EmissionModel
{
	public float offset; //Field offset: 0x38

	public SingleEmmisionTowardsTargetModel(string name, EmissionBehaviorModel[] behaviors, float offset) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

