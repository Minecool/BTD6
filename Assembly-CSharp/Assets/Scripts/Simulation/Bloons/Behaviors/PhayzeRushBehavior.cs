namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class PhayzeRushBehavior : BossRushBehavior
{
	public PhayzeRushBehaviorModel rushPhayzeModel; //Field offset: 0x80

	public PhayzeRushBehavior() { }

	public virtual RushBehaviorMutator GetMutator(int totalKills, int milestoneTierFrequency) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

