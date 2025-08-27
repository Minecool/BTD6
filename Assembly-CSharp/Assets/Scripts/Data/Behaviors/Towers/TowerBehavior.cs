namespace Assets.Scripts.Data.Behaviors.Towers;

public abstract class TowerBehavior : EntityBehavior<TowerBehaviorModel>
{
	[CompilerGenerated]
	private readonly TowerBehaviorModel <Def>k__BackingField; //Field offset: 0x28

	[JsonIgnore]
	public virtual TowerBehaviorModel Def
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected TowerBehavior() { }

	[CompilerGenerated]
	public virtual TowerBehaviorModel get_Def() { }

}

