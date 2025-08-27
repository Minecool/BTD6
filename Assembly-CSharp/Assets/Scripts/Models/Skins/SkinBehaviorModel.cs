namespace Assets.Scripts.Models.Skins;

public class SkinBehaviorModel : Model
{

	public SkinBehaviorModel(string name) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

