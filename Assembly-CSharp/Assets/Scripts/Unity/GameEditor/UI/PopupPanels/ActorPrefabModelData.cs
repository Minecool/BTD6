namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class ActorPrefabModelData : CustomPrefabModelData<Prop>, IGameEditorDisplayAsset
{
	internal class VariablesInfo
	{
		[SerializeField]
		public string name; //Field offset: 0x10
		[SerializeField]
		public ScriptableObject script; //Field offset: 0x18

		public VariablesInfo() { }

	}

	public List<VariablesInfo> variables; //Field offset: 0x50

	public override PrefabReference Display
	{
		 get { } //Length: 27
	}

	public ActorPrefabModelData() { }

	public static ActorPrefabModelData CreateActor() { }

	public override PrefabReference get_Display() { }

}

