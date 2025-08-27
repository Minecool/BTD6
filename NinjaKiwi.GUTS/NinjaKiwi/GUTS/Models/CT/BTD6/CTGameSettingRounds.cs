namespace NinjaKiwi.GUTS.Models.CT.BTD6;

public class CTGameSettingRounds
{
	public List<CTGameSettingRangeLimitProportion> startingRound; //Field offset: 0x10
	public CTGameSettingRangeLimit totalRounds; //Field offset: 0x18
	public int hardLimitMaxRound; //Field offset: 0x20

	public CTGameSettingRounds() { }

}

