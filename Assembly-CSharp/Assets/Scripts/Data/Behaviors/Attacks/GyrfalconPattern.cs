namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "GyrfalconPattern", menuName = "BTD6/Behaviors/Attacks/GyrfalconPattern")]
public class GyrfalconPattern : TargetTypeBehavior
{
	public float speed; //Field offset: 0x38
	public float rotationSpeed; //Field offset: 0x3C
	public int beginMovementAnimationState; //Field offset: 0x40
	public int hoverAnimationState; //Field offset: 0x44
	public float snapDistance; //Field offset: 0x48
	public float cooldown; //Field offset: 0x4C
	[SerializeReference]
	public Damage initialDamage; //Field offset: 0x50
	[SerializeReference]
	public Damage grapplingDamage; //Field offset: 0x58
	[SerializeReference]
	public Projectile grabProjectile; //Field offset: 0x60
	public float grappleDamageRate; //Field offset: 0x68
	public PrefabReference selectPointDisplay; //Field offset: 0x70
	public PrefabReference selectPointDisplayInvalid; //Field offset: 0x78
	public int leadPiercePenalty; //Field offset: 0x80
	public int ceramicPiercePenalty; //Field offset: 0x84
	public int moabPiercePenalty; //Field offset: 0x88
	public int bfbPiercePenalty; //Field offset: 0x8C
	public int zomgPiercePenalty; //Field offset: 0x90
	public int ddtPiercePenalty; //Field offset: 0x94
	public bool continuePickingUpBloons; //Field offset: 0x98
	public float moabSpeedScale; //Field offset: 0x9C
	public bool enableAdjacentHover; //Field offset: 0xA0
	public bool keepPickingUpBloons; //Field offset: 0xA1
	public int snatchHoverAnimationState; //Field offset: 0xA4
	public int snatchFlyingAnimationState; //Field offset: 0xA8
	public int handlerSendAnimationState; //Field offset: 0xAC
	public int handlerHoverAnimationState; //Field offset: 0xB0
	public float bloonTargetSpeedMultiplier; //Field offset: 0xB4
	[SerializeReference]
	public DamageModifierForTag initialDamageMoabModifier; //Field offset: 0xB8
	[SerializeReference]
	public DamageModifierForTag grapplingDamageMoabModifier; //Field offset: 0xC0
	[SerializeReference]
	public DamageModifierForTag regrowDamageModifier; //Field offset: 0xC8
	public float idleMinTime; //Field offset: 0xD0
	public float idleMaxTime; //Field offset: 0xD4
	public float initialYOffset; //Field offset: 0xD8
	public float keepPickingBloonsRange; //Field offset: 0xDC
	[SerializeReference]
	public Effect noGrabEffect; //Field offset: 0xE0
	public float grabRadius; //Field offset: 0xE8
	public int grabAmount; //Field offset: 0xEC

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 2131
	}

	public GyrfalconPattern() { }

	public virtual AttackBehaviorModel get_Def() { }

}

