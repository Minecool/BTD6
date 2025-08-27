namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(UpgradeTowersAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class UpgradeTowersActionModel : EntityActionModel
{
	public int amount; //Field offset: 0x38
	public float range; //Field offset: 0x3C
	public string towerId; //Field offset: 0x40
	public int path; //Field offset: 0x48

	public UpgradeTowersActionModel(string name, int amount, float range, string towerId, int path) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

