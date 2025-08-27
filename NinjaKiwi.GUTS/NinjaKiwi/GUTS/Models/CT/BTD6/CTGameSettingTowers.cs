namespace NinjaKiwi.GUTS.Models.CT.BTD6;

public class CTGameSettingTowers
{
	public float regular; //Field offset: 0x10
	public CTGameSettingRangeLimit regularTowerTypes; //Field offset: 0x18
	public float perTowerCap; //Field offset: 0x20
	public CTGameSettingRangeLimit perTowerCapTowerTypes; //Field offset: 0x28
	public int perTowerMinCount; //Field offset: 0x30
	public int perTowerMaxCount; //Field offset: 0x34
	public CTGameSettingRangeLimit perTowerCapMapTotal; //Field offset: 0x38
	public float maxTowers; //Field offset: 0x40
	public CTGameSettingRangeLimit maxTowersTowerTypes; //Field offset: 0x48
	public CTGameSettingRangeLimit maxTowersMapTotal; //Field offset: 0x50

	public CTGameSettingTowers() { }

}

