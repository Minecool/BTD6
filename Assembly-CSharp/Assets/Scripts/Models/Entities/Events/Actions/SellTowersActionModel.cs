namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(SellTowersAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SellTowersActionModel : EntityActionModel
{
	public float range; //Field offset: 0x38
	public string towerId; //Field offset: 0x40

	public SellTowersActionModel(string name, float range, string towerId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

