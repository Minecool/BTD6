namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "LightningSplitOnContact", menuName = "BTD6/Behaviors/Projectiles/LightningSplitOnContact")]
public class LightningSplitOnContact : ProjectileBehavior
{
	public int targets; //Field offset: 0x30
	public Projectile projectile; //Field offset: 0x38
	public Emission emission; //Field offset: 0x40
	public float splitRange; //Field offset: 0x48
	public float delay; //Field offset: 0x4C

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 258
	}

	public LightningSplitOnContact() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

