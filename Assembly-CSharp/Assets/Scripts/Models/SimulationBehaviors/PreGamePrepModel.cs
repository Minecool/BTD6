namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(PreGamePrep), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PreGamePrepModel : SimulationBehaviorModel
{
	public ProjectileModel projectileModel; //Field offset: 0x30
	public float distFromEdgeOfMap; //Field offset: 0x38

	public PreGamePrepModel(string name, ProjectileModel projectileModel, float distFromEdgeOfMap) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

