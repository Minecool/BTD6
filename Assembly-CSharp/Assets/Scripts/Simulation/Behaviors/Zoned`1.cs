namespace Assets.Scripts.Simulation.Behaviors;

public class Zoned : Viewer<T>
{
	private TransformBehavior transform; //Field offset: 0x0
	private GetRangeDelegate getRange; //Field offset: 0x0
	private ForEachDelegate<T> zoneEnter; //Field offset: 0x0
	private ForEachDelegate<T> zoneExit; //Field offset: 0x0
	private ViewFilter filter; //Field offset: 0x0
	private float range; //Field offset: 0x0
	private List<T> inZone; //Field offset: 0x0
	private List<T> outZone; //Field offset: 0x0

	public List<T> InZone
	{
		 get { } //Length: 8
	}

	public Zoned`1() { }

	private void BehaviorCreated(T behavior) { }

	private void BehaviorDestroyed(T behavior) { }

	private bool Filter(T behavior) { }

	public List<T> get_InZone() { }

	private float GetRange() { }

	public void Initialise(GetRangeDelegate getRange, ForEachDelegate<T> enter, ForEachDelegate<T> exit, ViewFilter filter = null) { }

	private bool IsInZone(T behavior, float range) { }

	public bool IsInZone(Vector2 position) { }

	protected virtual void OnDestroy() { }

	protected virtual void Process(int elapsed) { }

	public void Run(ForEachDelegate<T> callback) { }

	public void SetRange(GetRangeDelegate range) { }

}

