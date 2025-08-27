namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(SendBloonAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SendBloonActionModel : EntityActionModel
{
	public string bloonId; //Field offset: 0x38
	public bool camo; //Field offset: 0x40
	public bool regrow; //Field offset: 0x41
	public bool fortified; //Field offset: 0x42

	public SendBloonActionModel(string name, string bloonId, bool camo, bool regrow, bool fortified) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

