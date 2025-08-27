namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "EmitOnDamage", menuName = "BTD6/Behaviors/Projectiles/EmitOnDamage")]
public class EmitOnDamage : ProjectileBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 188
	}

	public EmitOnDamage() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

