namespace Assets.Scripts.Simulation.Track;

public class BossBloonManager
{
	private Int32[] spawnRounds; //Field offset: 0x10
	private Simulation sim; //Field offset: 0x18
	private Bloon currentBoss; //Field offset: 0x20
	private int currentBossTier; //Field offset: 0x28
	private KonFuze[] bossTimes; //Field offset: 0x30
	private KonFuze penaltyTime; //Field offset: 0x38
	private bool penaltyTimerOn; //Field offset: 0x40
	private int penaltyStartFrame; //Field offset: 0x44
	public bool checkForVictory; //Field offset: 0x48
	public bool defeatByRunningOutOfRounds; //Field offset: 0x49
	private int blockedRoundEnding; //Field offset: 0x4C
	private List<Ability> pausedAbilities; //Field offset: 0x50

	public Bloon CurrentBoss
	{
		 get { } //Length: 5
	}

	public int CurrentBossTier
	{
		 get { } //Length: 4
	}

	public bool IsBossTierForcefullyOverridden
	{
		 get { } //Length: 63
	}

	private float SpawnDistance
	{
		private get { } //Length: 63
	}

	public BossBloonManager() { }

	public bool AutoStartNextRound() { }

	private void BloonDestroyed(object obj) { }

	public void BloonLeaked(Bloon bloon) { }

	private void BloonStartedDeathAnim(Bloon bloon) { }

	public int DebugTriggerBossAbility(int abilityIndex) { }

	public Bloon get_CurrentBoss() { }

	public int get_CurrentBossTier() { }

	public bool get_IsBossTierForcefullyOverridden() { }

	private float get_SpawnDistance() { }

	public int GetBossMustBeDefeatedByRound() { }

	public TimeSpan GetBossTime() { }

	public TimeSpan GetBossTotalCompletionTime() { }

	public int GetForcedBossTierIndex() { }

	public int GetLastBossTierDefeated() { }

	public Nullable<Int32> GetNextBossSpawnRound() { }

	public TimeSpan GetPenaltyTime() { }

	public void GetSaveMetaData(Dictionary<String, String> metaData) { }

	private int GetTierFromCurrentRound() { }

	public void Init(Simulation sim) { }

	public void MatchReady() { }

	public void OnRoundEmissionEnd(int emissionEndRound) { }

	public void OnRoundEnd(int finishedRound) { }

	public void OnRoundStart(int spawnedRound) { }

	private void PauseCashAbilities() { }

	public void Process() { }

	private void RemoveDestroyedAbilities(RootObject ability) { }

	public void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void SpawnBoss(int tier, bool ignoreOnSpawnBehaviors = false) { }

	private void UnpauseCashAbilites() { }

}

