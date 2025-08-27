namespace Assets.Scripts.Unity.UI_New.InGame;

public class RedeployInput : CustomInput
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<AreaType> <>9__10_0; //Field offset: 0x8
		public static Predicate<AreaType> <>9__10_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Update>b__10_0(AreaType o) { }

		internal bool <Update>b__10_1(AreaType o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public TowerToSimulation bridgeTower; //Field offset: 0x10
		public RedeployInput <>4__this; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <EnterInputMode>b__0(UnityDisplayNode img) { }

	}

	private AbilityToSimulation ability; //Field offset: 0x28
	private RedeployCIData data; //Field offset: 0x30
	private Dictionary<TowerToSimulation, UnityDisplayNode> targetImages; //Field offset: 0x38
	private TowerToSimulation selectedTower; //Field offset: 0x40
	private float distToInitiatePlacement; //Field offset: 0x48
	private bool enterPlacmentMode; //Field offset: 0x4C
	private Vector2 cursorDownLoc; //Field offset: 0x50

	public RedeployInput() { }

	public void CheckForSelectedTower(Vector2 cursorPosWorld) { }

	private void CleanUpImages() { }

	public virtual void CursorDown(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	public virtual void EnterInputMode() { }

	public virtual void ExitInputMode() { }

	public virtual string GetHelperMessage() { }

	public virtual void Init(AbilityToSimulation ability) { }

	private void TowerPlacementSuccess(Vector2 pos) { }

	public virtual void Update(Vector3 cursorPosUnityWorld, Vector2 cursorPosWorld, bool isCursorActive) { }

}

