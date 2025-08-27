namespace Assets.Scripts.Models.Profile;

public class OnlineProfileModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<BaseSaveDataModel> <>9__39_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Validate>b__39_0(BaseSaveDataModel x) { }

	}

	[JsonConverter(typeof(VersionConverter))]
	public Version savedByGameVersion; //Field offset: 0x10
	public DateTime raceEventEntryTime; //Field offset: 0x18
	public string raceEventEntryID; //Field offset: 0x20
	public KonFuze raceFreeEntries; //Field offset: 0x28
	public string raceFreeId; //Field offset: 0x30
	public int raceEventAttempts; //Field offset: 0x38
	[Obsolete("Use Player.RacePassCount instead")]
	public KonFuze racesPass; //Field offset: 0x40
	public List<RaceEventData> racesData; //Field offset: 0x48
	public DateTime timeStamp; //Field offset: 0x50
	public KonFuze raceEventBestTime; //Field offset: 0x58
	public Dictionary<Int32, Single> bestRaceEventTimeRounds; //Field offset: 0x60
	public HashSet<String> followingPlayerIds; //Field offset: 0x68
	public Dictionary<ContentType, ContentTypeSaveData> contentBrowserData; //Field offset: 0x70
	public List<String> rankedBossEventIds; //Field offset: 0x78
	public Dictionary<String, Dictionary`2<Int32, HashSet`1<Int32>>> submittedBossGames; //Field offset: 0x80
	public List<CTEventData> ctEventData; //Field offset: 0x88
	public HashSet<String> teamsStoreSeen; //Field offset: 0x90
	public string teamsStoreSeenForGuildId; //Field offset: 0x98
	public Dictionary<Int32, KonFuze> ctLeaderboardBadges; //Field offset: 0xA0
	public Dictionary<Int32, KonFuze> ctGlobalLeaderboardBadges; //Field offset: 0xA8
	public HashSet<String> receivedGifts; //Field offset: 0xB0
	public List<AccoladeTransaction> purchasedAccolades; //Field offset: 0xB8
	[JsonProperty("seenAccTrsId")]
	public long latestSeenAccoladeTransactionId; //Field offset: 0xC0
	public List<BossRushSaveData> bossRushEventData; //Field offset: 0xC8
	public DateTime lastGuildJoinTime; //Field offset: 0xD0
	public HashSet<String> seenInboxMessageIds; //Field offset: 0xD8
	public Dictionary<String, SweepstakesWinnerMessage> sweepstakesWinnerMessages; //Field offset: 0xE0
	public HashSet<String> seenSweepstakesEvents; //Field offset: 0xE8
	public HashSet<String> participatedSweepstakesEvents; //Field offset: 0xF0
	public Dictionary<String, DateTime> lastReceivedPubsubChannelTimes; //Field offset: 0xF8
	[CompilerGenerated]
	private CTEventData <CurrentCTEventData>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private BossRushSaveData <CurrentBossRushEventData>k__BackingField; //Field offset: 0x108

	[JsonIgnore]
	public BossRushSaveData CurrentBossRushEventData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[JsonIgnore]
	public CTEventData CurrentCTEventData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public OnlineProfileModel() { }

	[CompilerGenerated]
	public BossRushSaveData get_CurrentBossRushEventData() { }

	[CompilerGenerated]
	public CTEventData get_CurrentCTEventData() { }

	public bool IsNewer(OnlineProfileModel other) { }

	[CompilerGenerated]
	public void set_CurrentBossRushEventData(BossRushSaveData value) { }

	[CompilerGenerated]
	public void set_CurrentCTEventData(CTEventData value) { }

	[OnDeserialized]
	public void Validate(StreamingContext context = null) { }

	public void Validate(Btd6Player player) { }

}

