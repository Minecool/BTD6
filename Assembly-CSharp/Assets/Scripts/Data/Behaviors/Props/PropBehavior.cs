namespace Assets.Scripts.Data.Behaviors.Props;

[CreateAssetMenu(fileName = "PropBehavior", menuName = "BTD6/Behaviors/Props/PropBehavior")]
public class PropBehavior : EntityBehavior<PropBehaviorModel>
{
	[CompilerGenerated]
	private readonly PropBehaviorModel <Def>k__BackingField; //Field offset: 0x28

	public virtual PropBehaviorModel Def
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	public PropBehavior() { }

	[CompilerGenerated]
	public virtual PropBehaviorModel get_Def() { }

	public virtual Model get_Model() { }

}

