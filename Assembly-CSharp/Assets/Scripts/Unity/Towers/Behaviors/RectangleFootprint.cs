namespace Assets.Scripts.Unity.Towers.Behaviors;

public class RectangleFootprint : Footprint
{
	public RectangleFootprint parent; //Field offset: 0xC8
	public float xWidth; //Field offset: 0xD0
	public string expXWidth; //Field offset: 0xD8
	public float yWidth; //Field offset: 0xE0
	public string expYWidth; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 203
	}

	public RectangleFootprint() { }

	public virtual TowerBehaviorModel get_Def() { }

}

