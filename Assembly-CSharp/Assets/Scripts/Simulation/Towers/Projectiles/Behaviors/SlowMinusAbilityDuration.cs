namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class SlowMinusAbilityDuration : Slow
{
	public SlowMinusAbilityDurationModel slowMinusAbilityDurationModel; //Field offset: 0x78
	private Ability ability; //Field offset: 0x80

	public SlowMinusAbilityDuration() { }

	public virtual int GetLifespanFrames() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

