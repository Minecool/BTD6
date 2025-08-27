namespace Assets.Scripts.Unity.UI_New.InGame;

public class CoopAreaIndicators : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Vector2, Vector3> <>9__18_0; //Field offset: 0x8
		public static Func<Vector2, Vector3> <>9__18_3; //Field offset: 0x10
		public static Func<Vector3, Vector3> <>9__18_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal Vector3 <MakeMesh>b__18_0(Vector2 p) { }

		internal Vector3 <MakeMesh>b__18_2(Vector3 v) { }

		internal Vector3 <MakeMesh>b__18_3(Vector2 p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public AreaIndicator indicator; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <ShowPlayerIndicators>b__0(CoopPlayerInfo o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public Mesh mesh; //Field offset: 0x10
		public Func<Int32, Int32> <>9__1; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		internal int <MakeMesh>b__1(int t) { }

	}

	[CompilerGenerated]
	private sealed class <Initialise>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CoopAreaIndicators <>4__this; //Field offset: 0x20

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

	public List<Image> coopMarkers; //Field offset: 0x20
	public Mesh canPlaceAreaMesh; //Field offset: 0x28
	public Mesh cantPlaceAreaMesh; //Field offset: 0x30
	private bool meshesBuilt; //Field offset: 0x38
	[CompilerGenerated]
	private Btd6CoopGame <coopGame>k__BackingField; //Field offset: 0x40
	private bool isShowing; //Field offset: 0x48

	public private Btd6CoopGame coopGame
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public CoopAreaIndicators() { }

	private void AddListeners() { }

	public void BuildCoopMeshes() { }

	public void CoopAreaChanged(int playerNum) { }

	public virtual void Destroy() { }

	[CompilerGenerated]
	private Btd6CoopGame get_coopGame() { }

	public void HideCoopMarkers() { }

	public void HideOverlays() { }

	[IteratorStateMachine(typeof(<Initialise>d__9))]
	public virtual IEnumerator Initialise() { }

	private static void MakeMesh(Mesh mesh, List<Tuple`2<Polygon, Polygon[]>> polys) { }

	[CompilerGenerated]
	public void set_coopGame(Btd6CoopGame value) { }

	public void ShowOverlays(bool highlightPlayerArea = false) { }

	public void ShowPlayerIndicators() { }

}

