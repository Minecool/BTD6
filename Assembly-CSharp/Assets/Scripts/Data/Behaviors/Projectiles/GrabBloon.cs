namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "GrabBloon", menuName = "BTD6/Behaviors/Projectiles/GrabBloon")]
public class GrabBloon : ProjectileBehavior
{
	public float grabDuration; //Field offset: 0x30
	public Projectile projectile; //Field offset: 0x38
	public Emission emission; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 212
	}

	public GrabBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

