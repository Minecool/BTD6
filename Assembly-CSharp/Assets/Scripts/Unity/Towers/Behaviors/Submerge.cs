namespace Assets.Scripts.Unity.Towers.Behaviors;

public class Submerge : TowerBehaviorBuff
{
	public Submerge parent; //Field offset: 0xB8
	public Attack submergeAttack; //Field offset: 0xC0
	public Attack expSubmergeAttack; //Field offset: 0xC8
	public float abilitySpeedScale; //Field offset: 0xD0
	public string expAbilitySpeedScale; //Field offset: 0xD8
	public float globalAbilitySpeedScale; //Field offset: 0xE0
	public string expGlobalAbilitySpeedScale; //Field offset: 0xE8
	public float heroXpScale; //Field offset: 0xF0
	public string expHeroXpScale; //Field offset: 0xF8
	public GameObject attackDisplay; //Field offset: 0x100
	public GameObject expAttackDisplay; //Field offset: 0x108
	public float submergeDepth; //Field offset: 0x110
	public string expSubmergeDepth; //Field offset: 0x118
	public float submergeSpeed; //Field offset: 0x120
	public string expSubmergeSpeed; //Field offset: 0x128
	public AudioClip submergeSound; //Field offset: 0x130
	public AudioClip emergeSound; //Field offset: 0x138
	public int supportMutatorPriority; //Field offset: 0x140
	public string expSupportMutatorPriority; //Field offset: 0x148
	public MonkeySubParagonSupport paragonSupport; //Field offset: 0x150
	public float abilitySpeedScaleParagon; //Field offset: 0x158
	public string expAbilitySpeedScaleParagon; //Field offset: 0x160
	public int animateOnSubmerge; //Field offset: 0x168
	public string expAnimateOnSubmerge; //Field offset: 0x170
	public int animateOnExitSubmerge; //Field offset: 0x178
	public string expAnimateOnExitSubmerge; //Field offset: 0x180
	public Effect submergeEffect; //Field offset: 0x188
	public Effect expSubmergeEffect; //Field offset: 0x190
	public Effect unsubmergeEffect; //Field offset: 0x198
	public Effect expUnsubmergeEffect; //Field offset: 0x1A0

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1209
	}

	public Submerge() { }

	public virtual TowerBehaviorModel get_Def() { }

}

