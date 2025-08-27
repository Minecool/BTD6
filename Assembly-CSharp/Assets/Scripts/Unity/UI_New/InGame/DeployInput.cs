namespace Assets.Scripts.Unity.UI_New.InGame;

public class DeployInput : CustomInput
{
	private AbilityToSimulation ability; //Field offset: 0x28
	private DeployCIData data; //Field offset: 0x30
	private bool enterPlacement; //Field offset: 0x38

	public DeployInput() { }

	public virtual void EnterInputMode() { }

	public virtual string GetHelperMessage() { }

	public virtual string GetId() { }

	public virtual void Init(TowerToSimulation tower, TargetType targetType = null, ObjectId towerBehaviorObjectId = null, string buttonId = null) { }

	public virtual void Init(AbilityToSimulation ability) { }

	public virtual bool IsPositionValid(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	private bool IsSimTowerValid(Tower simTower, Vector2 cursorPosWorld) { }

	private void TowerPlacementSuccess(Vector2 pos) { }

	public virtual void Update(Vector3 cursorPosUnityWorld, Vector2 cursorPosWorld, bool isCursorActive) { }

}

