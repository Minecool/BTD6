namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class TravelAlongPath : ProjectileBehavior
{
	internal sealed class OnPathChanged : MulticastDelegate
	{

		public OnPathChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Projectile projectile, Path previousPath, Path nextPath, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Projectile projectile, Path previousPath, Path nextPath) { }

	}

	public TravelAlongPathModel travelAlongPathModel; //Field offset: 0x68
	public float distanceTraveled; //Field offset: 0x70
	public Vector3 offsetPosition; //Field offset: 0x74
	public bool hasOffsetPosition; //Field offset: 0x80
	public float age; //Field offset: 0x84
	public Path path; //Field offset: 0x88
	public OnPathChanged OnPathChangedCallback; //Field offset: 0x90
	public float prevRot; //Field offset: 0x98

	public TravelAlongPath() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void SetTarget(Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

