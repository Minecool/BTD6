namespace Assets.Scripts.Unity.UI_New.InGame;

public class BeastHandlerMergeInput : CustomInput
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public TowerToSimulation bridgeTower; //Field offset: 0x10
		public BeastHandlerMergeInput <>4__this; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal void <EnterInputMode>b__0(UnityDisplayNode img) { }

	}

	private AbilityToSimulation ability; //Field offset: 0x28
	private BeastHandlerCIData data; //Field offset: 0x30
	private Dictionary<TowerToSimulation, UnityDisplayNode> targetImages; //Field offset: 0x38

	public BeastHandlerMergeInput() { }

	public virtual void CursorUp(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	public virtual void EnterInputMode() { }

	public virtual void ExitInputMode() { }

	public virtual string GetCantActivateMessage() { }

	public virtual string GetHelperMessage() { }

	public virtual void Init(TowerToSimulation tower, TargetType targetType = null, ObjectId towerBehaviorObjectId = null, string buttonId = null) { }

	public virtual void Update(Vector3 cursorPosUnityWorld, Vector2 cursorPosWorld, bool isCursorActive) { }

}

