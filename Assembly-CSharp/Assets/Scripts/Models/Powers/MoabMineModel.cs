namespace Assets.Scripts.Models.Powers;

[Implementation(typeof(MoabMine), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MoabMineModel : PowerBehaviorModel
{
	public ProjectileModel projectileModel; //Field offset: 0x30

	public MoabMineModel(string name, ProjectileModel projectileModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

