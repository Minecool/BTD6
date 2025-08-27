namespace Assets.Scripts.Models.Towers.Behaviors.Abilities;

[Implementation(typeof(Ability), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AbilityModel : TowerBehaviorModel
{
	public string displayName; //Field offset: 0x30
	public string description; //Field offset: 0x38
	public SpriteReference icon; //Field offset: 0x40
	[SerializeReference]
	public Model[] behaviors; //Field offset: 0x48
	public bool activateOnPreLeak; //Field offset: 0x50
	public bool activateOnLeak; //Field offset: 0x51
	public string addedViaUpgrade; //Field offset: 0x58
	public int livesCost; //Field offset: 0x60
	public int maxActivationsPerRound; //Field offset: 0x64
	public int animation; //Field offset: 0x68
	public bool enabled; //Field offset: 0x6C
	public bool canActivateBetweenRounds; //Field offset: 0x6D
	public bool resetCooldownOnTierUpgrade; //Field offset: 0x6E
	public bool activateOnLivesLost; //Field offset: 0x6F
	public bool sharedCooldown; //Field offset: 0x70
	public bool dontShowStacked; //Field offset: 0x71
	public bool animateOnMainAttackDisplay; //Field offset: 0x72
	public int additionalCharges; //Field offset: 0x74
	public bool hideAbilityIfInCooldown; //Field offset: 0x78
	public bool startOffCooldown; //Field offset: 0x79
	public bool alwaysSetAnimationState; //Field offset: 0x7A
	public int rechargeMonkeyMoneyCost; //Field offset: 0x7C
	public bool restrictAbilityAfterMaxRoundTimer; //Field offset: 0x80
	[SerializeField]
	private float cooldownSpeedScale; //Field offset: 0x84
	[SerializeField]
	private float animationOffset; //Field offset: 0x88
	public int animationOffsetFrames; //Field offset: 0x8C
	[SerializeField]
	private float cooldown; //Field offset: 0x90
	public int cooldownFrames; //Field offset: 0x94

	public float AnimationOffset
	{
		 get { } //Length: 9
		 set { } //Length: 27
	}

	public float Cooldown
	{
		 get { } //Length: 9
		 set { } //Length: 27
	}

	public float CooldownSpeedScale
	{
		 get { } //Length: 9
		 set { } //Length: 28
	}

	public bool IsPassive
	{
		 get { } //Length: 20
	}

	public AbilityModel(string name, string displayName, string description, int animation, float animationOffset, SpriteReference icon, float cooldown, Model[] behaviors, bool activateOnPreLeak, bool activateOnLeak, string addedViaUpgrade, float cooldownSpeedScale, int livesCost, int maxActivationsPerRound, bool resetCooldownOnTierUpgrade, bool activateOnLivesLost, bool enabled = true, bool canActivateBetweenRounds = false, bool sharedCooldown = false, bool dontShowStacked = false, bool animateOnMainAttackDisplay = false, bool restrictAbilityAfterMaxRoundTimer = false, int additionalCharges = 0, bool hideAbilityIfInCooldown = false, bool startOffCooldown = false, bool alwaysSetAnimationState = false, int rechargeMonkeyMoneyCost = 0) { }

	public virtual Model[] BehaviorModels() { }

	public virtual Model Clone() { }

	public float get_AnimationOffset() { }

	public float get_Cooldown() { }

	public float get_CooldownSpeedScale() { }

	public bool get_IsPassive() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_AnimationOffset(float value) { }

	public void set_Cooldown(float value) { }

	public void set_CooldownSpeedScale(float value) { }

	public virtual void SetBehaviorModels(Model[] behaviors) { }

}

