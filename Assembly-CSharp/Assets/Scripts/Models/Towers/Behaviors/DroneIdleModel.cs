namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(DroneIdle), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DroneIdleModel : TowerBehaviorModel
{
	[SerializeField]
	private float outOfRangeRepositionTime; //Field offset: 0x30
	public int outOfRangeRepositionTimeFrames; //Field offset: 0x34
	[SerializeField]
	private float idleRepositionTimeMin; //Field offset: 0x38
	public int idleRepositionTimeMinFrames; //Field offset: 0x3C
	[SerializeField]
	private float idleRepositionTimeMax; //Field offset: 0x40
	public int idleRepositionTimeMaxFrames; //Field offset: 0x44
	public DisplayModel greenLight; //Field offset: 0x48
	public DisplayModel redLight; //Field offset: 0x50
	public DisplayModel blueLight; //Field offset: 0x58
	public DisplayModel yellowLight; //Field offset: 0x60
	public DisplayModel purpleLight; //Field offset: 0x68

	public DroneIdleModel(string name, float outOfRangeRepositionTime, float idleRepositionTimeMin, float idleRepositionTimeMax, DisplayModel greenLight, DisplayModel redLight, DisplayModel blueLight, DisplayModel yellowLight, DisplayModel purpleLight) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

