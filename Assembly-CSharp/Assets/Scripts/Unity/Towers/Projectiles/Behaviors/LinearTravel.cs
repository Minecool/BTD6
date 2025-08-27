namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class LinearTravel : ProjectileBehavior
{
	public LinearTravel parent; //Field offset: 0x88
	public float speed; //Field offset: 0x90
	public string expSpeed; //Field offset: 0x98
	public float lifespan; //Field offset: 0xA0
	public string expLifespan; //Field offset: 0xA8
	public bool dontDestroyOnTargetLoss; //Field offset: 0xB0
	public string expDontDestroyOnTargetLoss; //Field offset: 0xB8
	public bool forceCollisionOnSnap; //Field offset: 0xC0
	public string expForceCollisionOnSnap; //Field offset: 0xC8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 219
	}

	public LinearTravel() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

