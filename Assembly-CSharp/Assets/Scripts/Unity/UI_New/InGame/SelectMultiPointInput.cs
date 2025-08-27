namespace Assets.Scripts.Unity.UI_New.InGame;

public class SelectMultiPointInput : CustomInput
{
	protected TargetType type; //Field offset: 0x28
	protected SelectTargetCIData cii; //Field offset: 0x40
	protected List<Vector2> selectPoints; //Field offset: 0x48
	protected List<UnityDisplayNode> targetImages; //Field offset: 0x50
	protected int pointIndex; //Field offset: 0x58

	public SelectMultiPointInput() { }

	[CompilerGenerated]
	private void <CursorUp>b__11_0(UnityDisplayNode img) { }

	[CompilerGenerated]
	private void <EnterInputMode>b__8_0(UnityDisplayNode img) { }

	public virtual void CursorUp(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	public virtual void EnterInputMode() { }

	public virtual void ExitInputMode() { }

	public virtual string GetHelperMessage() { }

	public virtual void Init(TowerToSimulation tower, TargetType targetType = null, ObjectId towerBehaviorObjectId = null, string buttonId = null) { }

	public virtual void Init(AbilityToSimulation ability) { }

	public virtual void Update(Vector3 cursorPosUnityWorld, Vector2 cursorPosWorld, bool isCursorActive) { }

}

