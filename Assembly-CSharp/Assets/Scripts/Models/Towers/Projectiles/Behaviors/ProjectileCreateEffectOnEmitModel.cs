namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(ProjectileCreateEffectOnEmit), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ProjectileCreateEffectOnEmitModel : ProjectileBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x38

	public ProjectileCreateEffectOnEmitModel(string name, EffectModel effectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

