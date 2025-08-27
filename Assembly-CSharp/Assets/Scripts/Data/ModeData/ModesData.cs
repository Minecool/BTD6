namespace Assets.Scripts.Data.ModeData;

public class ModesData : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public SubGameType modeType; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <TryGetGameModeData>b__0(ModeData x) { }

	}

	internal class ModeDataContainer
	{
		public ModeData[] items; //Field offset: 0x10

		public ModeDataContainer() { }

	}

	[ReorderableList("items", True)]
	[SerializeField]
	private ModeDataContainer gameModes; //Field offset: 0x18

	public ModeData[] GameModes
	{
		 get { } //Length: 27
	}

	public ModesData() { }

	public ModeData[] get_GameModes() { }

	public bool TryGetGameModeData(SubGameType modeType, out ModeData modeData) { }

}

