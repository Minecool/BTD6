namespace Assets.Scripts.Unity.Towers.Behaviors;

public class Orbit : TowerBehavior
{
	public Orbit parent; //Field offset: 0x98
	public int count; //Field offset: 0xA0
	public string expCount; //Field offset: 0xA8
	public float range; //Field offset: 0xB0
	public string expRange; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 200
	}

	public Orbit() { }

	public virtual TowerBehaviorModel get_Def() { }

}

