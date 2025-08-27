namespace Assets.Scripts.Simulation.Objects;

public class TimedBehavior
{
	public RootBehavior behavior; //Field offset: 0x10
	public int removeAt; //Field offset: 0x18
	public string exclusiveId; //Field offset: 0x20

	public TimedBehavior(RootBehavior behavior, int removeAt, string exclusiveId) { }

}

