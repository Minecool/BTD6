namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class BrickellFreezeMinesAbilityBuff : AbilityBehavior
{
	public BrickellFreezeMinesAbilityBuffModel brickellFreezeMinesAbilityBuffModel; //Field offset: 0x68

	public BrickellFreezeMinesAbilityBuff() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

