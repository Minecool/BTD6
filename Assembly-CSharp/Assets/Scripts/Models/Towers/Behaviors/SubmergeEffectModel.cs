namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SubmergeEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SubmergeEffectModel : TowerBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x30
	public float baseTowerRange; //Field offset: 0x38
	public ProjectileModel projectileModel; //Field offset: 0x40
	public float displayRadius; //Field offset: 0x48

	public SubmergeEffectModel(string name, EffectModel effectModel, float baseTowerRange, ProjectileModel projectileModel, float displayRadius) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

