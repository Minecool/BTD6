namespace Assets.Scripts.Unity.UI_New.InGame.Races;

public class BossUI : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <Initialise>d__71 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BossUI <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Initialise>d__71(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal struct SkullData
	{
		public GameObject skull; //Field offset: 0x0
		public Animator skullAnimator; //Field offset: 0x8
		public float percTrigger; //Field offset: 0x10
		public bool triggered; //Field offset: 0x14

	}

	protected const string kVisibleState = "VisibleState"; //Field offset: 0x0
	public Animator bossAnim; //Field offset: 0x20
	public Animator noBossAnim; //Field offset: 0x28
	public Animator victoryConditionsAnim; //Field offset: 0x30
	public Image bossImg; //Field offset: 0x38
	public Image[] stars; //Field offset: 0x40
	public Color starColorOn; //Field offset: 0x48
	public Color starColorOff; //Field offset: 0x58
	public Image hpBarImg; //Field offset: 0x68
	private GameObject armourBarContainer; //Field offset: 0x70
	private Image armourBarImg; //Field offset: 0x78
	private GameObject armourBarEdge; //Field offset: 0x80
	private int armourBarEdgeAnimationFrameCount; //Field offset: 0x88
	public GameObject bossImmunityObject; //Field offset: 0x90
	public Image bossImmunityIcon; //Field offset: 0x98
	public Sprite primaryImmunity; //Field offset: 0xA0
	public Sprite militaryImmunity; //Field offset: 0xA8
	public Sprite magicImmunity; //Field offset: 0xB0
	public Sprite supportImmunity; //Field offset: 0xB8
	public TMP_Text immunityTxt; //Field offset: 0xC0
	public Transform skullParent; //Field offset: 0xC8
	public GameObject skullPrefab; //Field offset: 0xD0
	public TMP_Text bossHealthTxt; //Field offset: 0xD8
	public GameObject bossTimerObj; //Field offset: 0xE0
	public TMP_Text bossTimerTxt; //Field offset: 0xE8
	public GameObject bossSmallTimerObj; //Field offset: 0xF0
	public TMP_Text bossTimerSmallTxt; //Field offset: 0xF8
	public GameObject leastTiersUsedObj; //Field offset: 0x100
	public TMP_Text leastTiersUsedTxt; //Field offset: 0x108
	public GameObject leastCashUsedObj; //Field offset: 0x110
	public TMP_Text leastCashUsedTxt; //Field offset: 0x118
	public GameObject noBossObj; //Field offset: 0x120
	public Image arriveBossImg; //Field offset: 0x128
	public TMP_Text bossArrivalTxt; //Field offset: 0x130
	public GameObject bossPenaltyTimerObj; //Field offset: 0x138
	public TMP_Text bossPenaltyTimerTxt; //Field offset: 0x140
	public Animator healthGainAnimator; //Field offset: 0x148
	public CTBossHud ctBossHud; //Field offset: 0x150
	public GameObject camoIcon; //Field offset: 0x158
	public BossArmourUI[] armourBars; //Field offset: 0x160
	private double previousHealthProportion; //Field offset: 0x168
	[SerializeField]
	private GameObject heatBar; //Field offset: 0x170
	[SerializeField]
	private Image heatBarImg; //Field offset: 0x178
	[SerializeField]
	private Animator heatBarAnim; //Field offset: 0x180
	[SerializeField]
	private BossLeaderboardScorePanel bossLeaderboardScorePanel; //Field offset: 0x188
	[SerializeField]
	private Animator bossLeaderboardScorePanelAnimator; //Field offset: 0x190
	protected List<SkullData> skullData; //Field offset: 0x198
	protected bool showingBossUI; //Field offset: 0x1A0
	protected bool showingNoBossUI; //Field offset: 0x1A1
	protected float lastArmourProportion; //Field offset: 0x1A4
	protected Nullable<Int32> armourBarEdgeAnimationCooldown; //Field offset: 0x1A8
	protected TowerSet currentImmunity; //Field offset: 0x1B0
	protected double currentHealthProportion; //Field offset: 0x1B8
	private bool isOverheatTriggered; //Field offset: 0x1C0

	public UnityToSimulation Bridge
	{
		 get { } //Length: 7
	}

	protected bool IsBossMode
	{
		 get { } //Length: 73
	}

	protected bool IsRogueMode
	{
		 get { } //Length: 147
	}

	protected bool IsRogueRushMode
	{
		 get { } //Length: 147
	}

	protected bool IsSandboxOrEditorMode
	{
		 get { } //Length: 170
	}

	protected override Bloon TargetBloon
	{
		 get { } //Length: 49
	}

	protected override Nullable<Int32> TargetBloonTier
	{
		 get { } //Length: 35
	}

	protected override BloonToSimulation TargetBloonTTS
	{
		 get { } //Length: 35
	}

	public BossUI() { }

	private void AddListeners() { }

	public void Awake() { }

	private void BossLeaderboardScoreReached(LeaderboardScoreData score, LeaderboardType leaderboardType, bool isNewBest) { }

	protected void BossUI_OnArmourAdded(Bloon obj) { }

	public UnityToSimulation get_Bridge() { }

	protected bool get_IsBossMode() { }

	protected bool get_IsRogueMode() { }

	protected bool get_IsRogueRushMode() { }

	protected bool get_IsSandboxOrEditorMode() { }

	protected override Bloon get_TargetBloon() { }

	protected override Nullable<Int32> get_TargetBloonTier() { }

	protected override BloonToSimulation get_TargetBloonTTS() { }

	protected void HideShowOnPlacement(bool hide) { }

	[IteratorStateMachine(typeof(<Initialise>d__71))]
	public virtual IEnumerator Initialise() { }

	private void OnDestroy() { }

	protected void OnRoundStarted(int round) { }

	protected void OnTargetHealed(int amount) { }

	public void SetArriveInTxt(int roundsToGo) { }

	protected void SetupArmourBars() { }

	protected override void ShowBossAliveUI() { }

	protected override void ShowInBetweenBossesUI() { }

	protected void ShowSkulls() { }

	public override void StartMatch() { }

	public void Update() { }

	protected void UpdateArmourUI() { }

	protected void UpdateHealthAndShield() { }

	private void UpdateHeat() { }

}

