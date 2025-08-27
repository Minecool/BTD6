namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateGreatWhiteEffect", menuName = "BTD6/Behaviors/Projectiles/CreateGreatWhiteEffect")]
public class CreateGreatWhiteEffect : ProjectileBehavior
{
	public PrefabReference display; //Field offset: 0x30
	public PrefabReference bloonDestroyedDisplay; //Field offset: 0x38
	public Effect retreatEffect; //Field offset: 0x40
	public float bloonPopTimeScale; //Field offset: 0x48
	public float postDragTime; //Field offset: 0x4C
	public string maxGrabBloonName; //Field offset: 0x50
	public int bitingAnimationState; //Field offset: 0x58
	public float exitAnimationTime; //Field offset: 0x5C
	public int exitAnimationState; //Field offset: 0x60
	public float maxMoabGrabTime; //Field offset: 0x64
	public float maxMoabGrabTimeMegalodon; //Field offset: 0x68
	public int moabDamagePerSecond; //Field offset: 0x6C
	public float maxMoabDamagePercentPerSecond; //Field offset: 0x70
	public float playRetreatAnimationAt; //Field offset: 0x74
	public int readyAnimationState; //Field offset: 0x78
	public Projectile thrashingProjectile; //Field offset: 0x80
	public Projectile bloonFollowProjectile; //Field offset: 0x88
	public float thrashingProjectileRate; //Field offset: 0x90
	public Effect thrashingEffect; //Field offset: 0x98
	public int noGrabAnimationState; //Field offset: 0xA0
	public Effect noGrabEffect; //Field offset: 0xA8
	public int maxPullRbe; //Field offset: 0xB0

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 817
	}

	public CreateGreatWhiteEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

