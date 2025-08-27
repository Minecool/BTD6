namespace Assets.Scripts.Unity.Towers.Behaviors;

public class FigureEightMovement : TowerBehavior
{
	public FigureEightMovement parent; //Field offset: 0x98
	public float radius; //Field offset: 0xA0
	public string expRadius; //Field offset: 0xA8
	public float speed; //Field offset: 0xB0
	public string expSpeed; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public FigureEightMovement() { }

	public virtual TowerBehaviorModel get_Def() { }

}

