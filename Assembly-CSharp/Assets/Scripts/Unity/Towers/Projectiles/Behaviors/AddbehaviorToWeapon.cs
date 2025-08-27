namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class AddbehaviorToWeapon : ProjectileBehavior
{
	public AddbehaviorToWeapon parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public string mutationId; //Field offset: 0xA0
	public string expMutationId; //Field offset: 0xA8
	public WeaponBehavior behavior; //Field offset: 0xB0

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 290
	}

	public AddbehaviorToWeapon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

