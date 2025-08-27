namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class IncreaseRange : AbilityBehavior
{
	public IncreaseRangeModel increaseRangeModel; //Field offset: 0x68

	public IncreaseRange() { }

	public virtual void Activate() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void OnDefeatScreen() { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

