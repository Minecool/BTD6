namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class BeastHandlerPet : TowerBehavior
{
	[CompilerGenerated]
	private sealed class <GetAdditionalDisplayMeshes>d__10 : IEnumerable<Mesh>, IEnumerable, IEnumerator<Mesh>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Mesh <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public BeastHandlerPet <>4__this; //Field offset: 0x28
		private TowerModel towerModel; //Field offset: 0x30
		public TowerModel <>3__towerModel; //Field offset: 0x38
		private Tower <owningBeastHandler>5__2; //Field offset: 0x40
		private IEnumerator<Tower> <>7__wrap2; //Field offset: 0x48

		private override Mesh System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Display.Mesh>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetAdditionalDisplayMeshes>d__10(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Mesh> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Display.Mesh>.GetEnumerator() { }

		[DebuggerHidden]
		private override Mesh System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Display.Mesh>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public BeastHandlerPetModel beastHandlerPetModel; //Field offset: 0x68
	private Tower parentTower; //Field offset: 0x70
	private BeastHandlerLeash parentTowerLeash; //Field offset: 0x78

	public BeastHandlerPet() { }

	[IteratorStateMachine(typeof(<GetAdditionalDisplayMeshes>d__10))]
	public virtual IEnumerable<Mesh> GetAdditionalDisplayMeshes(TowerModel towerModel, Vector3 position, bool isFromHover) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsPlacementValid() { }

	protected virtual void OnDestroy() { }

	public virtual void OnUpgrade(bool playEffect) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

