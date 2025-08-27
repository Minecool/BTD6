namespace Assets.Scripts.Models.Profile;

public class PowersProSaveData
{
	public bool isEnabled; //Field offset: 0x10
	public Dictionary<String, PowersProPowerSaveData> dataByPower; //Field offset: 0x18
	public KonFuze seenInfoPopup; //Field offset: 0x20

	public PowersProSaveData() { }

}

