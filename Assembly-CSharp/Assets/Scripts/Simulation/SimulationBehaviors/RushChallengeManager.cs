namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class RushChallengeManager : SimulationBehavior
{
	internal class RushMetaData
	{
		public int TotalKills; //Field offset: 0x10
		public int NumLeaks; //Field offset: 0x14
		public float TotalDistanceTraveled; //Field offset: 0x18
		public int RoundsPassed; //Field offset: 0x1C
		public int CurrentTrackSegment; //Field offset: 0x20

		public RushMetaData() { }

	}

	public RushChallengeManagerModel behaviorModel; //Field offset: 0x58
	protected BloonCosmeticData targetBloonCosmeticData; //Field offset: 0x60
	protected Bloon currentTarget; //Field offset: 0x70
	protected RushMetaData data; //Field offset: 0x78
	[CompilerGenerated]
	private bool <VictoryConditionsMet>k__BackingField; //Field offset: 0x80

	protected bool IsFirstRound
	{
		 get { } //Length: 75
	}

	public Bloon TargetBloon
	{
		 get { } //Length: 5
	}

	public bool VictoryConditionsMet
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public RushChallengeManager() { }

	protected bool get_IsFirstRound() { }

	public Bloon get_TargetBloon() { }

	[CompilerGenerated]
	public bool get_VictoryConditionsMet() { }

	public RushMetaData GetData() { }

	protected override RushBloonMutator GetMutator() { }

	public string GetSaveMetaData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	public virtual void OnRoundStart(int roundArrayIndex) { }

	protected override void OnTargetBloonLeaked(Bloon bloon) { }

	protected override void OnTargetDestroyEvent(RootObject obj) { }

	[CompilerGenerated]
	public void set_VictoryConditionsMet(bool value) { }

	public void SetSaveMetaData(string metaData) { }

	public void SetTargetFromSave(Bloon bloon) { }

	protected override void SpawnTargetBloon(bool leakedRespawn = false, int previousTargetHealth = 0) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

