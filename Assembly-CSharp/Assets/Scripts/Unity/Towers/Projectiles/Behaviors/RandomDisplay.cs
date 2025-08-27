namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class RandomDisplay : ProjectileBehavior
{
	public RandomDisplay parent; //Field offset: 0x88
	public bool applyRandomRotation; //Field offset: 0x90
	public string expApplyRandomRotation; //Field offset: 0x98
	public GameObject display1; //Field offset: 0xA0
	public GameObject expDisplay1; //Field offset: 0xA8
	public GameObject display2; //Field offset: 0xB0
	public GameObject expDisplay2; //Field offset: 0xB8
	public GameObject display3; //Field offset: 0xC0
	public GameObject expDisplay3; //Field offset: 0xC8
	public GameObject display4; //Field offset: 0xD0
	public GameObject expDisplay4; //Field offset: 0xD8
	public GameObject display5; //Field offset: 0xE0
	public GameObject expDisplay5; //Field offset: 0xE8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 1100
	}

	public RandomDisplay() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

