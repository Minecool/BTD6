namespace Assets.Scripts.Models.ServerEvents;

public class MonkeyTeams : EnableFlag
{
	public TimeSpan mapRotationTime; //Field offset: 0x18
	public TimeSpan teamRotationTime; //Field offset: 0x20
	public Dictionary<MapDifficulty, Dictionary`2<Int32, Int32>> rewards; //Field offset: 0x28

	public MonkeyTeams() { }

	public int GetRewards(MapDifficulty mapDifficulty, int roundFinished) { }

}

