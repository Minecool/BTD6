namespace Assets.Scripts.Unity.Towers.Behaviors;

public class DroneSupport : TowerBehavior
{
	public DroneSupport parent; //Field offset: 0x98
	public Tower drone; //Field offset: 0xA0
	public Tower expDrone; //Field offset: 0xA8
	public int count; //Field offset: 0xB0
	public string expCount; //Field offset: 0xB8
	public float spawnDelay; //Field offset: 0xC0
	public string expSpawnDelay; //Field offset: 0xC8
	public int spawnAnimState; //Field offset: 0xD0
	public string expSpawnAnimState; //Field offset: 0xD8
	public GameObject spawnMarker1Start; //Field offset: 0xE0
	public GameObject expSpawnMarker1Start; //Field offset: 0xE8
	public GameObject spawnMarker2Start; //Field offset: 0xF0
	public GameObject expSpawnMarker2Start; //Field offset: 0xF8
	public GameObject spawnMarker3Start; //Field offset: 0x100
	public GameObject expSpawnMarker3Start; //Field offset: 0x108
	public GameObject spawnMarker4Start; //Field offset: 0x110
	public GameObject expSpawnMarker4Start; //Field offset: 0x118
	public GameObject spawnMarker1End; //Field offset: 0x120
	public GameObject expSpawnMarker1End; //Field offset: 0x128
	public GameObject spawnMarker2End; //Field offset: 0x130
	public GameObject expSpawnMarker2End; //Field offset: 0x138
	public GameObject spawnMarker3End; //Field offset: 0x140
	public GameObject expSpawnMarker3End; //Field offset: 0x148
	public GameObject spawnMarker4End; //Field offset: 0x150
	public GameObject expSpawnMarker4End; //Field offset: 0x158
	public float spawnIndexRotation; //Field offset: 0x160
	public string expSpawnIndexRotation; //Field offset: 0x168
	public Effect effectAtSpawn; //Field offset: 0x170
	public Effect expEffectAtSpawn; //Field offset: 0x178
	public bool updateTargetType; //Field offset: 0x180
	public string expUpdateTargetType; //Field offset: 0x188
	public Effect effectOnDroneUpgrade; //Field offset: 0x190
	public Effect expEffectOnDroneUpgrade; //Field offset: 0x198
	public bool createUpgradeEffect; //Field offset: 0x1A0
	public string expCreateUpgradeEffect; //Field offset: 0x1A8
	public float ignoreTargetingTime; //Field offset: 0x1B0
	public string expIgnoreTargetingTime; //Field offset: 0x1B8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 3640
	}

	public DroneSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

