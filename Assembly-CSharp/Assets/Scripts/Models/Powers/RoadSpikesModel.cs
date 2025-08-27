namespace Assets.Scripts.Models.Powers;

[Implementation(typeof(RoadSpikes), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RoadSpikesModel : PowerBehaviorModel
{
	public ProjectileModel projectileModel; //Field offset: 0x30

	public RoadSpikesModel(string name, ProjectileModel projectileModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

