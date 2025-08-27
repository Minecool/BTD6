namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class BlastapopoulosRushBehavior : BossRushBehavior
{
	public BlastapopoulosRushBehaviorModel rushBlastModel; //Field offset: 0x80

	public BlastapopoulosRushBehavior() { }

	public virtual RushBehaviorMutator GetMutator(int totalKills, int milestoneTierFrequency) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

