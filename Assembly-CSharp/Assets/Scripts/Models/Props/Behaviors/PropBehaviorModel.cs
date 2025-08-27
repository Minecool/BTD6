namespace Assets.Scripts.Models.Props.Behaviors;

public class PropBehaviorModel : EntityBehaviorModel
{

	protected PropBehaviorModel(string name) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

