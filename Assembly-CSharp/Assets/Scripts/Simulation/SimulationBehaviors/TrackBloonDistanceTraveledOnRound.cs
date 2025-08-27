namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class TrackBloonDistanceTraveledOnRound : SimulationBehavior
{
	private const int RATE_LIMITER = 60; //Field offset: 0x0
	private TrackBloonDistanceTraveledOnRoundModel behaviorModel; //Field offset: 0x58
	private bool tracking; //Field offset: 0x60
	private String[] bloonTags; //Field offset: 0x68
	private String[] triggerIds; //Field offset: 0x70
	private float targetPercentTraveled; //Field offset: 0x78
	private int lastChecked; //Field offset: 0x7C

	public TrackBloonDistanceTraveledOnRound() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected bool IsBloonValid(Bloon bloon) { }

	public virtual void OnRoundStart(int roundArrayIndex) { }

	public void Process(int elapsed) { }

	private bool TrackBloonOnRound(int roundArrayIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

