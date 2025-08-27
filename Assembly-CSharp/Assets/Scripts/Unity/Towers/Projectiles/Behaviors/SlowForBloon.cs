namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class SlowForBloon : Slow
{
	public string bloonId; //Field offset: 0x170
	public string expBloonId; //Field offset: 0x178
	public string bloonTag; //Field offset: 0x180
	public string expBloonTag; //Field offset: 0x188
	public bool excluding; //Field offset: 0x190
	public string expExcluding; //Field offset: 0x198

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 623
	}

	public SlowForBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

