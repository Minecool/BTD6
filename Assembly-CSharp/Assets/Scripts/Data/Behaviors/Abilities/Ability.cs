namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "Ability", menuName = "BTD6/Behaviors/Abilities/Ability", order = 0)]
public class Ability : EntityBehavior<TowerBehaviorModel>
{
	public string displayName; //Field offset: 0x28
	public string description; //Field offset: 0x30
	public int animationState; //Field offset: 0x38
	public float animationOffset; //Field offset: 0x3C
	public SpriteReference icon; //Field offset: 0x40
	public float cooldown; //Field offset: 0x48
	public string activateOnPreLeak; //Field offset: 0x50
	public string activateOnLeak; //Field offset: 0x58
	public Upgrade addedViaUpgrade; //Field offset: 0x60
	public float cooldownSpeedScale; //Field offset: 0x68
	public bool resetCooldownOnUpgrade; //Field offset: 0x6C
	public int livesCost; //Field offset: 0x70
	public int maxActivationsPerRound; //Field offset: 0x74
	public bool canActivateBetweenRounds; //Field offset: 0x78
	public bool activateOnLivesLost; //Field offset: 0x79
	public bool sharedCooldown; //Field offset: 0x7A
	public bool dontShowStacked; //Field offset: 0x7B
	public bool animateOnMainAttackDisplay; //Field offset: 0x7C
	public bool restrictAbilityAfterMaxRoundTimer; //Field offset: 0x7D
	public int additionalCharges; //Field offset: 0x80
	[JsonConverter(typeof(BehaviorConverter))]
	public AbilityBehavior[] abilityBehaviors; //Field offset: 0x88

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 790
	}

	public Ability() { }

	protected Model[] GatherBehaviors() { }

	public virtual TowerBehaviorModel get_Def() { }

	public void OnEnable() { }

}

