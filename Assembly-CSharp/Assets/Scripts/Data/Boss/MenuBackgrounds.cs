namespace Assets.Scripts.Data.Boss;

public class MenuBackgrounds : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public string menuName; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal bool <GetScreenBackground>b__0(ScreenBackground menu) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public string menuName; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <GetScreenBackgroundOverrides>b__0(OverrideScreenBackground menu) { }

	}

	[ReorderableList("items", True)]
	[SerializeField]
	private ScreenBackgroundContainer ScreenList; //Field offset: 0x18
	[ReorderableList("items", True)]
	[SerializeField]
	private OverrideBackgroundContainer OverrideList; //Field offset: 0x20

	public MenuBackgrounds() { }

	public ScreenBackground GetScreenBackground(string menuName) { }

	public IEnumerable<OverrideScreenBackground> GetScreenBackgroundOverrides(string menuName) { }

}

