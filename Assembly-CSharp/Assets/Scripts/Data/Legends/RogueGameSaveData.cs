namespace Assets.Scripts.Data.Legends;

public class RogueGameSaveData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ArtifactLoot, Boolean> <>9__3_0; //Field offset: 0x8
		public static Func<RogueInstaMonkey, Boolean> <>9__7_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <AddArtifactToInventory>b__3_0(ArtifactLoot x) { }

		internal bool <AddInstaToInventory>b__7_0(RogueInstaMonkey x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public ArtifactLoot artifact; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <AddArtifactToInventory>b__1(ArtifactLoot x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string artifactName; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <RemoveArtifactFromInventory>b__0(ArtifactLoot x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public string baseId; //Field offset: 0x10
		public int tier; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal bool <RemoveArtifactFromInventory>b__0(ArtifactLoot x) { }

	}

	internal sealed class ArtifactAddedToInventory : MulticastDelegate
	{

		public ArtifactAddedToInventory(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ArtifactLoot artifact, bool ignoreItemArtifact, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ArtifactLoot artifact, bool ignoreItemArtifact) { }

	}

	internal sealed class ArtifactRemovedFromInventory : MulticastDelegate
	{

		public ArtifactRemovedFromInventory(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ArtifactLoot artifact, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ArtifactLoot artifact) { }

	}

	public bool isInitialized; //Field offset: 0x10
	public List<RogueInstaMonkey> instasInventory; //Field offset: 0x18
	public List<ArtifactLoot> artifactsInventory; //Field offset: 0x20
	public int lootChoices; //Field offset: 0x28
	public int seed; //Field offset: 0x2C
	public int lives; //Field offset: 0x30
	public int maxLives; //Field offset: 0x34
	public int endOfGameRerolls; //Field offset: 0x38
	public int towerBans; //Field offset: 0x3C
	public bool isChimps; //Field offset: 0x40
	public int startingPowerUsed; //Field offset: 0x44
	public string currentMapName; //Field offset: 0x48
	public int xpEarned; //Field offset: 0x50
	public Dictionary<String, String> tileMetaData; //Field offset: 0x58
	public Dictionary<String, Int32> appliedRogueXpShopItems; //Field offset: 0x60
	public int queuedMonkeyMoneyReward; //Field offset: 0x68
	public int queuedRogueXpReward; //Field offset: 0x6C
	public RogueGameModifiers modifiers; //Field offset: 0x70
	public int unseenLivesLost; //Field offset: 0x78
	public RogueCampaignStats currentStageStats; //Field offset: 0x80
	public RogueCampaignStats totalCampaignStats; //Field offset: 0x88
	public List<String> towerTypesPlaced; //Field offset: 0x90
	public List<String> bannedTowerTypes; //Field offset: 0x98
	[HideInInspector]
	public int progress; //Field offset: 0xA0
	[HideInInspector]
	public int stage; //Field offset: 0xA4
	[HideInInspector]
	public List<Vector2Int> defeatedTiles; //Field offset: 0xA8
	[HideInInspector]
	public List<Vector2Int> claimedLootTiles; //Field offset: 0xB0
	[HideInInspector]
	public Nullable<Vector2Int> currentPosition; //Field offset: 0xB8
	[HideInInspector]
	public Nullable<Vector2Int> tileDefeatedBy; //Field offset: 0xC4
	[HideInInspector]
	public Nullable<Vector2Int> lastPlayedTile; //Field offset: 0xD0
	[HideInInspector]
	public string selectedHero; //Field offset: 0xE0
	[HideInInspector]
	public string selectedHeroSkin; //Field offset: 0xE8
	[HideInInspector]
	public RogueLootData rogueLootData; //Field offset: 0xF0

	public RogueGameSaveData() { }

	public void AddArtifactToInventory(ArtifactLoot artifact, bool allowStacking = false, bool ignoreItemArtifact = false) { }

	public void AddInstaToInventory(RogueInstaMonkey insta) { }

	public void RemoveArtifactFromInventory(string artifactName) { }

	public void RemoveArtifactFromInventory(string baseId, int tier) { }

	public void TrackBoostAdded(int tier) { }

}

