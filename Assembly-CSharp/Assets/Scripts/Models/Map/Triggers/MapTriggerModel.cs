namespace Assets.Scripts.Models.Map.Triggers;

public class MapTriggerModel : Model
{
	public string saveId; //Field offset: 0x30

	protected MapTriggerModel(string name) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

