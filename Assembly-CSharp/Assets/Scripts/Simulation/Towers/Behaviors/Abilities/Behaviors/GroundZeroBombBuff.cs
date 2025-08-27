namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class GroundZeroBombBuff : AbilityBehavior
{
	public GroundZeroBombBuffModel groundZeroBombBuff; //Field offset: 0x68

	public GroundZeroBombBuff() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

