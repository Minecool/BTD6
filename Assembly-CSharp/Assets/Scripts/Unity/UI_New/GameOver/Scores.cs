namespace Assets.Scripts.Unity.UI_New.GameOver;

public class Scores
{
	public readonly TimeSpan current; //Field offset: 0x10
	public readonly TimeSpan oldBest; //Field offset: 0x18
	public readonly TimeSpan bestEver; //Field offset: 0x20

	public TimeSpan Best
	{
		 get { } //Length: 133
	}

	public bool IsNewBest
	{
		 get { } //Length: 94
	}

	public Scores(TimeSpan current, TimeSpan oldBest) { }

	public Scores(TimeSpan current, TimeSpan oldBest, TimeSpan bestEver) { }

	public TimeSpan get_Best() { }

	public bool get_IsNewBest() { }

}

