namespace Assets.Scripts.Unity.Powers;

public class PowerPro : Power
{
	private PowerProModel def; //Field offset: 0x70
	public string powerId; //Field offset: 0x78
	public bool isDisabledInBossRush; //Field offset: 0x80

	public PowerProModel Def
	{
		 get { } //Length: 1286
	}

	public PowerPro() { }

	private TowerModel[] GatherTowers() { }

	private PowerProUpgradePathModel[] GatherUpgrades() { }

	public PowerProModel get_Def() { }

}

