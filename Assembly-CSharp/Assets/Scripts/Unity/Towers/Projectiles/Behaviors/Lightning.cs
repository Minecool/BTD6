namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class Lightning : ProjectileBehavior
{
	public Lightning parent; //Field offset: 0x88
	public int splits; //Field offset: 0x90
	public string expSplits; //Field offset: 0x98
	public Emission emission; //Field offset: 0xA0
	public Emission expEmission; //Field offset: 0xA8
	public float splitRange; //Field offset: 0xB0
	public string expSplitRange; //Field offset: 0xB8
	public float delay; //Field offset: 0xC0
	public string expDelay; //Field offset: 0xC8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 220
	}

	public Lightning() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

