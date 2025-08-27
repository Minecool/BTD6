namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SpikeParagonDamageZone : TowerBehavior
{
	internal struct PosRot
	{
		public Vector3 pos; //Field offset: 0x0
		public float rot; //Field offset: 0xC

	}

	public SpikeParagonDamageZoneModel spikeParagonDamageZoneModel; //Field offset: 0x68
	private float currentRadius; //Field offset: 0x70
	private float currentGeneratedRadius; //Field offset: 0x74
	private int lastRoundElapsed; //Field offset: 0x78
	private List<SpikeScale> spikes; //Field offset: 0x80
	private List<PosRot> posRotList; //Field offset: 0x88
	private List<PosRot> posRotsInsideDonut; //Field offset: 0x90
	private DamageOverTimeZone damageOverTimeZone; //Field offset: 0x98
	private List<PathSegment> invulnerablePathSegments; //Field offset: 0xA0
	private int donutIndex; //Field offset: 0xA8
	private bool isGrowing; //Field offset: 0xAC

	public List<SpikeScale> Spikes
	{
		 get { } //Length: 8
	}

	public SpikeParagonDamageZone() { }

	private void AddObjectAtPosition(PosRot posRot) { }

	private void AddObjectsAtPositions(List<PosRot> posRots) { }

	private void GeneratePositions() { }

	public List<SpikeScale> get_Spikes() { }

	public float GetCurrentRadius() { }

	private List<PosRot> GetPositionsInsideDonut(float startRadius, float endRadius) { }

	private float GetRange() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnPathModsChanged(string forId) { }

	private void Process(int elapsed) { }

	private void RemoveObjects() { }

	public void ResetProgress() { }

	public void SetCurrentRadius(float radius) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void Update() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

