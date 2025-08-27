namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class PathMovement : TowerBehavior
{
	public PathMovementModel pathMovementModel; //Field offset: 0x68
	private List<PathSupplier> pathSuppliers; //Field offset: 0x70
	public PathSupplier currPathSupplier; //Field offset: 0x78
	private float tpf; //Field offset: 0x80
	private float lastBank; //Field offset: 0x84
	public float t; //Field offset: 0x88
	public bool onPath; //Field offset: 0x8C
	public bool takingOff; //Field offset: 0x8D
	private float tt; //Field offset: 0x90
	private float ttpf; //Field offset: 0x94
	private float pitch; //Field offset: 0x98
	private Vector2 beforeOnTheMovePos; //Field offset: 0x9C
	private bool onTheMove; //Field offset: 0xA4

	public float LastBank
	{
		 get { } //Length: 9
	}

	public PathMovement() { }

	public virtual void Attatched() { }

	public void Copy(PathMovement from) { }

	private void FindCurrSupplier() { }

	public float get_LastBank() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnChangeTargetPriority(TargetType targetType) { }

	protected virtual void OnDestroy() { }

	public virtual void OnTsmThemeAction(string themeId, string buttonId, TSMInfoModel info) { }

	public void Process(int elapsed) { }

	public void SetPositionFromSave(Vector3 savedAirUnitPosition) { }

	public void SetupPathSuppliers() { }

	public void TakeOffAnimation(DisplayBehavior display) { }

	private void TowerRepositioned(bool onTheMove) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

