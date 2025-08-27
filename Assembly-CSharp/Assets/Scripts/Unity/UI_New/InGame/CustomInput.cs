namespace Assets.Scripts.Unity.UI_New.InGame;

public class CustomInput
{
	public TowerToSimulation tower; //Field offset: 0x10
	public ObjectId towerBehaviorObjectId; //Field offset: 0x18
	protected bool active; //Field offset: 0x1C
	public string buttonId; //Field offset: 0x20

	public CustomInput() { }

	public override void CursorDown(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	public override void CursorUp(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	public override void EnterInputMode() { }

	public override void ExitInputMode() { }

	public override string GetCantActivateMessage() { }

	public override string GetHelperMessage() { }

	public override string GetId() { }

	public override void Init(TowerToSimulation tower, TargetType targetType = null, ObjectId towerBehaviorObjectId = null, string buttonId = null) { }

	public override void Init(AbilityToSimulation ability) { }

	public override bool IsPositionValid(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	public override void OnInvalidPositionCursorUp(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	public override void OnValidPositionCursorUp(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	public override void Update(Vector3 cursorPosUnityWorld, Vector2 cursorPosWorld, bool isCursorActive) { }

}

