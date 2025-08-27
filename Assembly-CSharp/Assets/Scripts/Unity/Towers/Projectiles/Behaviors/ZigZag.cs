namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class ZigZag : ProjectileBehavior
{
	public float maxOffset; //Field offset: 0x88
	public string expMaxOffset; //Field offset: 0x90
	public float zigZagSpeed; //Field offset: 0x98
	public string expZigZagSpeed; //Field offset: 0xA0

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 166
	}

	public ZigZag() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

