namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class MorphTower : AbilityBehavior
{
	public MorphTower parent; //Field offset: 0x88
	public bool isUnique; //Field offset: 0x90
	public string expIsUnique; //Field offset: 0x98
	public float priority; //Field offset: 0xA0
	public string expPriority; //Field offset: 0xA8
	public string mutatorId; //Field offset: 0xB0
	public string expMutatorId; //Field offset: 0xB8
	public float lifespan; //Field offset: 0xC0
	public string expLifespan; //Field offset: 0xC8
	public bool mutateAll; //Field offset: 0xD0
	public string expMutateAll; //Field offset: 0xD8
	public bool mutateSelf; //Field offset: 0xE0
	public string expMutateSelf; //Field offset: 0xE8
	public Tower tower; //Field offset: 0xF0
	public Tower expTower; //Field offset: 0xF8
	public Tower secondaryTower; //Field offset: 0x100
	public Tower expSecondaryTower; //Field offset: 0x108
	public Effect effect; //Field offset: 0x110
	public Effect expEffect; //Field offset: 0x118
	public float maxTier; //Field offset: 0x120
	public string expMaxTier; //Field offset: 0x128
	public float maxCost; //Field offset: 0x130
	public string expMaxCost; //Field offset: 0x138
	public float maxTowers; //Field offset: 0x140
	public string expMaxTowers; //Field offset: 0x148
	public string affectList; //Field offset: 0x150
	public string expAffectList; //Field offset: 0x158
	public Effect effectOnTransitionBack; //Field offset: 0x160
	public Effect expEffectOnTransitionBack; //Field offset: 0x168
	public bool resetOnDefeatScreen; //Field offset: 0x170
	public string expResetOnDefeatScreen; //Field offset: 0x178
	public string ignoreWithMutators; //Field offset: 0x180
	public string expIgnoreWithMutators; //Field offset: 0x188

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 893
	}

	public MorphTower() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

