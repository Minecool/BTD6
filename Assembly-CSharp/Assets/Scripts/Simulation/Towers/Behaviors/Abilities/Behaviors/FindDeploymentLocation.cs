namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class FindDeploymentLocation : AbilityBehavior
{
	public FindDeploymentLocationModel deployModel; //Field offset: 0x68

	public FindDeploymentLocation() { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	private Vector3 FindValidLocation() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

