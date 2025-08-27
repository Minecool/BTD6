namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class DetectCamoOnAbility : AbilityBehavior
{
	public DetectCamoOnAbilityModel detectCamoOnAbilityModel; //Field offset: 0x68
	public DetectCamoMutator mutator; //Field offset: 0x70

	public DetectCamoOnAbility() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

