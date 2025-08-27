namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class GyrfalconPattern : TargetTypeBehavior
{
	public GyrfalconPattern parent; //Field offset: 0x98
	public float speed; //Field offset: 0xA0
	public string expSpeed; //Field offset: 0xA8
	public float rotationSpeed; //Field offset: 0xB0
	public string expRotationSpeed; //Field offset: 0xB8
	public int beginMovementAnimationState; //Field offset: 0xC0
	public string expBeginMovementAnimationState; //Field offset: 0xC8
	public int hoverAnimationState; //Field offset: 0xD0
	public string expHoverAnimationState; //Field offset: 0xD8
	public float snapDistance; //Field offset: 0xE0
	public string expSnapDistance; //Field offset: 0xE8
	public float cooldown; //Field offset: 0xF0
	public string expCooldown; //Field offset: 0xF8
	public Damage initialDamage; //Field offset: 0x100
	public Damage expInitialDamage; //Field offset: 0x108
	public Damage grapplingDamage; //Field offset: 0x110
	public Damage expGrapplingDamage; //Field offset: 0x118
	public Projectile grabProjectile; //Field offset: 0x120
	public Projectile expGrabProjectile; //Field offset: 0x128
	public float grappleDamageRate; //Field offset: 0x130
	public string expGrappleDamageRate; //Field offset: 0x138
	public GameObject selectPointDisplay; //Field offset: 0x140
	public GameObject expSelectPointDisplay; //Field offset: 0x148
	public GameObject selectPointDisplayInvalid; //Field offset: 0x150
	public GameObject expSelectPointDisplayInvalid; //Field offset: 0x158
	public int leadPiercePenalty; //Field offset: 0x160
	public string expLeadPiercePenalty; //Field offset: 0x168
	public int ceramicPiercePenalty; //Field offset: 0x170
	public string expCeramicPiercePenalty; //Field offset: 0x178
	public int moabPiercePenalty; //Field offset: 0x180
	public string expMoabPiercePenalty; //Field offset: 0x188
	public int bfbPiercePenalty; //Field offset: 0x190
	public string expBfbPiercePenalty; //Field offset: 0x198
	public int zomgPiercePenalty; //Field offset: 0x1A0
	public string expZomgPiercePenalty; //Field offset: 0x1A8
	public int ddtPiercePenalty; //Field offset: 0x1B0
	public string expDdtPiercePenalty; //Field offset: 0x1B8
	public bool continuePickingUpBloons; //Field offset: 0x1C0
	public string expContinuePickingUpBloons; //Field offset: 0x1C8
	public float moabSpeedScale; //Field offset: 0x1D0
	public string expMoabSpeedScale; //Field offset: 0x1D8
	public bool enableAdjacentHover; //Field offset: 0x1E0
	public string expEnableAdjacentHover; //Field offset: 0x1E8
	public bool keepPickingUpBloons; //Field offset: 0x1F0
	public string expKeepPickingUpBloons; //Field offset: 0x1F8
	public int snatchHoverAnimationState; //Field offset: 0x200
	public string expSnatchHoverAnimationState; //Field offset: 0x208
	public int snatchFlyingAnimationState; //Field offset: 0x210
	public string expSnatchFlyingAnimationState; //Field offset: 0x218
	public int handlerSendAnimationState; //Field offset: 0x220
	public string expHandlerSendAnimationState; //Field offset: 0x228
	public int handlerHoverAnimationState; //Field offset: 0x230
	public string expHandlerHoverAnimationState; //Field offset: 0x238
	public float bloonTargetSpeedMultiplier; //Field offset: 0x240
	public string expBloonTargetSpeedMultiplier; //Field offset: 0x248
	public DamageModifierForTag initialDamageMoabModifier; //Field offset: 0x250
	public DamageModifierForTag expInitialDamageMoabModifier; //Field offset: 0x258
	public DamageModifierForTag grapplingDamageMoabModifier; //Field offset: 0x260
	public DamageModifierForTag expGrapplingDamageMoabModifier; //Field offset: 0x268
	public DamageModifierForTag regrowDamageModifier; //Field offset: 0x270
	public DamageModifierForTag expRegrowDamageModifier; //Field offset: 0x278
	public float idleMinTime; //Field offset: 0x280
	public string expIdleMinTime; //Field offset: 0x288
	public float idleMaxTime; //Field offset: 0x290
	public string expIdleMaxTime; //Field offset: 0x298
	public float initialYOffset; //Field offset: 0x2A0
	public string expInitialYOffset; //Field offset: 0x2A8
	public float keepPickingBloonsRange; //Field offset: 0x2B0
	public string expKeepPickingBloonsRange; //Field offset: 0x2B8
	public Effect noGrabEffect; //Field offset: 0x2C0
	public Effect expNoGrabEffect; //Field offset: 0x2C8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 2200
	}

	public GyrfalconPattern() { }

	public virtual AttackBehaviorModel get_Def() { }

}

