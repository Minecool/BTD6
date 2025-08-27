namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "AbilityBehavior", menuName = "BTD6/Behaviors/Abilities/AbilityBehavior")]
public class AbilityBehavior : EntityBehavior<AbilityBehaviorModel>
{
	[CompilerGenerated]
	private readonly AbilityBehaviorModel <Def>k__BackingField; //Field offset: 0x28

	public virtual AbilityBehaviorModel Def
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override Display Display
	{
		 get { } //Length: 3
	}

	public AbilityBehavior() { }

	[CompilerGenerated]
	public virtual AbilityBehaviorModel get_Def() { }

	public override Display get_Display() { }

}

