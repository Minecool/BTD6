namespace Assets.Scripts.Unity.Towers.Behaviors.PlacementBehaviors;

public class PlacementAreaTypeRangeBuff : PlacementBehavior
{
	public PlacementAreaTypeRangeBuff parent; //Field offset: 0x98
	public float rangeMultiplier; //Field offset: 0xA0
	public string expRangeMultiplier; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public PlacementAreaTypeRangeBuff() { }

	public virtual TowerBehaviorModel get_Def() { }

}

