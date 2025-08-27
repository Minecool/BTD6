namespace Assets.Scripts.Unity.Towers;

public class TowerBehavior : EntityBehavior<TowerBehaviorModel>
{
	public GameObject throwMarker; //Field offset: 0x88
	[CompilerGenerated]
	private readonly TowerBehaviorModel <Def>k__BackingField; //Field offset: 0x90

	public virtual TowerBehaviorModel Def
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	public TowerBehavior() { }

	[CompilerGenerated]
	public virtual TowerBehaviorModel get_Def() { }

	public virtual Model get_Model() { }

}

