namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(PlaceAlongTrack), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PlaceAlongTrackModel : TowerBehaviorModel
{
	public PrefabReference objectToPlace1Path; //Field offset: 0x30
	public PrefabReference objectToPlace2Path; //Field offset: 0x38
	public PrefabReference objectToPlace3Path; //Field offset: 0x40
	public PrefabReference objectToPlace4Path; //Field offset: 0x48
	public PrefabReference[] objectsToPlacePath; //Field offset: 0x50
	public float spacingMin; //Field offset: 0x58
	public float spacingMax; //Field offset: 0x5C
	public float scaleMin; //Field offset: 0x60
	public float scaleMax; //Field offset: 0x64
	public float rotationMin; //Field offset: 0x68
	public float rotationMax; //Field offset: 0x6C
	public float offsetMin; //Field offset: 0x70
	public float offsetMax; //Field offset: 0x74

	public PlaceAlongTrackModel(string name, PrefabReference objectToPlace1Path, PrefabReference objectToPlace2Path, PrefabReference objectToPlace3Path, PrefabReference objectToPlace4Path, float spacingMin, float spacingMax, float scaleMin, float scaleMax, float rotationMin, float rotationMax, float offsetMin, float offsetMax) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

