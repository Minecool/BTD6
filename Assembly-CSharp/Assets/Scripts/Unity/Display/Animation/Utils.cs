namespace Assets.Scripts.Unity.Display.Animation;

public static class Utils
{
	[CompilerGenerated]
	private sealed class <GetTowerProcessList>d__1 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IEnumerator<PrefabReference> <>7__wrap1; //Field offset: 0x28

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <GetTowerProcessList>d__1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetTowerProcessListPrefabs>d__2 : IEnumerable<PrefabReference>, IEnumerable, IEnumerator<PrefabReference>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private PrefabReference <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private GameModel <gameModel>5__2; //Field offset: 0x28
		private HashSet<PrefabReference> <uniqueprefabs>5__3; //Field offset: 0x30
		private TowerModel[] <>7__wrap3; //Field offset: 0x38
		private int <>7__wrap4; //Field offset: 0x40
		private TowerModel <tower>5__6; //Field offset: 0x48
		private IEnumerator<AirUnitModel> <>7__wrap6; //Field offset: 0x50
		private PowerModel[] <>7__wrap7; //Field offset: 0x58
		private GeraldoItemModel[] <>7__wrap8; //Field offset: 0x60

		private override PrefabReference System.Collections.Generic.IEnumerator<NinjaKiwi.Common.ResourceUtils.PrefabReference>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 69
		}

		[DebuggerHidden]
		public <GetTowerProcessListPrefabs>d__2(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<PrefabReference> System.Collections.Generic.IEnumerable<NinjaKiwi.Common.ResourceUtils.PrefabReference>.GetEnumerator() { }

		[DebuggerHidden]
		private override PrefabReference System.Collections.Generic.IEnumerator<NinjaKiwi.Common.ResourceUtils.PrefabReference>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	public static GameObject FindLodgroupRoot(GameObject start) { }

	public static List<String> GetAdditionalTowerPaths() { }

	public static string GetHeirarchyPathToGameObject(GameObject go) { }

	public static string GetMonkeyKeyFromAssetGuid(string guid) { }

	[IteratorStateMachine(typeof(<GetTowerProcessList>d__1))]
	public static IEnumerable<String> GetTowerProcessList() { }

	[IteratorStateMachine(typeof(<GetTowerProcessListPrefabs>d__2))]
	private static IEnumerable<PrefabReference> GetTowerProcessListPrefabs() { }

	public static bool IsInNoFlattenHeirarchy(GameObject go) { }

	public static bool IsUnique(PrefabReference item, HashSet<PrefabReference> hashset) { }

}

