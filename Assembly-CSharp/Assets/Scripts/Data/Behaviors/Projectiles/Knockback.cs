namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "Knockback", menuName = "BTD6/Behaviors/Projectiles/Knockback")]
public class Knockback : ProjectileBehavior
{
	public float moabMultiplier; //Field offset: 0x30
	public float heavyMultiplier; //Field offset: 0x34
	public float lightMultiplier; //Field offset: 0x38
	public float lifespan; //Field offset: 0x3C
	public string mutationId; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 205
	}

	public Knockback() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

