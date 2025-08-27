namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class CenterElipsePattern : PathSupplier
{
	public CenterElipsePatternModel centerElipsePatternModel; //Field offset: 0xA0
	public TargetType centerElipsePatternTargetType; //Field offset: 0xA8
	private List<Entity> dotImgs; //Field offset: 0xC0
	private List<Vector3> poss; //Field offset: 0xC8
	private Nullable<Vector2> selectedPoint; //Field offset: 0xD0
	private Entity targetImg; //Field offset: 0xE0
	private bool currActive; //Field offset: 0xE8
	private float t; //Field offset: 0xEC

	public CenterElipsePattern() { }

	public virtual void ApplyTargetTypeData(Vector2 data) { }

	public virtual void Attatched() { }

	public virtual string GetName() { }

	public virtual float GetPathLength() { }

	public virtual Vector2 GetPathPosition(float t) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual object GetTargetTypeCustomInputData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnSelectionChanged(ISelectable selected) { }

	public virtual void OnSwitchedFrom() { }

	public virtual void OnSwitchedTo() { }

	private void Process(int elapsed) { }

	public void SetCentrePoint(Vector2 position) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void StartDraw() { }

	private void StopDraw() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	public virtual bool UseTowerPosition() { }

}

