namespace Assets.Scripts.Unity.UI_New.Main.PlayerInfo;

public class PlayerInfo : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <UpdatePlayerNameSoon>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PlayerInfo <>4__this; //Field offset: 0x20

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
		public <UpdatePlayerNameSoon>d__21(int <>1__state) { }

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

	public NK_TextMeshProUGUI level; //Field offset: 0x20
	public Image rankImg; //Field offset: 0x28
	public Sprite regularRankSprite; //Field offset: 0x30
	public Sprite veteranRankSprite; //Field offset: 0x38
	public Image barBorderImg; //Field offset: 0x40
	public Sprite regularBorderSprite; //Field offset: 0x48
	public Sprite veteranBorderSprite; //Field offset: 0x50
	public NK_TextMeshProUGUI xpInfo; //Field offset: 0x58
	public Image bar; //Field offset: 0x60
	public Sprite regularBarSprite; //Field offset: 0x68
	public Sprite veteranBarSprite; //Field offset: 0x70
	public NK_TextMeshProUGUI nameTxt; //Field offset: 0x78
	public Image avatar; //Field offset: 0x80
	public GameObject newGlow; //Field offset: 0x88
	public GameObject newDot; //Field offset: 0x90
	public Image avatarBanner; //Field offset: 0x98

	public PlayerInfo() { }

	private void LiNKAccountUpdated(LiNKAccount _) { }

	public void OnDisable() { }

	public void OnEnable() { }

	private void UpdateDisplay() { }

	[IteratorStateMachine(typeof(<UpdatePlayerNameSoon>d__21))]
	private IEnumerator UpdatePlayerNameSoon() { }

	public void UpdateProfileIcon() { }

}

