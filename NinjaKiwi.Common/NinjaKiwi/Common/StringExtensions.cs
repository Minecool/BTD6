namespace NinjaKiwi.Common;

[Extension]
public static class StringExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ParseSpanDelegate<String> <>9__11_0; //Field offset: 0x8
		public static ParseSpanDelegate<String> <>9__11_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <ToDictionary>b__11_0(ReadOnlySpan<Char> i) { }

		internal string <ToDictionary>b__11_1(ReadOnlySpan<Char> i) { }

	}

	[CompilerGenerated]
	private sealed class <CommaSeparatedListToStringEnumerable>d__5 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private string input; //Field offset: 0x28
		public string <>3__input; //Field offset: 0x30
		private bool removeWhiteSpace; //Field offset: 0x38
		public bool <>3__removeWhiteSpace; //Field offset: 0x39
		private ReadOnlyMemory<Char> <span>5__2; //Field offset: 0x40
		private int <nextCommaIndex>5__3; //Field offset: 0x50
		private bool <isLastLoop>5__4; //Field offset: 0x54

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
		public <CommaSeparatedListToStringEnumerable>d__5(int <>1__state) { }

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

	internal sealed class ParseSpanDelegate : MulticastDelegate
	{

		public ParseSpanDelegate`1(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ReadOnlySpan<Char> input, AsyncCallback callback, object object) { }

		public override T EndInvoke(IAsyncResult result) { }

		public override T Invoke(ReadOnlySpan<Char> input) { }

	}

	internal sealed class TryParseSpanDelegate : MulticastDelegate
	{

		public TryParseSpanDelegate`1(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ReadOnlySpan<Char> input, out T output, AsyncCallback callback, object object) { }

		public override bool EndInvoke(out T output, IAsyncResult result) { }

		public override bool Invoke(ReadOnlySpan<Char> input, out T output) { }

	}

	private const char comma = '\u2C'; //Field offset: 0x0
	private static readonly Dictionary<String, String[]> splitStrings; //Field offset: 0x0
	private const char kEntryDelimiter = '\u2C'; //Field offset: 0x0
	private const char kPairDelimiter = '\u3A'; //Field offset: 0x0

	private static StringExtensions() { }

	[Extension]
	[IteratorStateMachine(typeof(<CommaSeparatedListToStringEnumerable>d__5))]
	public static IEnumerable<String> CommaSeparatedListToStringEnumerable(string input, bool removeWhiteSpace = true) { }

	[Extension]
	public static String[] CommaSeperatedListToStringArray(string input, bool removeWhiteSpace = true, bool useCache = true) { }

	private static String[] CommaSeperatedListToStringArrayImpl(string input, bool removeWhiteSpace) { }

	[Extension]
	public static int CountCharsInString(string str, char chr) { }

	[Extension]
	public static T[] DelimitedListToArray(string input, TryParseSpanDelegate<T> tryParse, char delimiter, bool removeWhiteSpace = true) { }

	[Extension]
	public static string FromDictionary(Dictionary<TKey, TValue> dictionary, char entryDelimiter = ,, char pairDelimiter = :) { }

	[Extension]
	public static Dictionary<String, String> ToDictionary(string input, char entryDelimiter = ,, char pairDelimiter = :) { }

	[Extension]
	public static Dictionary<TKey, TValue> ToDictionary(string input, ParseSpanDelegate<TKey> keyParser, ParseSpanDelegate<TValue> valueParser, char entryDelimiter = ,, char pairDelimiter = :) { }

}

