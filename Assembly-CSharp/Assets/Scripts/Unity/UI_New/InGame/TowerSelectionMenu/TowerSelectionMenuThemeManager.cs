namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class TowerSelectionMenuThemeManager : MenuThemeManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public string themeToSet; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal bool <UpdateThemeAsync>b__0(BaseTSMTheme theme) { }

	}

	[CompilerGenerated]
	private sealed class <UpdateThemeAsync>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Selectable selectable; //Field offset: 0x20
		public TowerSelectionMenuThemeManager <>4__this; //Field offset: 0x28
		private <>c__DisplayClass1_0 <>8__1; //Field offset: 0x30
		private TowerToSimulation <tower>5__2; //Field offset: 0x38

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
		public <UpdateThemeAsync>d__1(int <>1__state) { }

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


	public TowerSelectionMenuThemeManager() { }

	public virtual void InfoChanged(Selectable selectable) { }

	public virtual void OnButtonPress(TSMButton button) { }

	protected virtual string ThemeForEntity(IPlaceableEntity entity) { }

	public virtual void UpdateFromSimInfo(Selectable selectable, Dictionary<String, TSMInfoModel> objects) { }

	public void UpdateMonkeyName(TowerToSimulation tower) { }

	[IteratorStateMachine(typeof(<UpdateThemeAsync>d__1))]
	public virtual IEnumerator UpdateThemeAsync(Selectable selectable) { }

}

