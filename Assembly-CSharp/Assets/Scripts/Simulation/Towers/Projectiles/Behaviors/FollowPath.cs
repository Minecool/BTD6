namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class FollowPath : ProjectileBehavior
{
	private static List<Vector3> points; //Field offset: 0x0
	private FollowPathModel followPathModel; //Field offset: 0x68
	private IPath easePath; //Field offset: 0x70
	private IPath path; //Field offset: 0x78
	[CompilerGenerated]
	private float <DistanceTravelled>k__BackingField; //Field offset: 0x80
	public bool useFlippedPath; //Field offset: 0x84

	public float DistanceTravelled
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	private static FollowPath() { }

	public FollowPath() { }

	[CompilerGenerated]
	public float get_DistanceTravelled() { }

	public float GetPathLength() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void ProcessFrame(int elapsed) { }

	[CompilerGenerated]
	public void set_DistanceTravelled(float value) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

