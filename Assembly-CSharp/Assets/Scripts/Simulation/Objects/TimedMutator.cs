namespace Assets.Scripts.Simulation.Objects;

public class TimedMutator
{
	public BehaviorMutator mutator; //Field offset: 0x10
	public int removeAt; //Field offset: 0x18
	public bool onlyTimeoutWhenActive; //Field offset: 0x1C
	public bool useRoundTime; //Field offset: 0x1D
	public bool includeSubTowers; //Field offset: 0x1E
	public int roundsRemaining; //Field offset: 0x20
	public bool isParagonMutator; //Field offset: 0x24
	public bool cantBeAbsorbed; //Field offset: 0x25
	private readonly int totalDuration; //Field offset: 0x28

	public int TotalDuration
	{
		 get { } //Length: 4
	}

	public TimedMutator(BehaviorMutator mutator, int removeAt, bool onlyTimeoutWhenActive, bool useRoundTime, bool includeSubTowers, int roundsRemaining, bool isParagonMutator, bool cantBeAbsorbed) { }

	public int get_TotalDuration() { }

}

