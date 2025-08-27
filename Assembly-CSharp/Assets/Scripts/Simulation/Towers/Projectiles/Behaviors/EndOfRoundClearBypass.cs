namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class EndOfRoundClearBypass : ProjectileBehavior
{
	public EndOfRoundClearBypassModel endOfRoundClearBypassModel; //Field offset: 0x68

	public EndOfRoundClearBypass() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

