namespace Assets.Scripts.Unity.Towers.Behaviors.PlacementBehaviors;

public class PlacementAreaTypeHeightSetting : PlacementBehavior
{
	public PlacementAreaTypeHeightSetting parent; //Field offset: 0x98
	public float landHeight; //Field offset: 0xA0
	public string expLandHeight; //Field offset: 0xA8
	public float waterHeight; //Field offset: 0xB0
	public string expwaterHeight; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public PlacementAreaTypeHeightSetting() { }

	public virtual TowerBehaviorModel get_Def() { }

}

