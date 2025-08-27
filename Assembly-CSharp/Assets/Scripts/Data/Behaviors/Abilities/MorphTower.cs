namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "MorphTower", menuName = "BTD6/Behaviors/Abilities/MorphTower")]
public class MorphTower : AbilityBehavior
{
	public bool isUnique; //Field offset: 0x30
	public float priority; //Field offset: 0x34
	public string mutatorId; //Field offset: 0x38
	public float lifespan; //Field offset: 0x40
	public bool mutateAll; //Field offset: 0x44
	public bool mutateSelf; //Field offset: 0x45
	public Tower tower; //Field offset: 0x48
	public Tower secondaryTower; //Field offset: 0x50
	public Effect effect; //Field offset: 0x58
	public float maxTier; //Field offset: 0x60
	public float maxCost; //Field offset: 0x64
	public float maxTowers; //Field offset: 0x68
	public string affectList; //Field offset: 0x70
	public Effect effectOnTransitionBack; //Field offset: 0x78
	public bool resetOnDefeatScreen; //Field offset: 0x80
	public string ignoreWithMutators; //Field offset: 0x88

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 839
	}

	public MorphTower() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

