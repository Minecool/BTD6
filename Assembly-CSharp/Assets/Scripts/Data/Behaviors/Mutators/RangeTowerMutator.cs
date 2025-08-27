namespace Assets.Scripts.Data.Behaviors.Mutators;

[CreateAssetMenu(fileName = "RangeTowerMutator", menuName = "BTD6/Behaviors/Mutators/RangeTowerMutator")]
public class RangeTowerMutator : TowerMutator
{
	public float rangeIncrease; //Field offset: 0x38
	public float lifespan; //Field offset: 0x3C

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 310
	}

	public RangeTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

