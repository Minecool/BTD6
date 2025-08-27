namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateProjectileOnBlockerCollide", menuName = "BTD6/Behaviors/Projectiles/CreateProjectileOnBlockerCollide")]
public class CreateProjectileOnBlockerCollide : ProjectileBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38
	public PrefabReference display; //Field offset: 0x40
	public float displayLifetime; //Field offset: 0x48

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 236
	}

	public CreateProjectileOnBlockerCollide() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

