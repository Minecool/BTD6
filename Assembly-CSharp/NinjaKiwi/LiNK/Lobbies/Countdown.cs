namespace NinjaKiwi.LiNK.Lobbies;

public abstract class Countdown : IEnumerable<Task`1<Int32>>, IEnumerable
{
	protected int TicksRemaining; //Field offset: 0x10

	protected Countdown(int ticks) { }

	public abstract IEnumerator<Task`1<Int32>> GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

