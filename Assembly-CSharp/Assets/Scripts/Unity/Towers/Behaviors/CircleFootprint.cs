namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CircleFootprint : Footprint
{
	public CircleFootprint parent; //Field offset: 0xC8
	public float radius; //Field offset: 0xD0
	public string expRadius; //Field offset: 0xD8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 181
	}

	public CircleFootprint() { }

	public virtual TowerBehaviorModel get_Def() { }

}

