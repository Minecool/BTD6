namespace Assets.Scripts.Models.Powers;

[Implementation(typeof(PowerPro), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PowerProModel : PowerModel
{
	public string powerId; //Field offset: 0x90
	public PowerProUpgradePathModel[] upgrades; //Field offset: 0x98
	public PowerProTowerModel[] powerProTowerModels; //Field offset: 0xA0
	public TowerModel[] towerModels; //Field offset: 0xA8
	public bool isDisabledInBossRush; //Field offset: 0xB0

	public PowerProTowerModel baseProTowerModel
	{
		 get { } //Length: 68
	}

	public virtual string PowerId
	{
		 get { } //Length: 8
	}

	public PowerProModel(string name, int cost, bool canBeActivatedBetweenRounds, SpriteReference icon, int quantity, PowerBehaviorModel[] behaviors, ApplyModModel[] mods, TowerModel baseTower, bool isHidden, int linkedToAchievement, bool showBuffsForTower, bool saveImmediately, string storeNavigateToId, int orderPriority, bool alwaysPlaceAtScreenCentre, string powerId, PowerProUpgradePathModel[] upgrades, TowerModel[] towerModels, PrefabReference animatedIcon, bool isDisabledInBossRush, bool showAsNew, bool isDisabledByGameMode = false) { }

	public virtual Model Clone() { }

	public PowerProTowerModel get_baseProTowerModel() { }

	public virtual string get_PowerId() { }

	public PowerProTowerModel GetProTowerAtUpgrade(GameModel model, int path, int tier) { }

	public virtual bool IsDisabledInBossRush() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

