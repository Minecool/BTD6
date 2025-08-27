namespace Assets.Scripts.Data.Behaviors.Mutators;

[CreateAssetMenu(fileName = "PierceTowerMutator", menuName = "BTD6/Behaviors/Mutators/PierceTowerMutator")]
public class PierceTowerMutator : TowerMutator
{
	public int pierce; //Field offset: 0x38
	public float lifespan; //Field offset: 0x3C

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 305
	}

	public PierceTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

