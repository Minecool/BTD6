namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "DroneSupport", menuName = "BTD6/Behaviors/Towers/DroneSupport")]
public class DroneSupport : TowerBehavior
{
	public Tower drone; //Field offset: 0x30
	public int count; //Field offset: 0x38
	public float spawnDelay; //Field offset: 0x3C
	public int spawnAnimState; //Field offset: 0x40
	public OffsetPosition spawnMarker1Start; //Field offset: 0x48
	public OffsetPosition spawnMarker2Start; //Field offset: 0x50
	public OffsetPosition spawnMarker3Start; //Field offset: 0x58
	public OffsetPosition spawnMarker4Start; //Field offset: 0x60
	public OffsetPosition spawnMarker1End; //Field offset: 0x68
	public OffsetPosition spawnMarker2End; //Field offset: 0x70
	public OffsetPosition spawnMarker3End; //Field offset: 0x78
	public OffsetPosition spawnMarker4End; //Field offset: 0x80
	public float spawnIndexRotation; //Field offset: 0x88
	public Effect effectAtSpawn; //Field offset: 0x90
	public bool updateTargetType; //Field offset: 0x98
	public Effect effectOnDroneUpgrade; //Field offset: 0xA0
	public bool createUpgradeEffect; //Field offset: 0xA8
	public float ignoreTargetingTime; //Field offset: 0xAC

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 3049
	}

	public DroneSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

