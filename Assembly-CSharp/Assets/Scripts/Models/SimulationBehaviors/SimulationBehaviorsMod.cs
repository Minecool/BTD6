namespace Assets.Scripts.Models.SimulationBehaviors;

public class SimulationBehaviorsMod
{
	[CompilerGenerated]
	private sealed class <GetBehaviors>d__2 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public SimulationBehaviorsMod <>4__this; //Field offset: 0x0
		private SimulationBehavior[] <>7__wrap1; //Field offset: 0x0
		private int <>7__wrap2; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
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
		public <GetBehaviors>d__2`1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class CustomJsonConverter : JsonConverter
	{

		public virtual bool CanWrite
		{
			 get { } //Length: 3
		}

		public CustomJsonConverter`1() { }

		public virtual bool CanConvert(Type t) { }

		public virtual bool get_CanWrite() { }

		public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

		public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	}

	[SerializeReference]
	public SimulationBehavior[] simBehaviors; //Field offset: 0x10

	public SimulationBehaviorsMod(SimulationBehavior[] simBehaviors = null) { }

	[IteratorStateMachine(typeof(<GetBehaviors>d__2`1))]
	public IEnumerable<T> GetBehaviors() { }

}

