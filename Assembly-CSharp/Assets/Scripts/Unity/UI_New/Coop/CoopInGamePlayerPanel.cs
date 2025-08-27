namespace Assets.Scripts.Unity.UI_New.Coop;

public class CoopInGamePlayerPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <WaitingForCashToSent>d__36 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float delay; //Field offset: 0x20
		public CoopInGamePlayerPanel <>4__this; //Field offset: 0x28

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
		public <WaitingForCashToSent>d__36(int <>1__state) { }

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

	private const int MIN_CASH_SENT_DIVIDER = 5; //Field offset: 0x0
	private const int MIN_CASH_TO_SEND = 100; //Field offset: 0x0
	public GameObject container; //Field offset: 0x20
	public Button removeButton; //Field offset: 0x28
	public Button giveCashButton; //Field offset: 0x30
	public NK_TextMeshProUGUI cashTxt; //Field offset: 0x38
	public NK_TextMeshProUGUI giveCashTxt; //Field offset: 0x40
	public Image notificationIcon; //Field offset: 0x48
	public Image playerNumberIcon; //Field offset: 0x50
	public NK_TextMeshProUGUI playerNameTxt; //Field offset: 0x58
	public GameObject disconnectedPanel; //Field offset: 0x60
	public GameObject coopActiveDetails; //Field offset: 0x68
	public Button muteEmotesButton; //Field offset: 0x70
	public GameObject muteEnabledState; //Field offset: 0x78
	public GameObject muteDisabledState; //Field offset: 0x80
	public GameObject monkeysRemainingObj; //Field offset: 0x88
	public NK_TextMeshProUGUI monkeysRemainingTxt; //Field offset: 0x90
	public GameObject isHostObj; //Field offset: 0x98
	public bool closeButtonTriggered; //Field offset: 0xA0
	public bool isDisabled; //Field offset: 0xA1
	public int playerId; //Field offset: 0xA4
	private KonFuze value; //Field offset: 0xA8
	private bool mutePlayer; //Field offset: 0xB0

	public CoopInGamePlayerPanel() { }

	public void DisableNotifications() { }

	public double GetCashTransferAmount() { }

	public void GiveCashClicked() { }

	public void Initialise(bool isDisabled, int playerId = -1, string playerName = "") { }

	public bool IsPlayerMuted() { }

	public void MuteButtonClicked() { }

	public void PlayerDisconnected() { }

	public void PlayerRejoined() { }

	public void PlayerRemoved() { }

	public void RecievedNotification() { }

	public void RemoveClicked() { }

	public void ShowHost(bool value) { }

	public void Update() { }

	[IteratorStateMachine(typeof(<WaitingForCashToSent>d__36))]
	private IEnumerator WaitingForCashToSent(float delay) { }

}

