namespace Assets.Scripts.Simulation.Behaviors;

public class Viewer : RootBehavior
{
	internal struct IdObjectMap
	{
		public ObjectId id; //Field offset: 0x0
		public T obj; //Field offset: 0x0

	}

	protected readonly List<IdObjectMap<T>> viewing; //Field offset: 0x0
	protected readonly List<T> sampler; //Field offset: 0x0
	private ForEachDelegate<T> enter; //Field offset: 0x0
	private ForEachDelegate<T> exit; //Field offset: 0x0

	public Viewer`1() { }

	public override void Initialise(ForEachDelegate<T> enter, ForEachDelegate<T> exit) { }

	protected virtual void OnDestroy() { }

	protected override void Process(int elapsed) { }

}

