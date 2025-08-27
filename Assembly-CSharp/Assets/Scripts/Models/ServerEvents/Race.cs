namespace Assets.Scripts.Models.ServerEvents;

public class Race
{
	public DailyChallengeModel challenge; //Field offset: 0x10
	public int price; //Field offset: 0x18
	public int waitTime; //Field offset: 0x1C
	public int freeEntries; //Field offset: 0x20
	public string rewards; //Field offset: 0x28

	public Race() { }

}

