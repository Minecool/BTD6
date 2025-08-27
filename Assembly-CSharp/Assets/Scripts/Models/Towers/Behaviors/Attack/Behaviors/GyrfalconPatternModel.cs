namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(GyrfalconPattern), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GyrfalconPatternModel : TargetSupplierModel
{
	internal class AddBehaviorToBloonMutator : BehaviorMutator
	{
		private readonly MoveWithAirUnitModel behavior; //Field offset: 0x70

		public AddBehaviorToBloonMutator(string id, MoveWithAirUnitModel behavior) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorId = "Gyrfalcon"; //Field offset: 0x0
	public float maxSpeed; //Field offset: 0x38
	public float rotationSpeed; //Field offset: 0x3C
	public int beginMovementAnimationState; //Field offset: 0x40
	public int hoverAnimationState; //Field offset: 0x44
	public float snapDistance; //Field offset: 0x48
	public float cooldown; //Field offset: 0x4C
	public int cooldownFrames; //Field offset: 0x50
	public DamageModel initialDamageModel; //Field offset: 0x58
	public DamageModel grapplingDamageModel; //Field offset: 0x60
	public ProjectileModel grabProjectileModel; //Field offset: 0x68
	public float grappleDamageRate; //Field offset: 0x70
	public int grappleDamageRateFrames; //Field offset: 0x74
	public PrefabReference selectPointDisplay; //Field offset: 0x78
	public PrefabReference selectPointDisplayInvalid; //Field offset: 0x80
	public int leadPiercePenalty; //Field offset: 0x88
	public int ceramicPiercePenalty; //Field offset: 0x8C
	public int moabPiercePenalty; //Field offset: 0x90
	public int bfbPiercePenalty; //Field offset: 0x94
	public int zomgPiercePenalty; //Field offset: 0x98
	public int ddtPiercePenalty; //Field offset: 0x9C
	public bool continuePickingUpBloons; //Field offset: 0xA0
	public float moabSpeedScale; //Field offset: 0xA4
	public bool enableAdjacentHover; //Field offset: 0xA8
	public bool keepPickingUpBloons; //Field offset: 0xA9
	public int snatchHoverAnimationState; //Field offset: 0xAC
	public int snatchFlyingAnimationState; //Field offset: 0xB0
	public int handlerSendAnimationState; //Field offset: 0xB4
	public int handlerHoverAnimationState; //Field offset: 0xB8
	public float bloonTargetSpeedMultiplier; //Field offset: 0xBC
	public DamageModifierForTagModel initialDamageMoabModifierModel; //Field offset: 0xC0
	public DamageModifierForTagModel grapplingDamageMoabModifierModel; //Field offset: 0xC8
	public DamageModifierForTagModel regrowDamageModifierModel; //Field offset: 0xD0
	public float idleMinTime; //Field offset: 0xD8
	public int idleMinTimeFrames; //Field offset: 0xDC
	public float idleMaxTime; //Field offset: 0xE0
	public int idleMaxTimeFrames; //Field offset: 0xE4
	public float initialYOffset; //Field offset: 0xE8
	public float keepPickingBloonsRange; //Field offset: 0xEC
	public EffectModel noGrabEffectModel; //Field offset: 0xF0
	public float grabRadius; //Field offset: 0xF8
	public int grabAmount; //Field offset: 0xFC
	private MoveWithAirUnitModel moveWithAirUnitModel; //Field offset: 0x100
	public float extraGrabAmount; //Field offset: 0x108
	private AddBehaviorToBloonMutator _mutator; //Field offset: 0x110

	public AddBehaviorToBloonMutator mutator
	{
		 get { } //Length: 253
	}

	public GyrfalconPatternModel(string name, float maxSpeed, float rotationSpeed, int beginMovementAnimationState, int hoverAnimationState, float snapDistance, float cooldown, DamageModel initialDamageModel, DamageModel grapplingDamageModel, ProjectileModel grabProjectileModel, float grappleDamageRate, PrefabReference selectPointDisplay, PrefabReference selectPointDisplayInvalid, int leadPiercePenalty, int ceramicPiercePenalty, int moabPiercePenalty, int bfbPiercePenalty, int zomgPiercePenalty, int ddtPiercePenalty, bool continuePickingUpBloons, float moabSpeedScale, bool enableAdjacentHover, bool keepPickingUpBloons, int snatchHoverAnimationState, int snatchFlyingAnimationState, int handlerSendAnimationState, int handlerHoverAnimationState, float bloonTargetSpeedMultiplier, DamageModifierForTagModel initialDamageMoabModifierModel, DamageModifierForTagModel grapplingDamageMoabModifierModel, DamageModifierForTagModel regrowDamageModifierModel, float idleMinTime, float idleMaxTime, float initialYOffset, float keepPickingBloonsRange, EffectModel noGrabEffectModel, float grabRadius, int grabAmount, float extraGrabAmount = 0) { }

	public virtual Model Clone() { }

	public AddBehaviorToBloonMutator get_mutator() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	public virtual string GetTargetTypeCustomInputClass() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

