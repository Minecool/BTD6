namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class CreatePropsOnBloonAction : BloonBehaviorAction
{
	private struct RockData
	{
		public int createdAt; //Field offset: 0x0
		public Vector2 centrePos; //Field offset: 0x4
		public List<Prop> props; //Field offset: 0x10

	}

	public CreatePropsOnBloonActionModel createPropsModel; //Field offset: 0x78
	private List<RockData> rockDataList; //Field offset: 0x80

	public CreatePropsOnBloonAction() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void PerformAction() { }

	private void Process(int elapsed) { }

	private void RemovePropCircle(RockData rockData) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void SpawnPropsInCircle(Vector2 circleCenter, int createdAt = -1) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

