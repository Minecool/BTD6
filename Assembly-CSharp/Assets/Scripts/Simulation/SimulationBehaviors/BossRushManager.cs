namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class BossRushManager : RushChallengeManager
{
	public BossRushManagerModel bossRushManagerModel; //Field offset: 0x88
	private bool reviveEventOn; //Field offset: 0x90
	private float previousHeatPercent; //Field offset: 0x94
	private bool previousHeatEffectActive; //Field offset: 0x98
	private bool previousHeatInCooldown; //Field offset: 0x99
	private int previousHeatlastAddedHeatAt; //Field offset: 0x9C

	public BossRushManager() { }

	[CompilerGenerated]
	private bool <GetTrackLengthBasedBloonSpeed>b__22_0(Path x) { }

	private void EndReviveEvent() { }

	public int GetCurrentMilestone() { }

	private string GetTargetName() { }

	private float GetTrackLengthBasedBloonSpeed(BloonModel bossModel, float multiplier) { }

	private void GiveCashReward() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsMilestoneRound() { }

	public bool IsPreMilestoneRound() { }

	protected virtual void OnDestroy() { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public void OnReviveUsed() { }

	protected virtual void OnTargetBloonLeaked(Bloon bloon) { }

	protected virtual void OnTargetDestroyEvent(RootObject obj) { }

	public void OnTargetKilled() { }

	protected virtual void SpawnTargetBloon(bool leakedRespawn = false, int previousTargetHealth = 0) { }

	private void TriggerVictory() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

