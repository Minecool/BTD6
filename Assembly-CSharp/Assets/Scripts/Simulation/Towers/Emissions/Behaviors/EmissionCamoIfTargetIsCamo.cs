namespace Assets.Scripts.Simulation.Towers.Emissions.Behaviors;

internal class EmissionCamoIfTargetIsCamo : EmissionBehavior
{
	public EmissionCamoIfTargetIsCamoModel modl; //Field offset: 0x68
	private ProjectileModel premadeClone; //Field offset: 0x70

	public EmissionCamoIfTargetIsCamo() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual ProjectileModel ProjectileModelMod(ProjectileModel def, Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

