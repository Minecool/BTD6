namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnTowerUpgradedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnTowerUpgradedTriggerModel : EntityTriggerModel
{
	public String[] towerIds; //Field offset: 0x38
	public int selectedPath; //Field offset: 0x40
	public int tier; //Field offset: 0x44
	public bool includeTiersAbove; //Field offset: 0x48

	public OnTowerUpgradedTriggerModel(string name, String[] towerIds, int selectedPath, int tier, bool includeTiersAbove) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

