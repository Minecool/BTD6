namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SpiritOfTheForest), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpiritOfTheForestModel : TowerBehaviorModel
{
	private const int PathObjectsPerRange = 4; //Field offset: 0x0
	public PrefabReference objectToPlace1FarPath; //Field offset: 0x30
	public PrefabReference objectToPlace2FarPath; //Field offset: 0x38
	public PrefabReference objectToPlace3FarPath; //Field offset: 0x40
	public PrefabReference objectToPlace4FarPath; //Field offset: 0x48
	public PrefabReference[] objectsToPlaceFar; //Field offset: 0x50
	public PrefabReference objectToPlace1MiddlePath; //Field offset: 0x58
	public PrefabReference objectToPlace2MiddlePath; //Field offset: 0x60
	public PrefabReference objectToPlace3MiddlePath; //Field offset: 0x68
	public PrefabReference objectToPlace4MiddlePath; //Field offset: 0x70
	public PrefabReference[] objectsToPlaceMiddle; //Field offset: 0x78
	public PrefabReference objectToPlace1ClosePath; //Field offset: 0x80
	public PrefabReference objectToPlace2ClosePath; //Field offset: 0x88
	public PrefabReference objectToPlace3ClosePath; //Field offset: 0x90
	public PrefabReference objectToPlace4ClosePath; //Field offset: 0x98
	public PrefabReference[] objectsToPlaceClose; //Field offset: 0xA0
	public DamageOverTimeZoneModel damageOverTimeZoneModelFar; //Field offset: 0xA8
	public DamageOverTimeZoneModel damageOverTimeZoneModelMiddle; //Field offset: 0xB0
	public DamageOverTimeZoneModel damageOverTimeZoneModelClose; //Field offset: 0xB8
	public float middleRange; //Field offset: 0xC0
	public float closeRange; //Field offset: 0xC4
	public float spacingMin; //Field offset: 0xC8
	public float spacingMax; //Field offset: 0xCC
	public float scaleMin; //Field offset: 0xD0
	public float scaleMax; //Field offset: 0xD4
	public float rotationMin; //Field offset: 0xD8
	public float rotationMax; //Field offset: 0xDC
	public float offsetMin; //Field offset: 0xE0
	public float offsetMax; //Field offset: 0xE4
	public float circleRadius; //Field offset: 0xE8
	public float generateRadius; //Field offset: 0xEC
	[SerializeField]
	private float time; //Field offset: 0xF0
	public int timeFrames; //Field offset: 0xF4
	public float amountPerFrame; //Field offset: 0xF8
	public float minScale; //Field offset: 0xFC
	public float maxScale; //Field offset: 0x100
	public float scaleTime; //Field offset: 0x104
	public Vector3 minScaleVector; //Field offset: 0x108
	public Vector3 maxScaleVector3; //Field offset: 0x114

	public SpiritOfTheForestModel(string name, PrefabReference objectToPlace1FarPath, PrefabReference objectToPlace2FarPath, PrefabReference objectToPlace3FarPath, PrefabReference objectToPlace4FarPath, PrefabReference objectToPlace1MiddlePath, PrefabReference objectToPlace2MiddlePath, PrefabReference objectToPlace3MiddlePath, PrefabReference objectToPlace4MiddlePath, PrefabReference objectToPlace1ClosePath, PrefabReference objectToPlace2ClosePath, PrefabReference objectToPlace3ClosePath, PrefabReference objectToPlace4ClosePath, DamageOverTimeZoneModel damageOverTimeZoneModelFar, DamageOverTimeZoneModel damageOverTimeZoneModelMiddle, DamageOverTimeZoneModel damageOverTimeZoneModelClose, float middleRange, float closeRange, float spacingMin, float spacingMax, float scaleMin, float scaleMax, float rotationMin, float rotationMax, float offsetMin, float offsetMax, float circleRadius, float generateRadius, float time, float minScale, float maxScale, float scaleTime) { }

	public virtual void ApplyPrefabSwaps(PrefabSwap[] prefabSwaps) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	private void PopulatePrefabArrays() { }

}

