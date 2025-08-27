namespace Assets.Scripts.Unity.UI_New.Odyssey.SubScripts;

public class OdysseySaveData : BaseSaveDataModel
{
	internal class AssetUsePerMap
	{
		public Int32[] countPerMap; //Field offset: 0x10

		public AssetUsePerMap() { }

		public int GetCountBasedOnMode(bool isExtreme) { }

		public int GetHighestCount() { }

		public int GetTotalCount() { }

	}

	[DataContract]
	internal class EmbarkedActiveOdyssey
	{
		[DataMember]
		public bool hasStarted; //Field offset: 0x10
		[DataMember]
		public int chosenDifficulty; //Field offset: 0x14
		[DataMember]
		public KonFuze livesRemaining; //Field offset: 0x18
		[DataMember]
		public bool isExtreme; //Field offset: 0x20
		[DataMember]
		public float timeTaken; //Field offset: 0x24
		[DataMember]
		public int popCount; //Field offset: 0x28
		[DataMember]
		public double cashGenerated; //Field offset: 0x30
		[DataMember]
		public int moabsPopped; //Field offset: 0x38
		[DataMember]
		public int abilitiesUsed; //Field offset: 0x3C
		[DataMember]
		public Dictionary<Int32, OdysseyMapData> odysseyMapDataHistory; //Field offset: 0x40
		[DataMember]
		public Dictionary<String, AssetUsePerMap> towersUseMapHistory; //Field offset: 0x48
		[DataMember]
		public Dictionary<String, AssetUsePerMap> powersUseMapHistory; //Field offset: 0x50
		[DataMember]
		public KonFuze canMoProblems; //Field offset: 0x58
		[DataMember]
		public int currentOdyseyMapSaveIndex; //Field offset: 0x60
		[DataMember]
		private MapSaveDataModel mapSave; //Field offset: 0x68

		public EmbarkedActiveOdyssey() { }

		public MapSaveDataModel GetMapSave(ChallengeType challengeType) { }

		public void SetMapSave(MapSaveDataModel mapSave, ChallengeType challengeType) { }

	}

	internal class OdysseyDifficultySaveData
	{
		public Dictionary<Int32, Boolean> mmRewardsEarnedForMap; //Field offset: 0x10
		public bool awardedRewards; //Field offset: 0x18
		public bool awardedTrophies; //Field offset: 0x19
		public bool replayingOdysseyEnabled; //Field offset: 0x1A
		public Dictionary<String, Int32> monkeysSelected; //Field offset: 0x20
		public Dictionary<String, Int32> powersSelected; //Field offset: 0x28
		public bool completedDifficulty; //Field offset: 0x30
		public EmbarkedActiveOdyssey odysseyCompletedSaveData; //Field offset: 0x38

		public OdysseyDifficultySaveData() { }

	}

	internal class OdysseyMapData
	{
		public bool hasSeenIslandTransition; //Field offset: 0x10
		public bool hasSeenMapCompletedEvent; //Field offset: 0x11
		public bool mapCompleted; //Field offset: 0x12
		public KonFuze livesHistory; //Field offset: 0x18

		public OdysseyMapData() { }

	}

	public EmbarkedActiveOdyssey activeOdysey; //Field offset: 0x28
	public Dictionary<Int32, OdysseyDifficultySaveData> difficultySaveData; //Field offset: 0x30
	public bool seenFirstTimePopup; //Field offset: 0x38
	public int embarkedOnAnOdyssey; //Field offset: 0x3C
	public DateTime startTime; //Field offset: 0x40
	public bool isInitialized; //Field offset: 0x48

	[JsonIgnore]
	public OdysseyDifficultySaveData ActiveDifficultySaveData
	{
		 get { } //Length: 139
	}

	[JsonConstructor]
	public OdysseySaveData() { }

	public OdysseySaveData(string id) { }

	public OdysseyDifficultySaveData get_ActiveDifficultySaveData() { }

}

