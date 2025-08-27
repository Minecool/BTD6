namespace Assets.Scripts.ContestedTerritory;

public class InfiniteLoopHelper
{
	private int loopCount; //Field offset: 0x10
	private readonly int threshold; //Field offset: 0x14

	public bool CanLoop
	{
		 get { } //Length: 10
	}

	public InfiniteLoopHelper(int threshold) { }

	public bool get_CanLoop() { }

	public bool Loop() { }

}

