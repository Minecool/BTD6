namespace Assets.Scripts.Data.Behaviors.Mutators;

[CreateAssetMenu(fileName = "WindChanceTowerMutator", menuName = "BTD6/Behaviors/Mutators/WindChanceTowerMutator")]
public class WindChanceTowerMutator : TowerMutator
{
	public float chanceIncrease; //Field offset: 0x38
	public float lifespan; //Field offset: 0x3C

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 310
	}

	public WindChanceTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

