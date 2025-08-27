namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "DroneIdle", menuName = "BTD6/Behaviors/Towers/DroneIdle")]
public class DroneIdle : TowerBehavior
{
	public float outOfRangeRepositionTime; //Field offset: 0x30
	public float idleRepositionTimeMin; //Field offset: 0x34
	public float idleRepositionTimeMax; //Field offset: 0x38
	public DisplayModel greenLight; //Field offset: 0x40
	public DisplayModel redLight; //Field offset: 0x48
	public DisplayModel blueLight; //Field offset: 0x50
	public DisplayModel yellowLight; //Field offset: 0x58
	public DisplayModel purpleLight; //Field offset: 0x60

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 241
	}

	public DroneIdle() { }

	public virtual TowerBehaviorModel get_Def() { }

}

