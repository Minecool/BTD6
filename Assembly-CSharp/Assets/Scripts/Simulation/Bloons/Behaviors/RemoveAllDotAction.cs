namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class RemoveAllDotAction : BloonBehaviorAction
{
	public RemoveAllDotActionModel removeAllDotModel; //Field offset: 0x78

	public RemoveAllDotAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	private void PlayEffect() { }

	private void RemoveDamageOverTime() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

