namespace Assets.Scripts.Models.Powers;

[Implementation(typeof(GlueTrap), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GlueTrapModel : PowerBehaviorModel
{
	public ProjectileModel projectileModel; //Field offset: 0x30

	public GlueTrapModel(string name, ProjectileModel projectileModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

