namespace Assets.Scripts.Unity.Towers.Mutators;

public abstract class TowerMutator : CascadingItemProxy
{
	public TowerMutator parent; //Field offset: 0x88
	public Conditional conditional; //Field offset: 0x90
	public Conditional expConditional; //Field offset: 0x98
	public string mutationId; //Field offset: 0xA0
	public string expMutationId; //Field offset: 0xA8

	public abstract TowerMutatorModel Def
	{
		 get { } //Length: 0
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected TowerMutator() { }

	public abstract TowerMutatorModel get_Def() { }

	public virtual Model get_Model() { }

}

