namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "AddbehaviorToWeapon", menuName = "BTD6/Behaviors/Projectiles/AddbehaviorToWeapon")]
public class AddbehaviorToWeapon : ProjectileBehavior
{
	public float lifespan; //Field offset: 0x30
	public string mutationId; //Field offset: 0x38
	public WeaponBehavior behavior; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 281
	}

	public AddbehaviorToWeapon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

