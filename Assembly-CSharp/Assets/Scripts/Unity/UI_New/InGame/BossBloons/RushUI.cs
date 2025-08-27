namespace Assets.Scripts.Unity.UI_New.InGame.BossBloons;

public class RushUI : BossUI
{
	[CompilerGenerated]
	private sealed class <Initialise>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RushUI <>4__this; //Field offset: 0x20

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
		public <Initialise>d__9(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <InitialiseNonBossUI>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RushUI <>4__this; //Field offset: 0x20

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
		public <InitialiseNonBossUI>d__12(int <>1__state) { }

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

	public Image standardImg; //Field offset: 0x1C8
	public NK_TextMeshProUGUI killCounterTxt; //Field offset: 0x1D0
	public GameObject killCounter; //Field offset: 0x1D8

	protected virtual Bloon TargetBloon
	{
		 get { } //Length: 35
	}

	protected virtual Nullable<Int32> TargetBloonTier
	{
		 get { } //Length: 73
	}

	protected virtual BloonToSimulation TargetBloonTTS
	{
		 get { } //Length: 35
	}

	public RushUI() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerator <>n__0() { }

	private void AddListeners() { }

	public virtual void Destroy() { }

	protected virtual Bloon get_TargetBloon() { }

	protected virtual Nullable<Int32> get_TargetBloonTier() { }

	protected virtual BloonToSimulation get_TargetBloonTTS() { }

	public static TrophyStoreItem GetBloonTrophyStoreItemByCosmeticId(string assetChangeId) { }

	[IteratorStateMachine(typeof(<Initialise>d__9))]
	public virtual IEnumerator Initialise() { }

	[IteratorStateMachine(typeof(<InitialiseNonBossUI>d__12))]
	private IEnumerator InitialiseNonBossUI() { }

	public virtual void OnRestartGame() { }

	protected void OnUpdateRushKillCount(int killCount) { }

	private void SetupRushUI() { }

	protected virtual void ShowBossAliveUI() { }

	protected virtual void ShowInBetweenBossesUI() { }

	public virtual void StartMatch() { }

}

