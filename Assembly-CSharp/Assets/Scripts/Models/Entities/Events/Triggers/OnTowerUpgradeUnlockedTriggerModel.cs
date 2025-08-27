namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnTowerUpgradeUnlockedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnTowerUpgradeUnlockedTriggerModel : EntityTriggerModel
{
	public String[] towerIds; //Field offset: 0x38
	public int path; //Field offset: 0x40

	public OnTowerUpgradeUnlockedTriggerModel(string name, String[] towerIds, int path = -1) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

