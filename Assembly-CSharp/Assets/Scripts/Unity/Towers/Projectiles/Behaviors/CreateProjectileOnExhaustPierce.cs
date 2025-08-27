namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateProjectileOnExhaustPierce : ProjectileBehavior
{
	public CreateProjectileOnExhaustPierce parent; //Field offset: 0x88
	public Projectile projectile; //Field offset: 0x90
	public Emission emission; //Field offset: 0x98
	public float pierceInterval; //Field offset: 0xA0
	public string expPierceInterval; //Field offset: 0xA8
	public int count; //Field offset: 0xB0
	public string expCount; //Field offset: 0xB8
	public float minimumTimeDifference; //Field offset: 0xC0
	public string expMinimumTimeDifference; //Field offset: 0xC8
	public string destroyProjectile; //Field offset: 0xD0
	public string expDestroyProjectile; //Field offset: 0xD8
	public GameObject display; //Field offset: 0xE0
	public GameObject expDisplay; //Field offset: 0xE8
	public float displayLifetime; //Field offset: 0xF0
	public string expDisplayLifetime; //Field offset: 0xF8
	public bool displayFullscreen; //Field offset: 0x100
	public string expDisplayFullscreen; //Field offset: 0x108
	public bool useBloonPosition; //Field offset: 0x110
	public string expUseBloonPosition; //Field offset: 0x118

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 1163
	}

	public CreateProjectileOnExhaustPierce() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

