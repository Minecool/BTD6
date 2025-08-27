namespace NinjaKiwi.GUTS.Models;

public class BossRushTowerSettings
{
	public float chance; //Field offset: 0x10
	public bool isBoostedByWaterMap; //Field offset: 0x14
	public bool canPopLead; //Field offset: 0x15
	public bool canPopCamo; //Field offset: 0x16
	public bool canRevealCamo; //Field offset: 0x17
	public bool isCheapTower; //Field offset: 0x18

	public BossRushTowerSettings() { }

}

