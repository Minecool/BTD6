namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class MapItemVsProjectileBehavior : SimulationBehavior
{
	internal sealed class OnProjectileEnterDelegate : MulticastDelegate
	{

		public OnProjectileEnterDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnProjectileExitDelegate : MulticastDelegate
	{

		public OnProjectileExitDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public MapItemVsProjectileBehaviorModel mapItemVsProjectileBehaviorModel; //Field offset: 0x58
	[CompilerGenerated]
	private OnProjectileEnterDelegate OnProjectileEnter; //Field offset: 0x60
	[CompilerGenerated]
	private OnProjectileExitDelegate OnProjectileExit; //Field offset: 0x68
	private Entity collision; //Field offset: 0x70

	public event OnProjectileEnterDelegate OnProjectileEnter
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event OnProjectileExitDelegate OnProjectileExit
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public MapItemVsProjectileBehavior() { }

	[CompilerGenerated]
	public void add_OnProjectileEnter(OnProjectileEnterDelegate value) { }

	[CompilerGenerated]
	public void add_OnProjectileExit(OnProjectileExitDelegate value) { }

	private bool FilterProjectile(RootBehavior behavior) { }

	private float GetCollisionRadius() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnProjectileEnterZone(Projectile projectile) { }

	private void OnProjectileExitZone(Projectile projectile) { }

	[CompilerGenerated]
	public void remove_OnProjectileEnter(OnProjectileEnterDelegate value) { }

	[CompilerGenerated]
	public void remove_OnProjectileExit(OnProjectileExitDelegate value) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

