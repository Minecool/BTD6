namespace Assets.Scripts.Unity.Towers.Behaviors;

public class AirUnit : TowerBehavior
{
	public AirUnit parent; //Field offset: 0x98
	public bool isAirUnitSelectable; //Field offset: 0xA0
	public string expIsAirUnitSelectable; //Field offset: 0xA8
	public float selectableRadius; //Field offset: 0xB0
	public string expSelectableRadius; //Field offset: 0xB8
	public bool blocksPlacement; //Field offset: 0xC0
	public string expBlocksPlacement; //Field offset: 0xC8
	public float blockingRadius; //Field offset: 0xD0
	public string expBlockingRadius; //Field offset: 0xD8
	private AirUnitModel def; //Field offset: 0xE0

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 524
	}

	public AirUnit() { }

	private TowerBehaviorModel[] GatherBehaviors() { }

	public virtual TowerBehaviorModel get_Def() { }

	private TowerBehavior[] StripTowerBehavoiurs(TowerBehavior[] behaviours) { }

}

