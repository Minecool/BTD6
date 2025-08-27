namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class DreadbloonRushBehavior : BossRushBehavior
{
	public DreadbloonRushBehaviorModel rushDreadbloonModel; //Field offset: 0x80
	private int bloonsToSpawn; //Field offset: 0x88
	private int lastRockSpawnTime; //Field offset: 0x8C

	public DreadbloonRushBehavior() { }

	public virtual RushBehaviorMutator GetMutator(int totalKills, int milestoneTierFrequency) { }

	private string GetRockBloonName() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnKillActions() { }

	protected virtual void OnMilestoneActions() { }

	private void Process(int elapsed) { }

	private void SpawnRockBloon() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

