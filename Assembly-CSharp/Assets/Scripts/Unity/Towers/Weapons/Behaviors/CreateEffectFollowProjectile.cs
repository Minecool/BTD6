namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class CreateEffectFollowProjectile : ProjectileBehavior
{
	public CreateEffectFollowProjectile parent; //Field offset: 0x88
	public Effect effect; //Field offset: 0x90
	public Effect expEffect; //Field offset: 0x98
	public string offset; //Field offset: 0xA0
	public string expOffset; //Field offset: 0xA8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 483
	}

	public CreateEffectFollowProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

