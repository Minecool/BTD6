namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class CreateEffectAction : BloonBehaviorAction
{
	public CreateEffectActionModel modl; //Field offset: 0x78

	public CreateEffectAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

