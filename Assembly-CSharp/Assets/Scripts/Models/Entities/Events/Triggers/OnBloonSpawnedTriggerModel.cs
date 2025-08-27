namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnBloonSpawnedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnBloonSpawnedTriggerModel : EntityTriggerModel
{
	public String[] bloonIds; //Field offset: 0x38
	public bool camoOnly; //Field offset: 0x40
	public bool regrowOnly; //Field offset: 0x41
	public bool fortifiedOnly; //Field offset: 0x42
	public bool moabOnly; //Field offset: 0x43
	public bool inverseChecks; //Field offset: 0x44

	public OnBloonSpawnedTriggerModel(string name, String[] bloonIds, bool camoOnly, bool regrowOnly, bool fortifiedOnly, bool moabOnly, bool inverseChecks) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

