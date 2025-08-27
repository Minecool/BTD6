namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class RogueGameManager : SimulationBehavior
{
	public RogueGameManagerModel rogueGameManagerModel; //Field offset: 0x58
	[CompilerGenerated]
	private bool <VictoryConditionsMet>k__BackingField; //Field offset: 0x60
	public Bloon currentTarget; //Field offset: 0x68

	protected bool IsFirstRound
	{
		 get { } //Length: 75
	}

	public bool VictoryConditionsMet
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RogueGameManager() { }

	protected bool get_IsFirstRound() { }

	[CompilerGenerated]
	public bool get_VictoryConditionsMet() { }

	private string GetBossName() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	public virtual void OnRoundStart(int roundArrayIndex) { }

	protected void OnTargetBloonLeaked(Bloon bloon) { }

	protected void OnTargetDestroyEvent(RootObject obj) { }

	[CompilerGenerated]
	public void set_VictoryConditionsMet(bool value) { }

	private void SpawnTargetBloon() { }

	private void TriggerDefeat() { }

	private void TriggerVictory() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

