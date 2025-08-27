namespace Assets.Scripts.Unity.Towers.Behaviors;

public class DroneIdle : TowerBehavior
{
	public DroneIdle parent; //Field offset: 0x98
	public float outOfRangeRepositionTime; //Field offset: 0xA0
	public string expOutOfRangeRepositionTime; //Field offset: 0xA8
	public float idleRepositionTimeMin; //Field offset: 0xB0
	public string expIdleRepositionTimeMin; //Field offset: 0xB8
	public float idleRepositionTimeMax; //Field offset: 0xC0
	public string expIdleRepositionTimeMax; //Field offset: 0xC8
	public GameObject greenLight; //Field offset: 0xD0
	public GameObject expGreenLight; //Field offset: 0xD8
	public GameObject redLight; //Field offset: 0xE0
	public GameObject expRedLight; //Field offset: 0xE8
	public GameObject blueLight; //Field offset: 0xF0
	public GameObject expBlueLight; //Field offset: 0xF8
	public GameObject yellowLight; //Field offset: 0x100
	public GameObject expYellowLight; //Field offset: 0x108
	public GameObject purpleLight; //Field offset: 0x110
	public GameObject expPurpleLight; //Field offset: 0x118

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1008
	}

	public DroneIdle() { }

	public virtual TowerBehaviorModel get_Def() { }

}

