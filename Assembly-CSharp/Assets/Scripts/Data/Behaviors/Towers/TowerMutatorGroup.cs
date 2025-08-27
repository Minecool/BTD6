namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "TowerMutatorGroup", menuName = "BTD6/Behaviors/Towers/TowerMutatorGroup")]
public class TowerMutatorGroup : TowerBehavior
{
	public TowerMutator[] mutators; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 132
	}

	public TowerMutatorGroup() { }

	public virtual TowerBehaviorModel get_Def() { }

}

