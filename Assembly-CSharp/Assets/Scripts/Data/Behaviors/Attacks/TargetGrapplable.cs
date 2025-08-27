namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetGrapplable", menuName = "BTD6/Behaviors/Attacks/TargetGrapplable")]
public class TargetGrapplable : TargetTypeBehavior
{
	public int hooks; //Field offset: 0x38
	public int zomgHooksRequired; //Field offset: 0x3C
	public int badHooksRequired; //Field offset: 0x40
	public GrappleEmission grappleEmission; //Field offset: 0x48

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 326
	}

	public TargetGrapplable() { }

	public virtual AttackBehaviorModel get_Def() { }

}

