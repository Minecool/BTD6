namespace Assets.Scripts.Models.Map.Actions;

public class MapActionModel : Model
{
	public string saveId; //Field offset: 0x30

	protected MapActionModel(string name) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

