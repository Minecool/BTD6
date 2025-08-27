namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateProjectilesAlongPathWhenClose : ProjectileBehavior
{
	private CreateProjectilesAlongPathWhenClose parent; //Field offset: 0x88
	public Projectile projectile; //Field offset: 0x90
	public Projectile expProjectile; //Field offset: 0x98
	public Emission emission; //Field offset: 0xA0
	public Emission expEmission; //Field offset: 0xA8
	public int amountOfProjectilesPerPath; //Field offset: 0xB0
	public string expAmountOfProjectilesPerPath; //Field offset: 0xB8
	public float range; //Field offset: 0xC0
	public string expRange; //Field offset: 0xC8
	public Effect emitProjectileEffect; //Field offset: 0xD0
	public Effect expEmitProjectileEffect; //Field offset: 0xD8
	public float projectileLandingEffectDelay; //Field offset: 0xE0
	public string expProjectileLandingEffectDelay; //Field offset: 0xE8
	public Effect projectileLandingEffect; //Field offset: 0xF0
	public Effect expProjectileLandingEffect; //Field offset: 0xF8
	public float projectileCreationDelay; //Field offset: 0x100
	public string expProjectileCreationDelay; //Field offset: 0x108
	public int fireProjectileTowerAnimationState; //Field offset: 0x110
	public string expFireProjectileTowerAnimationState; //Field offset: 0x118
	public AudioClip fireProjectileSound1; //Field offset: 0x120
	public AudioClip expFireProjectileSound1; //Field offset: 0x128
	public AudioClip fireProjectileSound2; //Field offset: 0x130
	public AudioClip expFireProjectileSound2; //Field offset: 0x138
	public AudioClip fireProjectileSound3; //Field offset: 0x140
	public AudioClip expFireProjectileSound3; //Field offset: 0x148
	public AudioClip fireProjectileSound4; //Field offset: 0x150
	public AudioClip expFireProjectileSound4; //Field offset: 0x158
	public AudioClip fireProjectileSound5; //Field offset: 0x160
	public AudioClip expFireProjectileSound5; //Field offset: 0x168

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 1318
	}

	public CreateProjectilesAlongPathWhenClose() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

