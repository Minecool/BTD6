namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateProjectilesOnTrackOnExhaustFraction : ProjectileBehavior
{
	private CreateProjectilesOnTrackOnExhaustFractionModel cpModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private bool isDone; //Field offset: 0x78
	private IList<PathSegment> targetPathSegments; //Field offset: 0x80
	private int currentPoint; //Field offset: 0x88
	private Vector3 pos; //Field offset: 0x8C

	public CreateProjectilesOnTrackOnExhaustFraction() { }

	protected void CheckFraction(float pierceFraction, float durationFraction) { }

	public virtual void Exhausted() { }

	private void GeneratePoints() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	private Target GetTarget() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

