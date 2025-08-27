namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(DroneSupport), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DroneSupportModel : TowerBehaviorModel
{
	public TowerModel droneModel; //Field offset: 0x30
	public int count; //Field offset: 0x38
	[SerializeField]
	private float spawnDelay; //Field offset: 0x3C
	public int spawnDelayFrames; //Field offset: 0x40
	public int spawnAnimState; //Field offset: 0x44
	public Single[] spawnMarkerStartsX; //Field offset: 0x48
	public Single[] spawnMarkerStartsY; //Field offset: 0x50
	public Single[] spawnMarkerEndsX; //Field offset: 0x58
	public Single[] spawnMarkerEndsY; //Field offset: 0x60
	public float spawnIndexRotation; //Field offset: 0x68
	public EffectModel effectAtSpawn; //Field offset: 0x70
	public bool updateTargetType; //Field offset: 0x78
	public EffectModel effectOnDisplayChanged; //Field offset: 0x80
	public bool createDroneUpgradeEffect; //Field offset: 0x88
	[SerializeField]
	private float ignoreTargetingTime; //Field offset: 0x8C
	public int ignoreTargetingFrames; //Field offset: 0x90

	public DroneSupportModel(string name, TowerModel droneModel, int count, float spawnDelay, int spawnAnimState, Single[] spawnMarkerStartsX, Single[] spawnMarkerStartsY, Single[] spawnMarkerEndsX, Single[] spawnMarkerEndsY, float spawnIndexRotation, EffectModel effectAtSpawn, bool updateTargetType, EffectModel effectOnDisplayChanged, bool createDroneUpgradeEffect, float ignoreTargetingTime) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

