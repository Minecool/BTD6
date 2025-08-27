namespace Assets.Scripts.Unity.UI_New.InGame;

public class ParagonCarpetBombSelectMultiPoint : SelectMultiPointInput
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<UnityDisplayNode> <>9__6_0; //Field offset: 0x8
		public static Action<UnityDisplayNode> <>9__6_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <set_MinLengthReached>b__6_0(UnityDisplayNode x) { }

		internal void <set_MinLengthReached>b__6_1(UnityDisplayNode x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Vector3 dotPosition; //Field offset: 0x10
		public ParagonCarpetBombSelectMultiPoint <>4__this; //Field offset: 0x20

		public <>c__DisplayClass16_0() { }

		internal void <SpawnConnectingDots>b__0(UnityDisplayNode img) { }

	}

	private CarpetBombAbilityModel carpetBombModel; //Field offset: 0x60
	private List<UnityDisplayNode> lineGreenDotDisplays; //Field offset: 0x68
	private List<UnityDisplayNode> lineRedDotDisplays; //Field offset: 0x70
	private bool minLengthReached; //Field offset: 0x78

	private List<UnityDisplayNode> DotDisplays
	{
		private get { } //Length: 16
	}

	private bool MinLengthReached
	{
		private get { } //Length: 5
		private set { } //Length: 441
	}

	public ParagonCarpetBombSelectMultiPoint() { }

	[CompilerGenerated]
	private void <CursorUp>b__13_0(UnityDisplayNode img) { }

	public virtual void CursorUp(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	public virtual void ExitInputMode() { }

	private List<UnityDisplayNode> get_DotDisplays() { }

	private bool get_MinLengthReached() { }

	public virtual string GetId() { }

	public virtual void Init(TowerToSimulation tower, TargetType targetType = null, ObjectId towerBehaviorObjectId = null, string buttonId = null) { }

	public virtual void Init(AbilityToSimulation ability) { }

	private void RepositionConnectingDots(Vector3 cursorPosUnityWorld) { }

	private void set_MinLengthReached(bool value) { }

	private void SpawnConnectingDots(Vector3 cursorPosUnityWorld) { }

	public virtual void Update(Vector3 cursorPosUnityWorld, Vector2 cursorPosWorld, bool isCursorActive) { }

}

