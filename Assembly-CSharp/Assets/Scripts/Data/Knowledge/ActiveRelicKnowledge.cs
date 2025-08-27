namespace Assets.Scripts.Data.Knowledge;

public class ActiveRelicKnowledge
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<ContestedTerritoryRelicType, UInt16>, ContestedTerritoryRelicType> <>9__5_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<ContestedTerritoryRelicType, UInt16>, UInt16> <>9__5_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal ContestedTerritoryRelicType <Clone>b__5_0(KeyValuePair<ContestedTerritoryRelicType, UInt16> kvp) { }

		internal ushort <Clone>b__5_1(KeyValuePair<ContestedTerritoryRelicType, UInt16> kvp) { }

	}

	[CompilerGenerated]
	private sealed class <Get>d__7 : IEnumerable<ContestedTerritoryRelicType>, IEnumerable, IEnumerator<ContestedTerritoryRelicType>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ContestedTerritoryRelicType <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		private ActiveRelicKnowledge knowledges; //Field offset: 0x20
		public ActiveRelicKnowledge <>3__knowledges; //Field offset: 0x28
		private ContestedTerritoryRelicType[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private ContestedTerritoryRelicType <relicType>5__4; //Field offset: 0x3C
		private int <i>5__5; //Field offset: 0x40

		private override ContestedTerritoryRelicType System.Collections.Generic.IEnumerator<NinjaKiwi.GUTS.Models.CT.BTD6.ContestedTerritoryRelicType>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 67
		}

		[DebuggerHidden]
		public <Get>d__7(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<ContestedTerritoryRelicType> System.Collections.Generic.IEnumerable<NinjaKiwi.GUTS.Models.CT.BTD6.ContestedTerritoryRelicType>.GetEnumerator() { }

		[DebuggerHidden]
		private override ContestedTerritoryRelicType System.Collections.Generic.IEnumerator<NinjaKiwi.GUTS.Models.CT.BTD6.ContestedTerritoryRelicType>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public const ushort LatestVersion = 1; //Field offset: 0x0
	public ulong mask; //Field offset: 0x10
	public Dictionary<ContestedTerritoryRelicType, UInt16> counts; //Field offset: 0x18

	public static ActiveRelicKnowledge NoKnowledge
	{
		 get { } //Length: 68
	}

	public ActiveRelicKnowledge() { }

	public ActiveRelicKnowledge Clone() { }

	public static ActiveRelicKnowledge Get(IEnumerable<ContestedTerritoryRelicType> knowledges) { }

	[IteratorStateMachine(typeof(<Get>d__7))]
	public static IEnumerable<ContestedTerritoryRelicType> Get(ActiveRelicKnowledge knowledges) { }

	public static ActiveRelicKnowledge get_NoKnowledge() { }

	private int TypeCount(ContestedTerritoryRelicType relicType) { }

}

