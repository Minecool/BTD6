namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SpiritOfTheForest : TowerBehavior
{
	public SpiritOfTheForestModel spiritOfTheForestModel; //Field offset: 0x68
	private float currentRadius; //Field offset: 0x70
	private float currentGeneratedRadius; //Field offset: 0x74
	private Vector2 vineSeedOrigin; //Field offset: 0x78
	private List<VineScale> vines; //Field offset: 0x80
	private List<Vector3> positions; //Field offset: 0x88
	private List<Vector3> positionsInsideDonut; //Field offset: 0x90
	private DamageOverTimeZone damageOverTimeZoneFar; //Field offset: 0x98
	private DamageOverTimeZone damageOverTimeZoneMiddle; //Field offset: 0xA0
	private DamageOverTimeZone damageOverTimeZoneClose; //Field offset: 0xA8
	private List<PathSegment> invulnerablePathSegments; //Field offset: 0xB0
	private int lastRoundElapsed; //Field offset: 0xB8
	private int donutIndex; //Field offset: 0xBC
	public bool isGrowing; //Field offset: 0xC0

	public List<VineScale> Vines
	{
		 get { } //Length: 8
	}

	public SpiritOfTheForest() { }

	private void AddObjectAtPosition(Vector3 position) { }

	private void AddObjectsAtPositions(List<Vector3> positions) { }

	private void GeneratePositions() { }

	public List<VineScale> get_Vines() { }

	public float GetCurrentRadius() { }

	private List<Vector3> GetPositionsInsideDonut(float startRadius, float endRadius) { }

	private float GetRangeClose() { }

	private float GetRangeFar() { }

	private float GetRangeMiddle() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnPathModsChanged(string forId) { }

	private void OnRoundSet(bool fromSave) { }

	private void OnTowerRepositioned(bool onTheMove) { }

	private void Process(int elapsed) { }

	private void RemoveObjects() { }

	public void ResetProgress() { }

	public void SetCurrentRadius(float radius) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void Update() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateVineSeedOrigin() { }

}

