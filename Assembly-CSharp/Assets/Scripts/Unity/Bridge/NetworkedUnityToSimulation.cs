namespace Assets.Scripts.Unity.Bridge;

public class NetworkedUnityToSimulation : UnityToSimulation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public DesyncCheck theirs; //Field offset: 0x10

		public <>c__DisplayClass53_0() { }

		internal bool <CheckForDesync>b__0(DesyncCheck dc) { }

	}

	[CompilerGenerated]
	private struct <CheckForHackers>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public NetworkedUnityToSimulation <>4__this; //Field offset: 0x28
		private bool <anyPlayerIsHacker>5__2; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class BeforeExecuteContinueFromCheckpoint : MulticastDelegate
	{

		public BeforeExecuteContinueFromCheckpoint(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public static TimeSpan bluePopupTimeAtLoad; //Field offset: 0x0
	public static TimeSpan bluePopupTimeInGame; //Field offset: 0x8
	public static TimeSpan hackerCheckInterval; //Field offset: 0x10
	private static readonly Comparison<GameplayAction> actionComparer; //Field offset: 0x18
	private int syncCheckStepInterval; //Field offset: 0x80
	private readonly Peer self; //Field offset: 0x88
	private readonly Btd6CoopGame connection; //Field offset: 0x90
	private readonly Peers peers; //Field offset: 0x98
	private DateTime timeToDropBluePopupTime; //Field offset: 0xA0
	private List<DesyncCheck> desyncChecks; //Field offset: 0xA8
	private double timeSinceLastSignoff; //Field offset: 0xB0
	private bool allowContinueOrRestart; //Field offset: 0xB8
	private bool allowFreeplay; //Field offset: 0xB9
	private bool requiresHackerCheck; //Field offset: 0xBA
	private double InputDelay; //Field offset: 0xC0
	private DateTime NextHackerCheckTime; //Field offset: 0xC8
	private float sumOfCashSent; //Field offset: 0xD0
	private int totalTimesCashSent; //Field offset: 0xD4
	private int totalTimesCashReceived; //Field offset: 0xD8
	private float sumOfCashReceieved; //Field offset: 0xDC
	private List<GameplayAction> actions; //Field offset: 0xE0

	private bool AnyPlayerIsOutOfSync
	{
		private get { } //Length: 384
	}

	private bool AnyPlayerIsRejoining
	{
		private get { } //Length: 384
	}

	public bool CanAutoResync
	{
		 get { } //Length: 3
	}

	private int InputDelayInSteps
	{
		private get { } //Length: 67
	}

	public bool IsRejoining
	{
		 get { } //Length: 30
	}

	private double SignoffPeriod
	{
		private get { } //Length: 9
	}

	private static NetworkedUnityToSimulation() { }

	public NetworkedUnityToSimulation(GameModel model, Btd6CoopGame gameConnection, bool isRejoining, bool requiresHackerCheck, bool isHeadless) { }

	protected virtual void AddAction(GameplayAction action) { }

	private void Broadcast(MessageCode code, T obj) { }

	private void CheckForDesync(DesyncCheck theirs, Peer peer) { }

	[AsyncStateMachine(typeof(<CheckForHackers>d__74))]
	private void CheckForHackers() { }

	private static int CompareActions(GameplayAction x, GameplayAction y) { }

	protected virtual void ContinueAction_Impl(int initiatingPlayerNumber) { }

	public virtual void ContinueFromCheckpoint(MapSaveDataModel mapSave, KonFuze mmCost, bool isRetryLastRound, bool forceMmPayment = false) { }

	public virtual void ContinueFromCheckpoint(string mapSaveId, KonFuze mmCost, bool isRetryLastRound, bool forceMmPayment = false) { }

	private void CoopShowPopUpForOtherPlayers(bool gameRestarted) { }

	public virtual void Destroy() { }

	protected virtual void EnterFreeplay_Impl(int initiatingPlayerNumber) { }

	protected virtual void ExecuteContinueFromCheckpoint(int initiatingPlayerNumber, KonFuze mmCost, ref MapSaveDataModel saveData, bool isRetryLastRound, bool forceMmPayment) { }

	public virtual void ExecuteRestart(int initiatingPlayerNumber) { }

	protected void ExecuteResync(MapSaveDataModel mapSave) { }

	private void FinishRejoining() { }

	private bool get_AnyPlayerIsOutOfSync() { }

	private bool get_AnyPlayerIsRejoining() { }

	public bool get_CanAutoResync() { }

	private int get_InputDelayInSteps() { }

	public bool get_IsRejoining() { }

	private double get_SignoffPeriod() { }

	public virtual List<AreaIndicator> GetCoopPlayerIndicators() { }

	public virtual int GetInputId() { }

	public bool GetInputManagerExistsForPlayerNumber(int playerId) { }

	private TimeSpan GetMaxLatency(IEnumerable<CoopPlayerInfo> connectedPlayers) { }

	private TimeSpan GetMaxLatencyVariance(IEnumerable<CoopPlayerInfo> connectedPlayers) { }

	public string GetMultiStats() { }

	public virtual string GetNamedMonkeyName(int playerId, string monkeyKey) { }

	private CoopPlayerInfo GetPlayer(int playerNumber, bool throwIfNone) { }

	private string GetPlayerHero(int playerNumber) { }

	public virtual Dictionary<Int32, String> GetPlayerHeroes() { }

	public void HackSetValidDCMHeroes(DailyChallengeModel dcm) { }

	public void InitAfterUISetup() { }

	public virtual void InitAnalytics() { }

	public virtual void Initialise(MapSaveDataModel mapSaveData = null) { }

	public virtual void InitMap(MapModel map) { }

	private bool IsPlayerGone(byte playerNumber) { }

	private void KillHackedGame() { }

	public virtual void LoadReplay(Replay replay) { }

	protected virtual void Lose() { }

	protected virtual void Lose_Impl() { }

	public void OnOtherPlayerLeft(byte playerNumber, string reason) { }

	private void OnOtherPlayerRejoined(byte playerNumber) { }

	protected virtual void OnSafeToResyncSim(int highestCompletedRound) { }

	private void OnYouDisconnected(string unknown) { }

	private void OnYouRejoined() { }

	protected virtual void PauseAutoplay_Impl(sbyte playerNumber, bool value) { }

	private void PeerAction(GameplayAction action) { }

	public void PerformContinueFromCheckpoint(int initiatingPlayerNumber, KonFuze mmCost, MapSaveDataModel saveData, byte newAuthority, bool isRetryLastRound) { }

	public void PerformRestart(int initiatingPlayerNumber, byte newAuthority) { }

	private void PerformResync(MapSaveDataModel save, bool isFastForwardActive, byte newAuthority) { }

	public virtual void Record(Replay replayRecorder = null) { }

	public void RecoveredFromDesync() { }

	protected virtual void RemovePeer_Impl(byte playerNumber) { }

	private void RemovePeerPermanently(byte playerNumber) { }

	public void RemovePlayer(byte playerNumber) { }

	protected virtual void RequestCash_Impl(int from) { }

	public virtual void Restart() { }

	private void Resync(int currRound) { }

	protected virtual void SelfAction(GameplayAction action) { }

	protected virtual void SendCash_Impl(int from, int to, double amount) { }

	protected virtual void SendEmote_Impl(int peerId, string emoteId) { }

	protected virtual void SetAutoplay_Impl(sbyte playerNumber, bool value) { }

	public virtual void SetBlockAutoPlay(bool value) { }

	protected virtual void SetFastForward_Impl(bool value) { }

	private void SetLongerBluePopupTime() { }

	private void SetShorterBluePopupTime() { }

	public virtual void Simulate() { }

	private int StepSignoff() { }

	private bool TryGetAlwaysAction(List<GameplayAction> actions, out GameplayAction alwaysAction) { }

	private bool TryGetPeerInGame(byte playerNumber, out Peer peer) { }

	public virtual void Update() { }

	private void UpdatePeerStates(UpdatePeerState updatePeerState) { }

	protected virtual void Win() { }

	protected virtual void Win_Impl() { }

}

