namespace Assets.Scripts.Simulation.Bloons;

public class TrackArrowManager : RootBehavior
{
	private TrackArrowModel trackArrowModel; //Field offset: 0x58
	private bool isActive; //Field offset: 0x60
	private float timeUntilNextPulse; //Field offset: 0x64
	private float timeUntilNextArrow; //Field offset: 0x68
	private int subArrowIndex; //Field offset: 0x6C
	private List<Path> spawnPaths; //Field offset: 0x70
	private List<Path> leakPaths; //Field offset: 0x78
	private int roundCount; //Field offset: 0x80
	private int numOfArrows; //Field offset: 0x84
	private float trackArrowDistance; //Field offset: 0x88

	public TrackArrowManager() { }

	public void Activate(bool overrideUniqueRounds = false) { }

	private TrackArrow CreateArrow() { }

	public void Deactivate() { }

	private void EmitArrow(Path path, bool endArrow) { }

	public void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnRoundEnd(int round) { }

	private void OnRoundStart(int roundSpawned) { }

	private void Process(int elapsed) { }

}

