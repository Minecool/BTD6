namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(PopsFiredBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PopsFiredBehaviorModel : ItemArtifactBehaviorModel
{
	[SerializeField]
	public string damageType; //Field offset: 0x30
	[ExtendedDrawer]
	[SerializeField]
	public ProjectileModel projectileModel; //Field offset: 0x38
	[ExtendedDrawer]
	[SerializeField]
	public EffectModel effectModel; //Field offset: 0x40

	public PopsFiredBehaviorModel(string name, string damageType, ProjectileModel projectileModel, EffectModel effectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

