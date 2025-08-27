namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class CreateProjectileOnAbilityActivate : AbilityBehavior
{
	public CreateProjectileOnAbilityActivateModel createProjectileOnAbilityActivateModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70

	public CreateProjectileOnAbilityActivate() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

