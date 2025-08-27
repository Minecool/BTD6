namespace Assets.Scripts.Data.Behaviors.Mutators;

[CreateAssetMenu(fileName = "DamageTowerMutator", menuName = "BTD6/Behaviors/Mutators/DamageTowerMutator")]
public class DamageTowerMutator : TowerMutator
{
	public float damage; //Field offset: 0x38
	public float lifespan; //Field offset: 0x3C

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 310
	}

	public DamageTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

