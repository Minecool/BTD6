namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities;

public class Ability : TowerBehavior
{
	public Ability parent; //Field offset: 0x98
	public string displayName; //Field offset: 0xA0
	public string expDisplayName; //Field offset: 0xA8
	public string description; //Field offset: 0xB0
	public string expDescription; //Field offset: 0xB8
	public int animationState; //Field offset: 0xC0
	public string expAnimationState; //Field offset: 0xC8
	public float animationOffset; //Field offset: 0xD0
	public string expAnimationOffset; //Field offset: 0xD8
	public GameObject icon; //Field offset: 0xE0
	public GameObject expIcon; //Field offset: 0xE8
	public float cooldown; //Field offset: 0xF0
	public string expCooldown; //Field offset: 0xF8
	public string activateOnPreLeak; //Field offset: 0x100
	public string expActivateOnPreLeak; //Field offset: 0x108
	public string activateOnLeak; //Field offset: 0x110
	public string expActivateOnLeak; //Field offset: 0x118
	public Upgrade addedViaUpgrade; //Field offset: 0x120
	public Upgrade expAddedViaUpgrade; //Field offset: 0x128
	public float cooldownSpeedScale; //Field offset: 0x130
	public string expCooldownSpeedScale; //Field offset: 0x138
	public bool resetCooldownOnUpgrade; //Field offset: 0x140
	public string expResetCooldownOnUpgrade; //Field offset: 0x148
	public int livesCost; //Field offset: 0x150
	public string expLivesCost; //Field offset: 0x158
	public int maxActivationsPerRound; //Field offset: 0x160
	public string expMaxActivationsPerRound; //Field offset: 0x168
	public bool canActivateBetweenRounds; //Field offset: 0x170
	public string expCanActivateBetweenRounds; //Field offset: 0x178
	public bool activateOnLivesLost; //Field offset: 0x180
	public string expActivateOnLivesLost; //Field offset: 0x188
	public bool sharedCooldown; //Field offset: 0x190
	public string expSharedCooldown; //Field offset: 0x198
	public bool dontShowStacked; //Field offset: 0x1A0
	public string expDontShowStacked; //Field offset: 0x1A8
	public bool animateOnMainAttackDisplay; //Field offset: 0x1B0
	public string expAnimateOnMainAttackDisplay; //Field offset: 0x1B8
	public bool restrictAbilityAfterMaxRoundTimer; //Field offset: 0x1C0
	public string expRestrictAbilityAfterMaxRoundTimer; //Field offset: 0x1C8
	public int additionalCharges; //Field offset: 0x1D0
	public string expAdditionalCharges; //Field offset: 0x1D8
	public bool hideAbilityIfInCooldown; //Field offset: 0x1E0
	public string expHideAbilityIfInCooldown; //Field offset: 0x1E8
	public bool startOffCooldown; //Field offset: 0x1F0
	public string expStartOffCooldown; //Field offset: 0x1F8
	public bool alwaysSetAnimationState; //Field offset: 0x200
	public string expAlwaysSetAnimationState; //Field offset: 0x208

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 967
	}

	public Ability() { }

	protected Model[] GatherBehaviors() { }

	public virtual TowerBehaviorModel get_Def() { }

}

