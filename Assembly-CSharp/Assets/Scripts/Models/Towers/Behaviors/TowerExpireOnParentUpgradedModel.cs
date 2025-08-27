namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TowerExpireOnParentUpgraded), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TowerExpireOnParentUpgradedModel : TowerBehaviorModel
{
	public int parentTowerUpgradeTier; //Field offset: 0x30

	public TowerExpireOnParentUpgradedModel(string name, int parentTowerUpgradeTier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

