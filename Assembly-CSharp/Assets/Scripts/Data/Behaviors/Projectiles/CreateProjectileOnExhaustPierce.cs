namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateProjectileOnExhaustPierce", menuName = "BTD6/Behaviors/Projectiles/CreateProjectileOnExhaustPierce")]
public class CreateProjectileOnExhaustPierce : ProjectileBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38
	public float pierceInterval; //Field offset: 0x40
	public int count; //Field offset: 0x44
	public float minimumTimeDifference; //Field offset: 0x48
	public string destroyProjectile; //Field offset: 0x50
	public PrefabReference display; //Field offset: 0x58
	public float displayLifetime; //Field offset: 0x60
	public bool displayFullscreen; //Field offset: 0x64
	public bool useBloonPosition; //Field offset: 0x65

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 427
	}

	public CreateProjectileOnExhaustPierce() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

