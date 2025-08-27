namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class ChangeProjectileDisplay : AbilityBehavior
{
	public ChangeProjectileDisplayModel changeProjectileDisplayModel; //Field offset: 0x68

	public ChangeProjectileDisplay() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

