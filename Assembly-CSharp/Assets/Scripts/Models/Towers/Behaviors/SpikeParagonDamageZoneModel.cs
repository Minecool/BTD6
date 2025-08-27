namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SpikeParagonDamageZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpikeParagonDamageZoneModel : TowerBehaviorModel
{
	private const int PathObjectsPerRange = 4; //Field offset: 0x0
	public PrefabReference objectToPlace1; //Field offset: 0x30
	public PrefabReference objectToPlace2; //Field offset: 0x38
	public PrefabReference objectToPlace3; //Field offset: 0x40
	public PrefabReference objectToPlace4; //Field offset: 0x48
	public PrefabReference[] objectsToPlace; //Field offset: 0x50
	public DamageOverTimeZoneModel damageOverTimeZoneModel; //Field offset: 0x58
	public float spacingMin; //Field offset: 0x60
	public float spacingMax; //Field offset: 0x64
	public float scaleMin; //Field offset: 0x68
	public float scaleMax; //Field offset: 0x6C
	public float rotationMin; //Field offset: 0x70
	public float rotationMax; //Field offset: 0x74
	public float offsetMin; //Field offset: 0x78
	public float offsetMax; //Field offset: 0x7C
	public float circleRadius; //Field offset: 0x80
	public float generateRadius; //Field offset: 0x84
	[SerializeField]
	private float time; //Field offset: 0x88
	public int timeFrames; //Field offset: 0x8C
	public float amountPerFrame; //Field offset: 0x90
	public float minScale; //Field offset: 0x94
	public float maxScale; //Field offset: 0x98
	public float scaleTime; //Field offset: 0x9C
	public Vector3 minScaleVector; //Field offset: 0xA0
	public Vector3 maxScaleVector; //Field offset: 0xAC
	public int minProjSpeed; //Field offset: 0xB8
	public int maxProjSpeed; //Field offset: 0xBC

	public SpikeParagonDamageZoneModel(string name, PrefabReference objectToPlace1, PrefabReference objectToPlace2, PrefabReference objectToPlace3, PrefabReference objectToPlace4, DamageOverTimeZoneModel damageOverTimeZoneModel, float spacingMin, float spacingMax, float scaleMin, float scaleMax, float rotationMin, float rotationMax, float offsetMin, float offsetMax, float circleRadius, float generateRadius, float time, float minScale, float maxScale, float scaleTime, int minProjSpeed, int maxProjSpeed) { }

	public virtual void ApplyPrefabSwaps(PrefabSwap[] prefabSwaps) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	private void PopulatePrefabArray() { }

}

