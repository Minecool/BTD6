namespace Assets.Scripts.Data.Behaviors.Towers;

public abstract class TowerMutator : EntityBehavior<TowerMutatorModel>
{
	public TowerMutator parent; //Field offset: 0x28
	public Conditional conditional; //Field offset: 0x30
	public string mutationId; //Field offset: 0x38

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected TowerMutator() { }

	public virtual Model get_Model() { }

}

