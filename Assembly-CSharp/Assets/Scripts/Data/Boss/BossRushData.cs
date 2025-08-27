namespace Assets.Scripts.Data.Boss;

[CreateAssetMenu(fileName = "BossRushData", menuName = "BTD6/RushData")]
public class BossRushData : ScriptableObject
{
	public int numAllowedLeaks; //Field offset: 0x18
	public int numRoundsBeforeSpawningTarget; //Field offset: 0x1C
	public int milestoneRoundFrequency; //Field offset: 0x20
	public bool useTrackLengthBasedBossSpeed; //Field offset: 0x24
	public string roundset; //Field offset: 0x28
	public List<ContestedTerritoryRelicType> relics; //Field offset: 0x30
	public BossRushScriptable[] bossSettings; //Field offset: 0x38
	public String[] availablePowers; //Field offset: 0x40

	public BossRushData() { }

}

