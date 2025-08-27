namespace Assets.Scripts.Unity.UI_New.InGame;

public class SubTowerDeployInput : CustomInput
{
	private AbilityToSimulation ability; //Field offset: 0x28
	private TowerModel data; //Field offset: 0x30

	public SubTowerDeployInput() { }

	public virtual void CursorDown(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	public virtual void EnterInputMode() { }

	public virtual void ExitInputMode() { }

	public virtual void Init(AbilityToSimulation ability) { }

	private void TowerPlacementSuccess(Vector2 pos) { }

}

