namespace Assets.Scripts.Models;

public static class CosmeticHelper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TrophyStoreItem, Single> <>9__9_0; //Field offset: 0x8
		public static Func<Model, Boolean> <>9__37_0; //Field offset: 0x10
		public static Func<Model, Boolean> <>9__42_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <ApplyAssetChangesToPowerModel>b__42_0(Model o) { }

		internal bool <ApplyAssetChangesToPowerProjectileModel>b__37_0(Model o) { }

		internal float <InternalGatherCosmetics>b__9_0(TrophyStoreItem o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public int inputId; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal bool <RemoveCosmeticsForCoopPlayer>b__0(int i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public TowerModel towerModel; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal bool <ApplyCoopPlayerCosmeticsToTowerModel>b__0(PowerModel x) { }

		internal bool <ApplyCoopPlayerCosmeticsToTowerModel>b__1(TowerModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public PowerModel powerModel; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal bool <ApplyCoopPlayerCosmeticsToPowerModel>b__0(PowerModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public BloonCosmeticData bd; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal bool <ApplyCosmeticsToBloonModels>b__0(BloonDecalSwap o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public string heroId; //Field offset: 0x10

		public <>c__DisplayClass44_0() { }

		internal bool <GetHeroEmote>b__0(TowerModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public PrefabReference reference; //Field offset: 0x10

		public <>c__DisplayClass45_0() { }

		internal bool <SwapDarkTempleAsset>b__0(PrefabSwap swap) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public SpriteReference reference; //Field offset: 0x10

		public <>c__DisplayClass46_0() { }

		internal bool <SwapDarkTempleAsset>b__0(SpriteSwap swap) { }

	}

	[CompilerGenerated]
	private struct <LoadSkins>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable<PlayerCosmeticInfo> playerCosmeticInfos; //Field offset: 0x20
		private IEnumerator<PlayerCosmeticInfo> <>7__wrap1; //Field offset: 0x28
		private List<AsyncOperationHandle`1<GameObject>> <skinHandles>5__3; //Field offset: 0x30
		private IEnumerator<SwapProjectileSpriteGroup> <>7__wrap3; //Field offset: 0x38
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct BloonCosmeticData
	{
		public BloonModel bloonModel; //Field offset: 0x0
		public string cosmeticId; //Field offset: 0x8

	}

	private class PlayerBloonMods
	{
		public Dictionary<String, BloonCosmeticData> bloonsByName; //Field offset: 0x10

		public PlayerBloonMods() { }

	}

	public static int ownPlayerId; //Field offset: 0x0
	private static Dictionary<Int32, PlayerCosmeticInfo> coopPlayerCosmetics; //Field offset: 0x8
	private static Dictionary<Int32, PlayerBloonMods> coopPlayerBloonMods; //Field offset: 0x10
	private static List<Int32> coopPlayerIndices; //Field offset: 0x18
	private static GameModel rootGameModel; //Field offset: 0x20
	private static TowerModel[] orgTowerModels; //Field offset: 0x28
	private static PowerModel[] orgPowerModels; //Field offset: 0x30
	[CompilerGenerated]
	private static readonly Dictionary<String, List`1<AsyncOperationHandle`1<GameObject>>> <GeraldoSpikeCosmeticHandles>k__BackingField; //Field offset: 0x38

	public static Dictionary<String, List`1<AsyncOperationHandle`1<GameObject>>> GeraldoSpikeCosmeticHandles
	{
		[CompilerGenerated]
		 get { } //Length: 79
	}

	private static CosmeticHelper() { }

	private static void AddBloonAssetChange(PlayerCosmeticInfo cosmetics, string id) { }

	private static void AddBloonDecal(PlayerCosmeticInfo cosmetics, string id) { }

	private static void AddBloonPopFX(PlayerCosmeticInfo cosmetics, string id) { }

	private static void AddPet(PlayerCosmeticInfo cosmetics, string id) { }

	private static void AddPowerAssetChange(PlayerCosmeticInfo cosmetics, string id) { }

	private static void AddProp(PlayerCosmeticInfo cosmetics, string id) { }

	private static void AddTowerAssetChange(PlayerCosmeticInfo cosmetics, string id) { }

	private static void ApplyAssetChangesToBloonModel(ref BloonCosmeticData bloonCosmeticData, BloonAssetChange bloonCosData) { }

	private static void ApplyAssetChangesToPowerModel(PowerModel pm, PowerAssetChange pac) { }

	public static ProjectileModel ApplyAssetChangesToPowerProjectileModel(ProjectileModel projectileModel, int inputId) { }

	private static void ApplyAssetChangesToPowerTowerModel(TowerModel towerModel, PowerAssetChange pac) { }

	private static void ApplyAssetChangesToProjectileModel(ProjectileModel projectileModel, List<PrefabSwap> prefabSwaps) { }

	private static void ApplyAssetChangesToTowerModel(GameModel rootGameModel, TowerModel tm, IEnumerable<String> assetChangeIds, bool loadedSave) { }

	public static GeraldoItemModel ApplyCoopPlayerCosmeticsToGeraldoItemModel(GeraldoItemModel geraldoItemModel, int inputId) { }

	public static PowerModel ApplyCoopPlayerCosmeticsToPowerModel(PowerModel powerModel, int inputId) { }

	public static TowerModel ApplyCoopPlayerCosmeticsToTowerModel(GameModel rootGameModel, TowerModel towerModel, int inputId, bool loadedSave) { }

	private static void ApplyCosmeticsToBloonModels(Dictionary<String, BloonCosmeticData> bloonsCosmeticData, PlayerCosmeticInfo data) { }

	public static void ApplyCosmeticsToGameModel(PlayerCosmeticInfo data, bool loadedSave) { }

	private static void ApplyCosmeticsToTowerModel(GameModel rootGameModel, TowerModel towerModel, PlayerCosmeticInfo data, bool loadedSave) { }

	private static void ApplyDecalToBloonModel(BloonModel bloonModel, BloonDecalSwap bloonDecal, int displayLayer) { }

	private static void ApplyPetToTowerModel(TowerModel tm, string id) { }

	private static void ApplyPopFXToBloonModel(BloonModel bloonModel, BloonPopFX bloonPopFXSwap) { }

	private static void ApplyPropsToTowerModel(TowerModel tm, IEnumerable<String> ids) { }

	private static void ApplyTowerSkinToTowerModel(GameModel rootGameModel, TowerModel towerModel, SkinData data) { }

	public static void CleanUp() { }

	public static void ClearCosmeticsForCoopPlayers() { }

	private static PlayerBloonMods CreateBloonModsForPlayer(int inputId) { }

	[CompilerGenerated]
	public static Dictionary<String, List`1<AsyncOperationHandle`1<GameObject>>> get_GeraldoSpikeCosmeticHandles() { }

	public static BloonCosmeticData GetBloonModel(string id, int emissionIndex, bool useRootModel = false) { }

	public static SkinData GetCosmeticsFromTowerModel(string towerBaseId, int inputId) { }

	public static SpriteReference GetHeroEmote(string heroId, string skinId, bool smallEmote) { }

	public static PlayerCosmeticInfo GetPlayerCosmetics(Dictionary<String, String> selectedTowerSkinData, IEnumerable<String> enabledTrophyStoreItems, IEnumerable<String> overriddenPlayerCosmetics = null, Nullable<Boolean> disablePlayerCosmetics = null, Dictionary<String, String> skinOverride = null) { }

	public static void Init(GameModel gameModel) { }

	private static PlayerCosmeticInfo InternalGatherCosmetics(PlayerCosmeticInfo cosmetics, IEnumerable<String> enabledStoreItems) { }

	[AsyncStateMachine(typeof(<LoadSkins>d__51))]
	public static Task LoadSkins(IEnumerable<PlayerCosmeticInfo> playerCosmeticInfos) { }

	public static void RefreshBloonModelsForAllPlayers() { }

	public static void RemoveCosmeticsForCoopPlayer(int inputId) { }

	public static void SetCosmeticsForCoopPlayer(int inputId, PlayerCosmeticInfo cosmetics) { }

	public static PrefabReference SwapDarkTempleAsset(PrefabReference reference) { }

	public static SpriteReference SwapDarkTempleAsset(SpriteReference reference) { }

	public static bool TryGetBloonModel(string id, int emissionIndex, out BloonCosmeticData bloonCosmeticData, bool useRootModel = false) { }

	public static void UnloadSkins() { }

}

