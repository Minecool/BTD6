namespace Assets.Scripts.Data.MapEditor;

public class CustomMapValidationResult
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CustomMapInvalidationReason, Boolean> <>9__24_0; //Field offset: 0x8
		public static Func<MapEditorPathData, Boolean> <>9__25_18; //Field offset: 0x10
		public static Func<MapEditorPathData, Boolean> <>9__25_19; //Field offset: 0x18
		public static Func<MapEditorAreaData, Int32> <>9__25_20; //Field offset: 0x20
		public static Func<MapEditorAreaData, Boolean> <>9__25_21; //Field offset: 0x28
		public static Func<MapEditorStampData, Int32> <>9__25_22; //Field offset: 0x30
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"condition", "reason"}])]
		public static Func<ValueTuple`2<Func`1<Boolean>, CustomMapInvalidationReason>, Boolean> <>9__25_0; //Field offset: 0x38
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"condition", "reason"}])]
		public static Func<ValueTuple`2<Func`1<Boolean>, CustomMapInvalidationReason>, CustomMapInvalidationReason> <>9__25_1; //Field offset: 0x40
		public static Func<CustomMapInvalidationReason, String> <>9__28_0; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__24_0(CustomMapInvalidationReason reason) { }

		internal string <GetFormattedReasons>b__28_0(CustomMapInvalidationReason reason) { }

		internal bool <GetInvalidationReasons>b__25_0(ValueTuple<Func`1<Boolean>, CustomMapInvalidationReason> x) { }

		internal CustomMapInvalidationReason <GetInvalidationReasons>b__25_1(ValueTuple<Func`1<Boolean>, CustomMapInvalidationReason> x) { }

		internal bool <GetInvalidationReasons>b__25_18(MapEditorPathData x) { }

		internal bool <GetInvalidationReasons>b__25_19(MapEditorPathData x) { }

		internal int <GetInvalidationReasons>b__25_20(MapEditorAreaData x) { }

		internal bool <GetInvalidationReasons>b__25_21(MapEditorAreaData x) { }

		internal int <GetInvalidationReasons>b__25_22(MapEditorStampData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public CustomMapModel modelToCheck; //Field offset: 0x10
		public MapEditorSettings mapEditorSettings; //Field offset: 0x18
		public bool isPathSequenceValid; //Field offset: 0x20

		public <>c__DisplayClass25_0() { }

		internal bool <GetInvalidationReasons>b__10() { }

		internal bool <GetInvalidationReasons>b__11() { }

		internal bool <GetInvalidationReasons>b__12() { }

		internal bool <GetInvalidationReasons>b__13() { }

		internal bool <GetInvalidationReasons>b__14() { }

		internal bool <GetInvalidationReasons>b__15() { }

		internal bool <GetInvalidationReasons>b__16() { }

		internal bool <GetInvalidationReasons>b__17() { }

		internal bool <GetInvalidationReasons>b__2() { }

		internal bool <GetInvalidationReasons>b__3() { }

		internal bool <GetInvalidationReasons>b__4() { }

		internal bool <GetInvalidationReasons>b__5() { }

		internal bool <GetInvalidationReasons>b__6() { }

		internal bool <GetInvalidationReasons>b__7() { }

		internal bool <GetInvalidationReasons>b__8() { }

		internal bool <GetInvalidationReasons>b__9() { }

	}

	[CompilerGenerated]
	private bool <HasPathPattern>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<String> <PathPatternSequence>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private List<Int32> <PathPatternLengthPerRound>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly bool <IsValid>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly IReadOnlyCollection<CustomMapInvalidationReason> <InvalidationReasons>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly bool <IsPathValid>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly bool <IsPathSequenceValid>k__BackingField; //Field offset: 0x39

	public private bool HasPathPattern
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public IReadOnlyCollection<CustomMapInvalidationReason> InvalidationReasons
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool IsPathSequenceValid
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool IsPathValid
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool IsValid
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private List<Int32> PathPatternLengthPerRound
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private List<String> PathPatternSequence
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public CustomMapValidationResult(CustomMapModel modelToCheck) { }

	[CompilerGenerated]
	public bool get_HasPathPattern() { }

	[CompilerGenerated]
	public IReadOnlyCollection<CustomMapInvalidationReason> get_InvalidationReasons() { }

	[CompilerGenerated]
	public bool get_IsPathSequenceValid() { }

	[CompilerGenerated]
	public bool get_IsPathValid() { }

	[CompilerGenerated]
	public bool get_IsValid() { }

	[CompilerGenerated]
	public List<Int32> get_PathPatternLengthPerRound() { }

	[CompilerGenerated]
	public List<String> get_PathPatternSequence() { }

	public string GetEditorSandboxInvalidReasons() { }

	public string GetFormattedReasons() { }

	private CustomMapInvalidationReason[] GetInvalidationReasons(CustomMapModel modelToCheck) { }

	private bool GetIsPathSequenceValid(CustomMapModel modelToCheck) { }

	[CompilerGenerated]
	private void set_HasPathPattern(bool value) { }

	[CompilerGenerated]
	private void set_PathPatternLengthPerRound(List<Int32> value) { }

	[CompilerGenerated]
	private void set_PathPatternSequence(List<String> value) { }

}

