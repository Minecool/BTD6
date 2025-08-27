namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class AnimDamageState : BloonBehavior
{
	public AnimDamageStateModel modl; //Field offset: 0x70

	public AnimDamageState() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

