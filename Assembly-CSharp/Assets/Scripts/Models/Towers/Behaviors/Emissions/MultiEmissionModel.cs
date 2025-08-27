namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(MultiEmission), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MultiEmissionModel : EmissionModel
{
	public ProjectileModel secondaryProjectileModel; //Field offset: 0x38

	public MultiEmissionModel(string name, ProjectileModel secondaryProjectileModel, EmissionBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

