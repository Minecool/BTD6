namespace Assets.Scripts.Unity.UI_New.Main.MapSelect;

public class MapButton : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <TimedUnlock>d__39 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float unlockDelay; //Field offset: 0x20
		public Btd6Player player; //Field offset: 0x28
		public Animator medalAnimator; //Field offset: 0x30
		public string mapId; //Field offset: 0x38
		public string difficulty; //Field offset: 0x40
		public string mode; //Field offset: 0x48

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
		public <TimedUnlock>d__39(int <>1__state) { }

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

	internal sealed class MapUnlocked : MulticastDelegate
	{

		public MapUnlocked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(MapDetails button, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(MapDetails button) { }

	}

	private static readonly int BorderState; //Field offset: 0x0
	private const string kSpecialClicks = "SpecialClicks"; //Field offset: 0x0
	private static readonly int UnlockState0; //Field offset: 0x4
	private static readonly int UnlockState1; //Field offset: 0x8
	private static readonly int UnlockState2; //Field offset: 0xC
	private static readonly int UnlockState3; //Field offset: 0x10
	[SerializeField]
	private Image mapImage; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI mapName; //Field offset: 0x28
	[SerializeField]
	private Button button; //Field offset: 0x30
	[SerializeField]
	private Image mapBackground; //Field offset: 0x38
	[SerializeField]
	private SpriteReference basicBackground; //Field offset: 0x40
	[SerializeField]
	private SpriteReference bronzeBackground; //Field offset: 0x48
	[SerializeField]
	private SpriteReference silverBackground; //Field offset: 0x50
	[SerializeField]
	private SpriteReference goldBackground; //Field offset: 0x58
	[SerializeField]
	private SpriteReference blackBackground; //Field offset: 0x60
	[SerializeField]
	private GameObject[] newBanners; //Field offset: 0x68
	[SerializeField]
	private GameObject medals; //Field offset: 0x70
	[SerializeField]
	private GameObject chimpsGoldSparkles; //Field offset: 0x78
	[SerializeField]
	private GameObject chimpsHematiteSparkles; //Field offset: 0x80
	[SerializeField]
	private GameObject continueIcon; //Field offset: 0x88
	[SerializeField]
	private Animator animator; //Field offset: 0x90
	[SerializeField]
	private Animator borderAnimator; //Field offset: 0x98
	[SerializeField]
	private LinkFriendScoresPanel friendPanel; //Field offset: 0xA0
	[SerializeField]
	private GameObject bonusReward; //Field offset: 0xA8
	[SerializeField]
	private GameObject[] bonusRewardIcons; //Field offset: 0xB0
	[SerializeField]
	private GameObject goldenBloonVisual; //Field offset: 0xB8
	[SerializeField]
	private MonkeyTeamsIcon monkeyTeamsVisual; //Field offset: 0xC0
	private MapSelectScreen mapSelectScreen; //Field offset: 0xC8
	private bool savedData; //Field offset: 0xD0
	private string mapId; //Field offset: 0xD8
	private bool isLocked; //Field offset: 0xE0

	public bool Interactable
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	private static MapButton() { }

	public MapButton() { }

	public bool get_Interactable() { }

	public override void Init(string mapId, bool showGoldenBloon, bool showMonkeyTeams, String[] monkeyTeams, bool showCollectionEventBonus) { }

	public void OnClick() { }

	public void RefreshLockState() { }

	public void set_Interactable(bool value) { }

	private void SetMedal(Animator medalAnimator, string difficulty, string mode, float delay) { }

	public void SetNameAndSprite(string localizedMapName, SpriteReference sprite) { }

	private static void ShowMedal(Btd6Player player, Animator medalAnimator, string mapId, string difficulty, string mode) { }

	[IteratorStateMachine(typeof(<TimedUnlock>d__39))]
	private static IEnumerator TimedUnlock(Btd6Player player, Animator medalAnimator, string mapId, string difficulty, float unlockDelay, string mode) { }

	public bool TryUnlock(bool silent) { }

	private void UpdateCollectionEventBonusTheme(bool dontCheckMyOwnBonus) { }

}

