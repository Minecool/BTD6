namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class CirclePattern : PathSupplier
{
	public CirclePatternModel circlePatternModel; //Field offset: 0xA0
	private List<Entity> dotImgs; //Field offset: 0xA8
	private List<Vector3> poss; //Field offset: 0xB0
	private bool currActive; //Field offset: 0xB8
	private float t; //Field offset: 0xBC

	public CirclePattern() { }

	public virtual string GetName() { }

	public virtual float GetPathLength() { }

	public virtual Vector2 GetPathPosition(float t) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnSelectionChanged(ISelectable selected) { }

	public virtual void OnSwitchedFrom() { }

	public virtual void OnSwitchedTo() { }

	private void Process(int elapsed) { }

	private void StartDraw() { }

	private void StopDraw() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

