namespace Assets.Scripts.Utils.Messaging;

public static class BridgeMessagingDelegates
{
	internal sealed class BeforeExecuteContinueFromCheckpoint : MulticastDelegate
	{

		public BeforeExecuteContinueFromCheckpoint(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class GeraldoStockChanged : MulticastDelegate
	{

		public GeraldoStockChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class MaxGeraldoStock : MulticastDelegate
	{

		public MaxGeraldoStock(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int owner, bool fromTowerUpgrade, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int owner, bool fromTowerUpgrade) { }

	}

	internal sealed class OnAbilitiesChanged : MulticastDelegate
	{

		public OnAbilitiesChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnAbilitiesHighlightEvent : MulticastDelegate
	{

		public OnAbilitiesHighlightEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(String[] abilityIds, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(String[] abilityIds) { }

	}

	internal sealed class OnAddMapAssetEvents : MulticastDelegate
	{

		public OnAddMapAssetEvents(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool disableAmbientMapFx, PrefabReference[] fXPrefabs, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool disableAmbientMapFx, PrefabReference[] fXPrefabs) { }

	}

	internal sealed class OnAdoraDarkModeActivated : MulticastDelegate
	{

		public OnAdoraDarkModeActivated(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnAreasChangedRedrawMapEvent : MulticastDelegate
	{

		public OnAreasChangedRedrawMapEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(List<Area> enabledAreas, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(List<Area> enabledAreas) { }

	}

	internal sealed class OnBloonDegrade : MulticastDelegate
	{

		public OnBloonDegrade(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string bloonBaseId, TowerToSimulation bridgeTower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string bloonBaseId, TowerToSimulation bridgeTower) { }

	}

	internal sealed class OnBloonLeaked : MulticastDelegate
	{

		public OnBloonLeaked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string bloonBaseId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string bloonBaseId) { }

	}

	internal sealed class OnBloonSpawn : MulticastDelegate
	{

		public OnBloonSpawn(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string bloonBaseId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string bloonBaseId) { }

	}

	internal sealed class OnBossDefeatedEvent : MulticastDelegate
	{

		public OnBossDefeatedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int tier, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int tier) { }

	}

	internal sealed class OnBossHealed : MulticastDelegate
	{

		public OnBossHealed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int amount, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int amount) { }

	}

	internal sealed class OnBossRushDashEnd : MulticastDelegate
	{

		public OnBossRushDashEnd(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnBossRushDashEndPost : MulticastDelegate
	{

		public OnBossRushDashEndPost(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnBossSkull : MulticastDelegate
	{

		public OnBossSkull(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnBossSpawnedEvent : MulticastDelegate
	{

		public OnBossSpawnedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnCashChanged : MulticastDelegate
	{

		public OnCashChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnCashManagersChanged : MulticastDelegate
	{

		public OnCashManagersChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Dictionary<Int32, CashManager> cashManagers, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Dictionary<Int32, CashManager> cashManagers) { }

	}

	internal sealed class OnCloseScene : MulticastDelegate
	{

		public OnCloseScene(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string sceneName, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string sceneName) { }

	}

	internal sealed class OnCoopPlacementAreaChanged : MulticastDelegate
	{

		public OnCoopPlacementAreaChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int playerNum, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int playerNum) { }

	}

	internal sealed class OnCorvusSpellCast : MulticastDelegate
	{

		public OnCorvusSpellCast(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string spellId, bool turnOn, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string spellId, bool turnOn) { }

	}

	internal sealed class OnCreateHandDragObject : MulticastDelegate
	{

		public OnCreateHandDragObject(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CreateHandDragObjectActionModel model, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CreateHandDragObjectActionModel model) { }

	}

	internal sealed class OnCreatePlacementCircle : MulticastDelegate
	{

		public OnCreatePlacementCircle(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CreatePlacementCircleActionModel model, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CreatePlacementCircleActionModel model) { }

	}

	internal sealed class OnCurrentRoundIncreased : MulticastDelegate
	{

		public OnCurrentRoundIncreased(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int highestCompletedRound, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int highestCompletedRound) { }

	}

	internal sealed class OnCustomUIChanged : MulticastDelegate
	{

		public OnCustomUIChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TowerToSimulation bridgeTower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TowerToSimulation bridgeTower) { }

	}

	internal sealed class OnDialoguePopupClosed : MulticastDelegate
	{

		public OnDialoguePopupClosed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnEarlyRoundEnd : MulticastDelegate
	{

		public OnEarlyRoundEnd(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int round, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int round) { }

	}

	internal sealed class OnEmoteMessageReceived : MulticastDelegate
	{

		public OnEmoteMessageReceived(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int playerId, string emoteId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int playerId, string emoteId) { }

	}

	internal sealed class OnEndlessRoundsModeDetected : MulticastDelegate
	{

		public OnEndlessRoundsModeDetected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool showCurrentRoundNum, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool showCurrentRoundNum) { }

	}

	internal sealed class OnEventHookAnalyticEvent : MulticastDelegate
	{

		public OnEventHookAnalyticEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EventHookToSimulation eventHook, HookConditionModel condition, bool isStartHookCondition, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(EventHookToSimulation eventHook, HookConditionModel condition, bool isStartHookCondition) { }

	}

	internal sealed class OnFastTrackApplied : MulticastDelegate
	{

		public OnFastTrackApplied(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnForceSelectSelectable : MulticastDelegate
	{

		public OnForceSelectSelectable(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ISelectable selectedable, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ISelectable selectedable) { }

	}

	internal sealed class OnGameInitialised : MulticastDelegate
	{

		public OnGameInitialised(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool isRestart, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool isRestart) { }

	}

	internal sealed class OnGeraldoItemPurchased : MulticastDelegate
	{

		public OnGeraldoItemPurchased(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(GeraldoItemModel geraldoItemModel, Vector2 position, int inputId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(GeraldoItemModel geraldoItemModel, Vector2 position, int inputId) { }

	}

	internal sealed class OnGeraldoStockChanged : MulticastDelegate
	{

		public OnGeraldoStockChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnHealthChangedDelegate : MulticastDelegate
	{

		public OnHealthChangedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnInfinitHealthModeDetected : MulticastDelegate
	{

		public OnInfinitHealthModeDetected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnLateRoundEnd : MulticastDelegate
	{

		public OnLateRoundEnd(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int completedRound, int highestCompletedRound, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int completedRound, int highestCompletedRound) { }

	}

	internal sealed class OnLivesDrained : MulticastDelegate
	{

		public OnLivesDrained(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int amount, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int amount) { }

	}

	internal sealed class OnLivesGained : MulticastDelegate
	{

		public OnLivesGained(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int amount, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int amount) { }

	}

	internal sealed class OnLivesLost : MulticastDelegate
	{

		public OnLivesLost(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int amount, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int amount) { }

	}

	internal sealed class OnLoadFromCheckpoint : MulticastDelegate
	{

		public OnLoadFromCheckpoint(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnLockHeroPurchasesChanged : MulticastDelegate
	{

		public OnLockHeroPurchasesChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool value, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool value) { }

	}

	internal sealed class OnLockTowerPurchasesChanged : MulticastDelegate
	{

		public OnLockTowerPurchasesChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool value, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool value) { }

	}

	internal sealed class OnLost : MulticastDelegate
	{

		public OnLost(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnManageHudStateEnd : MulticastDelegate
	{

		public OnManageHudStateEnd(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EventHookToSimulation eventHook, HookCondition condition, object metaData, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(EventHookToSimulation eventHook, HookCondition condition, object metaData) { }

	}

	internal sealed class OnManageHudStateStart : MulticastDelegate
	{

		public OnManageHudStateStart(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EventHookToSimulation eventHook, HookCondition condition, object metaData, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(EventHookToSimulation eventHook, HookCondition condition, object metaData) { }

	}

	internal sealed class OnManageMainHudPanel : MulticastDelegate
	{

		public OnManageMainHudPanel(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ManageMainHudActionModel model, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ManageMainHudActionModel model) { }

	}

	internal sealed class OnManageShopPanel : MulticastDelegate
	{

		public OnManageShopPanel(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ManageShopPanelModel model, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ManageShopPanelModel model) { }

	}

	internal sealed class OnManageTowerHudPanel : MulticastDelegate
	{

		public OnManageTowerHudPanel(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ManageTowerUpgradesPanelActionModel model, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ManageTowerUpgradesPanelActionModel model) { }

	}

	internal sealed class OnMapCreated : MulticastDelegate
	{

		public OnMapCreated(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnMapLoadedWithActiveRegenRemovable : MulticastDelegate
	{

		public OnMapLoadedWithActiveRegenRemovable(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnMapPropActivated : MulticastDelegate
	{

		public OnMapPropActivated(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PropModel mapPropModel, float locationX, float locationY, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PropModel mapPropModel, float locationX, float locationY) { }

	}

	internal sealed class OnOpenedScene : MulticastDelegate
	{

		public OnOpenedScene(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string sceneName, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string sceneName) { }

	}

	internal sealed class OnOpenScene : MulticastDelegate
	{

		public OnOpenScene(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string sceneName, object metadata, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string sceneName, object metadata) { }

	}

	internal sealed class OnPlacementCircleInteraction : MulticastDelegate
	{

		public OnPlacementCircleInteraction(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Dictionary<String, Boolean> placementData, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Dictionary<String, Boolean> placementData) { }

	}

	internal sealed class OnPlayMovieClip : MulticastDelegate
	{

		public OnPlayMovieClip(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PlayMovieClipActionModel behaviorModel, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PlayMovieClipActionModel behaviorModel) { }

	}

	internal sealed class OnPostPropDestroyed : MulticastDelegate
	{

		public OnPostPropDestroyed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnPostTowerDestroyed : MulticastDelegate
	{

		public OnPostTowerDestroyed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnPowerActivated : MulticastDelegate
	{

		public OnPowerActivated(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PowerModel def, float locationX, float locationY, int inputId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PowerModel def, float locationX, float locationY, int inputId) { }

	}

	internal sealed class OnPrimeCustomAbilityInput : MulticastDelegate
	{

		public OnPrimeCustomAbilityInput(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AbilityToSimulation bridgeAbility, string classname, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(AbilityToSimulation bridgeAbility, string classname) { }

	}

	internal sealed class OnPropDestroyed : MulticastDelegate
	{

		public OnPropDestroyed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PropToSimulation bridgeProp, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PropToSimulation bridgeProp) { }

	}

	internal sealed class OnPropPlaced : MulticastDelegate
	{

		public OnPropPlaced(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PropToSimulation bridgeProp, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PropToSimulation bridgeProp) { }

	}

	internal sealed class OnPropSold : MulticastDelegate
	{

		public OnPropSold(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PropToSimulation bridgeProp, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PropToSimulation bridgeProp) { }

	}

	internal sealed class OnQuestTriggersActivated : MulticastDelegate
	{

		public OnQuestTriggersActivated(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(String[] triggers, int round, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(String[] triggers, int round = -1) { }

	}

	internal sealed class OnRaceEnduranceModeDetected : MulticastDelegate
	{

		public OnRaceEnduranceModeDetected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool enduranceMode, long data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool enduranceMode, long data) { }

	}

	internal sealed class OnReleaseTower : MulticastDelegate
	{

		public OnReleaseTower(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string towerName, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string towerName) { }

	}

	internal sealed class OnRemoveablePropsModified : MulticastDelegate
	{

		public OnRemoveablePropsModified(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnRemoveAllHandDragObject : MulticastDelegate
	{

		public OnRemoveAllHandDragObject(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnRemoveAllPlacementCircles : MulticastDelegate
	{

		public OnRemoveAllPlacementCircles(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnRemoveHandDragObject : MulticastDelegate
	{

		public OnRemoveHandDragObject(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string placementId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string placementId) { }

	}

	internal sealed class OnRemovePlacementCircle : MulticastDelegate
	{

		public OnRemovePlacementCircle(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string placementId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string placementId) { }

	}

	internal sealed class OnRerolledRogueLoot : MulticastDelegate
	{

		public OnRerolledRogueLoot(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RogueLootType type, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RogueLootType type) { }

	}

	internal sealed class OnRestart : MulticastDelegate
	{

		public OnRestart(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnRevivesChanged : MulticastDelegate
	{

		public OnRevivesChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int lives, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int lives) { }

	}

	internal sealed class OnReviveUsed : MulticastDelegate
	{

		public OnReviveUsed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnRogueBannedTower : MulticastDelegate
	{

		public OnRogueBannedTower(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RogueInstaMonkey tower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RogueInstaMonkey tower) { }

	}

	internal sealed class OnRogueBoostArtifactAdded : MulticastDelegate
	{

		public OnRogueBoostArtifactAdded(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnRogueBoostQueueChanged : MulticastDelegate
	{

		public OnRogueBoostQueueChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnRogueEnterMerchant : MulticastDelegate
	{

		public OnRogueEnterMerchant(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int currentTokens, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int currentTokens) { }

	}

	internal sealed class OnRogueInstaCooldownUpdated : MulticastDelegate
	{

		public OnRogueInstaCooldownUpdated(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnRogueLeaveMerchant : MulticastDelegate
	{

		public OnRogueLeaveMerchant(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ArtifactLoot[] artifactsBought, int tokensSpent, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ArtifactLoot[] artifactsBought, int tokensSpent) { }

	}

	internal sealed class OnRoundEnd : MulticastDelegate
	{

		public OnRoundEnd(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int round, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int round) { }

	}

	internal sealed class OnRoundStart : MulticastDelegate
	{

		public OnRoundStart(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int roundSpawned, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int roundSpawned) { }

	}

	internal sealed class OnSafeToResync : MulticastDelegate
	{

		public OnSafeToResync(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int highestCompletedRound, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int highestCompletedRound) { }

	}

	internal sealed class OnSandboxBloonsCleared : MulticastDelegate
	{

		public OnSandboxBloonsCleared(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnSendAnalyticEvent : MulticastDelegate
	{

		public OnSendAnalyticEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string analyticId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string analyticId) { }

	}

	internal sealed class OnSetHelperMessage : MulticastDelegate
	{

		public OnSetHelperMessage(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string message, float timeUntilClear, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string message, float timeUntilClear = 3) { }

	}

	internal sealed class OnShowGlowOnTowerButton : MulticastDelegate
	{

		public OnShowGlowOnTowerButton(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ShowGlowOnTowerButtonActionModel model, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ShowGlowOnTowerButtonActionModel model) { }

	}

	internal sealed class OnSimFrameEnd : MulticastDelegate
	{

		public OnSimFrameEnd(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnSimLoaded : MulticastDelegate
	{

		public OnSimLoaded(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnSimTriggeredDialogue : MulticastDelegate
	{

		public OnSimTriggeredDialogue(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(DialogueData dialogue, bool saveSeen, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(DialogueData dialogue, bool saveSeen) { }

	}

	internal sealed class OnSpecialUiEvent : MulticastDelegate
	{

		public OnSpecialUiEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string eventId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string eventId) { }

	}

	internal sealed class OnSpecialUIEvent : MulticastDelegate
	{

		public OnSpecialUIEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string eventId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string eventId) { }

	}

	internal sealed class OnStartRaceRound : MulticastDelegate
	{

		public OnStartRaceRound(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnSwitchMusicTrack : MulticastDelegate
	{

		public OnSwitchMusicTrack(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string musicId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string musicId) { }

	}

	internal sealed class OnTargetTypeChanged : MulticastDelegate
	{

		public OnTargetTypeChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TowerToSimulation bridgeTower, TargetType type, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TowerToSimulation bridgeTower, TargetType type) { }

	}

	internal sealed class OnThriveStatusChanged : MulticastDelegate
	{

		public OnThriveStatusChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool enabled, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool enabled) { }

	}

	internal sealed class OnTogglePopupHints : MulticastDelegate
	{

		public OnTogglePopupHints(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int hintIndex, ToggleModdifier showOrDismissHint, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int hintIndex, ToggleModdifier showOrDismissHint) { }

	}

	internal sealed class OnToggleUiVisibility : MulticastDelegate
	{

		public OnToggleUiVisibility(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool visible, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool visible) { }

	}

	internal sealed class OnTowerCreated : MulticastDelegate
	{

		public OnTowerCreated(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TowerToSimulation bridgeTower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TowerToSimulation bridgeTower) { }

	}

	internal sealed class OnTowerDestroyed : MulticastDelegate
	{

		public OnTowerDestroyed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TowerToSimulation bridgeTower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TowerToSimulation bridgeTower) { }

	}

	internal sealed class OnTowerInventoryChanged : MulticastDelegate
	{

		public OnTowerInventoryChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool fullRebuild, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool fullRebuild) { }

	}

	internal sealed class OnTowerRangeTransformed : MulticastDelegate
	{

		public OnTowerRangeTransformed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnTowerSelectionPanelForceUpdate : MulticastDelegate
	{

		public OnTowerSelectionPanelForceUpdate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnTowerSelectionPanelForceUpdateEvent : MulticastDelegate
	{

		public OnTowerSelectionPanelForceUpdateEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnTowerSold : MulticastDelegate
	{

		public OnTowerSold(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TowerToSimulation bridgeTower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TowerToSimulation bridgeTower) { }

	}

	internal sealed class OnTowersSuspended : MulticastDelegate
	{

		public OnTowersSuspended(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnTowersUnsuspended : MulticastDelegate
	{

		public OnTowersUnsuspended(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnTowerTransformed : MulticastDelegate
	{

		public OnTowerTransformed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TowerToSimulation bridgeTower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TowerToSimulation bridgeTower) { }

	}

	internal sealed class OnTowerUnlockGoalProgress : MulticastDelegate
	{

		public OnTowerUnlockGoalProgress(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int amount, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int amount) { }

	}

	internal sealed class OnTowerUpgraded : MulticastDelegate
	{

		public OnTowerUpgraded(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TowerToSimulation bridgeTower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TowerToSimulation bridgeTower) { }

	}

	internal sealed class OnTowerUpgradeUnlocked : MulticastDelegate
	{

		public OnTowerUpgradeUnlocked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TowerModel towerModel, UpgradeModel upgradeModel, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TowerModel towerModel, UpgradeModel upgradeModel) { }

	}

	internal sealed class OnTowerXpUpdated : MulticastDelegate
	{

		public OnTowerXpUpdated(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TowerToSimulation bridgeTower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TowerToSimulation bridgeTower) { }

	}

	internal sealed class OnTriggerDialogue : MulticastDelegate
	{

		public OnTriggerDialogue(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(String[] dialogueIds, int round, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(String[] dialogueIds, int round) { }

	}

	internal sealed class OnTriggerGameEditorWarningMessage : MulticastDelegate
	{

		public OnTriggerGameEditorWarningMessage(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string warningMessage, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string warningMessage) { }

	}

	internal sealed class OnUpdateCollectionBarHudEvent : MulticastDelegate
	{

		public OnUpdateCollectionBarHudEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int currAmount, int totalCount, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int currAmount, int totalCount) { }

	}

	internal sealed class OnUpdateCorvusUi : MulticastDelegate
	{

		public OnUpdateCorvusUi(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnUpdateRushKillCount : MulticastDelegate
	{

		public OnUpdateRushKillCount(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int killCount, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int killCount) { }

	}

	internal sealed class OnUpgradePricesChanged : MulticastDelegate
	{

		public OnUpgradePricesChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TowerToSimulation bridgeTower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TowerToSimulation bridgeTower) { }

	}

	internal sealed class OnWon : MulticastDelegate
	{

		public OnWon(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class ResetAllAbilityCooldowns : MulticastDelegate
	{

		public ResetAllAbilityCooldowns(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool includeOwnedByOtherClients, bool includeParagons, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool includeOwnedByOtherClients, bool includeParagons = true) { }

	}


}

