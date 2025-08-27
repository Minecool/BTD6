namespace Assets.Scripts.Simulation.Track;

public class TrackArrow : CommonBehaviorProxy<IEntityBehavior>
{
	public TrackArrowModel trackArrowModel; //Field offset: 0x150
	private Path path; //Field offset: 0x158
	private Path exitPath; //Field offset: 0x160
	public float distTravelledFromStart; //Field offset: 0x168
	public float distToEnd; //Field offset: 0x16C
	public float distAlongPath; //Field offset: 0x170
	public float distToTravel; //Field offset: 0x174
	private DisplayBehavior displayBehavior; //Field offset: 0x178
	public List<RootBehavior> modelBehaviors; //Field offset: 0x180
	private bool endArrow; //Field offset: 0x188

	public TrackArrow() { }

	public void AttachToPath(Path pathIn, bool endArrow, float distanceToTravel = 120) { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	private void UpdateColour() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateTransform() { }

}

