namespace Assets.Scripts.Models.ServerEvents;

public class GameEventFrequency
{
	public Nullable<TimeSpan> ctEvents; //Field offset: 0x10
	public Nullable<TimeSpan> bossEvents; //Field offset: 0x20
	public Nullable<TimeSpan> bossRushEvents; //Field offset: 0x30
	public Nullable<TimeSpan> collectionEvents; //Field offset: 0x40
	public Nullable<TimeSpan> raceEvents; //Field offset: 0x50
	public Nullable<TimeSpan> odysseyEvents; //Field offset: 0x60

	public GameEventFrequency() { }

}

