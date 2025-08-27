namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class LockInPlaceSetting : PathSupplierHeli
{
	public LockInPlaceSettingModel lockInPlaceSettingModel; //Field offset: 0xA8
	private Nullable<Vector2> lockedPosition; //Field offset: 0xB0
	private Entity targetImg; //Field offset: 0xC0
	private bool currActive; //Field offset: 0xC8

	public LockInPlaceSetting() { }

	public virtual void ApplyTargetTypeData(Vector2 data) { }

	public Vector2 GetLockedPosition() { }

	public virtual string GetName() { }

	public virtual Vector2[] GetPath() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual object GetTargetTypeCustomInputData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnSelectionChanged(ISelectable selected) { }

	public virtual void OnSwitchedFrom() { }

	public virtual void OnSwitchedTo() { }

	public void SetLockedPosition(Vector2 position) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void StartDraw() { }

	private void StopDraw() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

