namespace Assets.Scripts.Data.MapEditor;

[Extension]
public static class MapEditorItemTagEnum
{
	[CompilerGenerated]
	private sealed class <TagNames>d__9 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private MapEditorItemTag tag; //Field offset: 0x28
		public MapEditorItemTag <>3__tag; //Field offset: 0x30
		private MapEditorItemTag[] <values>5__2; //Field offset: 0x38
		private String[] <names>5__3; //Field offset: 0x40
		private int <i>5__4; //Field offset: 0x48

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <TagNames>d__9(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static String[] _names; //Field offset: 0x0
	private static MapEditorItemTag[] _values; //Field offset: 0x8
	public static MapEditorItemTag None; //Field offset: 0x10
	public static MapEditorItemTag All; //Field offset: 0x18

	public static String[] Names
	{
		 get { } //Length: 220
	}

	public static MapEditorItemTag[] Values
	{
		 get { } //Length: 298
	}

	private static MapEditorItemTagEnum() { }

	[Extension]
	public static bool ContainsFlag(MapEditorItemTag test, MapEditorItemTag flag) { }

	public static String[] get_Names() { }

	public static MapEditorItemTag[] get_Values() { }

	[Extension]
	[IteratorStateMachine(typeof(<TagNames>d__9))]
	public static IEnumerable<String> TagNames(MapEditorItemTag tag) { }

}

