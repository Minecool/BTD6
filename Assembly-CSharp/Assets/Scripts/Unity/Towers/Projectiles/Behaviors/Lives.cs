namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class Lives : ProjectileBehavior
{
	public Lives parent; //Field offset: 0x88
	public float minimum; //Field offset: 0x90
	public string expMinimum; //Field offset: 0x98
	public float maximum; //Field offset: 0xA0
	public string expMaximum; //Field offset: 0xA8
	public float salvage; //Field offset: 0xB0
	public string expSalvage; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 164
	}

	public Lives() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

