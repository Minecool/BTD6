namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(PrinceOfDarknessEmission), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PrinceOfDarknessEmissionModel : EmissionModel
{
	public ProjectileModel alternateProjectile; //Field offset: 0x38
	public int maxPathRandomRange; //Field offset: 0x40
	public int minPiercePerBloon; //Field offset: 0x44
	public int maxPathOffset; //Field offset: 0x48

	public PrinceOfDarknessEmissionModel(string name, int minPiercePerBloon, int maxPathRandomRange, int maxPathOffset, ProjectileModel alternateProjectile, EmissionBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

