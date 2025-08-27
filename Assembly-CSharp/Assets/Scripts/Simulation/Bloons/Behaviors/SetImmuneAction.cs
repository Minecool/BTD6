namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class SetImmuneAction : BloonBehaviorAction
{
	public SetImmuneActionModel setImmuneAction; //Field offset: 0x78

	public SetImmuneAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	private void PlaySound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

