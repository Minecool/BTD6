namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DamageInRingRadius", menuName = "BTD6/Behaviors/Projectiles/DamageInRingRadius")]
public class DamageInRingRadius : Damage
{
	public float innerRingRadius; //Field offset: 0x58
	public bool ignoreImmunityDestroy; //Field offset: 0x5C

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 307
	}

	public DamageInRingRadius() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

