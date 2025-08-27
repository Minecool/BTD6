namespace Assets.Scripts.Unity.UI_New.InGame;

public class SelectPointInput : CustomInput
{
	private TargetType type; //Field offset: 0x28
	private SelectTargetCIData cii; //Field offset: 0x40
	private UnityDisplayNode targetImage; //Field offset: 0x48
	private UnityDisplayNode previousTargetImage; //Field offset: 0x50
	private UnityDisplayNode targetInvalidImage; //Field offset: 0x58

	public SelectPointInput() { }

	[CompilerGenerated]
	private void <EnterInputMode>b__8_0(UnityDisplayNode img) { }

	[CompilerGenerated]
	private void <EnterInputMode>b__8_1(UnityDisplayNode img) { }

	[CompilerGenerated]
	private void <EnterInputMode>b__8_2(UnityDisplayNode img) { }

	public virtual void EnterInputMode() { }

	public virtual void ExitInputMode() { }

	public virtual string GetHelperMessage() { }

	public virtual void Init(TowerToSimulation tower, TargetType targetType = null, ObjectId towerBehaviorObjectId = null, string buttonId = null) { }

	public virtual void Init(AbilityToSimulation ability) { }

	public virtual bool IsPositionValid(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	private bool IsSimTowerValid(Tower simTower, Vector2 cursorPosWorld) { }

	public virtual void OnInvalidPositionCursorUp(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	public virtual void OnValidPositionCursorUp(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	public virtual void Update(Vector3 cursorPosUnityWorld, Vector2 cursorPosWorld, bool isCursorActive) { }

}

