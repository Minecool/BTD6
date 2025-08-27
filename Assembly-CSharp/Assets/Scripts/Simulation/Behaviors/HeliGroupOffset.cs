namespace Assets.Scripts.Simulation.Behaviors;

public class HeliGroupOffset : RootBehavior
{
	private const float passRadius = 15; //Field offset: 0x0
	private const float minOffsetDistance = 15; //Field offset: 0x0
	private const float leniency = 0.01; //Field offset: 0x0
	private HeliGroupOffsetModel heliGroupOffsetModel; //Field offset: 0x58
	private List<Vector2> availableOffsets; //Field offset: 0x60
	private List<ObjectId> idsOfHelisUsingOffset; //Field offset: 0x68
	private List<Tower> helis; //Field offset: 0x70
	private bool needsUpdate; //Field offset: 0x78
	public string targetTypeId; //Field offset: 0x80
	public string baseTowerId; //Field offset: 0x88

	public HeliGroupOffset() { }

	private void CalculateAvailableOffsets(int offsetsToCalculate) { }

	public Vector2 GetAvailableOffset(ObjectId towerId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void NeedsUpdate() { }

	protected virtual void OnDestroy() { }

	public void Reset() { }

	private void TowerDestroyed(Tower soldTower) { }

	public void Update() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

