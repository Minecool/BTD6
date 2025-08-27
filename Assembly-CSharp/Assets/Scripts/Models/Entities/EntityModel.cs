namespace Assets.Scripts.Models.Entities;

public class EntityModel : Model
{
	[CompilerGenerated]
	private sealed class <GetActionsForEventModel>d__19 : IEnumerable<EntityActionModel>, IEnumerable, IEnumerator<EntityActionModel>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EntityActionModel <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public EntityModel <>4__this; //Field offset: 0x28
		private EntityEventModel eventModel; //Field offset: 0x30
		public EntityEventModel <>3__eventModel; //Field offset: 0x38
		private Model[] <>7__wrap1; //Field offset: 0x40
		private int <>7__wrap2; //Field offset: 0x48

		private override EntityActionModel System.Collections.Generic.IEnumerator<Assets.Scripts.Models.Entities.Events.EntityActionModel>.Current
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
		public <GetActionsForEventModel>d__19(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<EntityActionModel> System.Collections.Generic.IEnumerable<Assets.Scripts.Models.Entities.Events.EntityActionModel>.GetEnumerator() { }

		[DebuggerHidden]
		private override EntityActionModel System.Collections.Generic.IEnumerator<Assets.Scripts.Models.Entities.Events.EntityActionModel>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetTriggersForEventModel>d__18 : IEnumerable<EntityTriggerModel>, IEnumerable, IEnumerator<EntityTriggerModel>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EntityTriggerModel <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public EntityModel <>4__this; //Field offset: 0x28
		private EntityEventModel eventModel; //Field offset: 0x30
		public EntityEventModel <>3__eventModel; //Field offset: 0x38
		private Model[] <>7__wrap1; //Field offset: 0x40
		private int <>7__wrap2; //Field offset: 0x48

		private override EntityTriggerModel System.Collections.Generic.IEnumerator<Assets.Scripts.Models.Entities.Events.EntityTriggerModel>.Current
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
		public <GetTriggersForEventModel>d__18(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<EntityTriggerModel> System.Collections.Generic.IEnumerable<Assets.Scripts.Models.Entities.Events.EntityTriggerModel>.GetEnumerator() { }

		[DebuggerHidden]
		private override EntityTriggerModel System.Collections.Generic.IEnumerator<Assets.Scripts.Models.Entities.Events.EntityTriggerModel>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public string baseId; //Field offset: 0x30
	public PrefabReference display; //Field offset: 0x38
	public Model[] behaviors; //Field offset: 0x40
	public float radius; //Field offset: 0x48
	[CompilerGenerated]
	private float <RadiusSquared>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private bool <IsSubEntity>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly float <DisplayScale>k__BackingField; //Field offset: 0x54
	protected float cachedThrowMarkerHeight; //Field offset: 0x58

	public override float DisplayScale
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public override bool IsSubEntity
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public float RadiusSquared
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public EntityModel(string name, string baseId, PrefabReference display, Model[] behaviors = null, float radius = 6) { }

	public virtual Model[] BehaviorModels() { }

	public virtual Model Clone() { }

	[CompilerGenerated]
	public override float get_DisplayScale() { }

	[CompilerGenerated]
	public override bool get_IsSubEntity() { }

	[CompilerGenerated]
	public float get_RadiusSquared() { }

	[IteratorStateMachine(typeof(<GetActionsForEventModel>d__19))]
	public IEnumerable<EntityActionModel> GetActionsForEventModel(EntityEventModel eventModel) { }

	public override float GetPrimaryWeaponThrowMarkerHeight() { }

	[IteratorStateMachine(typeof(<GetTriggersForEventModel>d__18))]
	public IEnumerable<EntityTriggerModel> GetTriggersForEventModel(EntityEventModel eventModel) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	[CompilerGenerated]
	public override void set_IsSubEntity(bool value) { }

	[CompilerGenerated]
	public void set_RadiusSquared(float value) { }

	public virtual void SetBehaviorModels(Model[] behaviors) { }

}

