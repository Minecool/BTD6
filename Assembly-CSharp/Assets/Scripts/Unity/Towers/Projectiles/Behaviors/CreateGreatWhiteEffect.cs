namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateGreatWhiteEffect : ProjectileBehavior
{
	public CreateGreatWhiteEffect parent; //Field offset: 0x88
	public GameObject display; //Field offset: 0x90
	public GameObject expDisplay; //Field offset: 0x98
	public GameObject bloonDestroyedDisplay; //Field offset: 0xA0
	public GameObject expBloonDestroyedDisplay; //Field offset: 0xA8
	public Effect retreatEffect; //Field offset: 0xB0
	public Effect expRetreatEffect; //Field offset: 0xB8
	public float bloonPopTimeScale; //Field offset: 0xC0
	public string expBloonPopTimeScale; //Field offset: 0xC8
	public float postDragTime; //Field offset: 0xD0
	public string expPostDragTime; //Field offset: 0xD8
	public string maxGrabBloonName; //Field offset: 0xE0
	public string expMaxGrabBloonName; //Field offset: 0xE8
	public int bitingAnimationState; //Field offset: 0xF0
	public string expBitingAnimationState; //Field offset: 0xF8
	public float exitAnimationTime; //Field offset: 0x100
	public string expExitAnimationTime; //Field offset: 0x108
	public int exitAnimationState; //Field offset: 0x110
	public string expExitAnimationState; //Field offset: 0x118
	public float maxMoabGrabTime; //Field offset: 0x120
	public string expMaxMoabGrabTime; //Field offset: 0x128
	public float maxMoabGrabTimeMegalodon; //Field offset: 0x130
	public string expMaxMoabGrabTimeMegalodon; //Field offset: 0x138
	public int moabDamagePerSecond; //Field offset: 0x140
	public string expMoabDamagePerSecond; //Field offset: 0x148
	public float maxMoabDamagePercentPerSecond; //Field offset: 0x150
	public string expMaxMoabDamagePercentPerSecond; //Field offset: 0x158
	public float playRetreatAnimationAt; //Field offset: 0x160
	public string expPlayRetreatAnimationAt; //Field offset: 0x168
	public int readyAnimationState; //Field offset: 0x170
	public string expReadyAnimationState; //Field offset: 0x178
	public Projectile thrashingProjectile; //Field offset: 0x180
	public Projectile expThrashingProjectile; //Field offset: 0x188
	public Projectile bloonFollowProjectile; //Field offset: 0x190
	public Projectile expBloonFollowProjectile; //Field offset: 0x198
	public float thrashingProjectileRate; //Field offset: 0x1A0
	public string expThrashingProjectileRate; //Field offset: 0x1A8
	public Effect thrashingEffect; //Field offset: 0x1B0
	public Effect expThrashingEffect; //Field offset: 0x1B8
	public int noGrabAnimationState; //Field offset: 0x1C0
	public string expNoGrabAnimationState; //Field offset: 0x1C8
	public Effect noGrabEffect; //Field offset: 0x1D0
	public Effect expNoGrabEffect; //Field offset: 0x1D8
	public int maxPullRbe; //Field offset: 0x1E0
	public string expMaxPullRbe; //Field offset: 0x1E8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 854
	}

	public CreateGreatWhiteEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

