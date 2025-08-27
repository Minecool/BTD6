namespace Assets.Scripts.Unity.Map.Triggers;

public class ToggleSplitterAction : MapAction
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Path, String> <>9__5_0; //Field offset: 0x8
		public static Func<Path, String> <>9__5_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <get_Def>b__5_0(Path x) { }

		internal string <get_Def>b__5_1(Path x) { }

	}

	private ToggleSplitterActionModel toggleSplitterModel; //Field offset: 0x20
	public bool setActive; //Field offset: 0x28
	public Path[] pathsToActivate; //Field offset: 0x30
	public Path[] pathsToDeactivate; //Field offset: 0x38

	public virtual MapActionModel Def
	{
		 get { } //Length: 616
	}

	public ToggleSplitterAction() { }

	public virtual MapActionModel get_Def() { }

}

