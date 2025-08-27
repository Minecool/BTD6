namespace Assets.Scripts.Models.Store.Loot;

public class RacesPassLoot : BaseQuantityLoot
{
	[CompilerGenerated]
	private struct <Apply>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RacesPassLoot <>4__this; //Field offset: 0x28
		public LootFrom from; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public RacesPassLoot(int quantity) { }

	public RacesPassLoot(String[] param) { }

	public virtual bool AlwaysDisplayQuantity() { }

	[AsyncStateMachine(typeof(<Apply>d__2))]
	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual string GetMinDescription() { }

	public virtual string GetTitle() { }

}

