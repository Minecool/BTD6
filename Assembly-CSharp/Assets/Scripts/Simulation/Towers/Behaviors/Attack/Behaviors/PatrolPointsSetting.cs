namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class PatrolPointsSetting : PathSupplierHeli
{
	private const int NUMPOINTS = 2; //Field offset: 0x0
	public PatrolPointsSettingModel patrolPointsSettingModel; //Field offset: 0xA8
	private Vector2[] patrolPoints; //Field offset: 0xB0
	private bool needsTargets; //Field offset: 0xB8
	private List<Entity> targetImages; //Field offset: 0xC0
	private Vector2 dir; //Field offset: 0xC8
	private Vector2 sp; //Field offset: 0xD0
	private int dotCount; //Field offset: 0xD8
	private float timer; //Field offset: 0xDC
	private List<Entity> dotImgs; //Field offset: 0xE0
	private float adjustedSpacing; //Field offset: 0xE8
	private bool currActive; //Field offset: 0xEC

	public PatrolPointsSetting() { }

	public virtual void ApplyTargetTypeData(Vector2[] data) { }

	public virtual string GetName() { }

	public virtual Vector2[] GetPath() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual object GetTargetTypeCustomInputData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnSelectionChanged(ISelectable selected) { }

	public virtual void OnSwitchedFrom() { }

	public virtual void OnSwitchedTo() { }

	private void Process(int elapsed) { }

	public void SetDefaultPath() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void StartDraw() { }

	private void StopDraw() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

