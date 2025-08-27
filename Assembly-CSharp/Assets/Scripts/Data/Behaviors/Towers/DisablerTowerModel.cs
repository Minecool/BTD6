namespace Assets.Scripts.Data.Behaviors.Towers;

public class DisablerTowerModel : Model
{

	public DisablerTowerModel(string name) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

