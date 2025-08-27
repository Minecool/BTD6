namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class BigSqueezeFortifiedEffect : ProjectileBehavior
{
	public BigSqueezeFortifiedEffect parent; //Field offset: 0x88
	public bool randomRotation; //Field offset: 0x90
	public string expRandomRotation; //Field offset: 0x98
	public Effect effect; //Field offset: 0xA0
	public Effect expEffect; //Field offset: 0xA8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 216
	}

	public BigSqueezeFortifiedEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

