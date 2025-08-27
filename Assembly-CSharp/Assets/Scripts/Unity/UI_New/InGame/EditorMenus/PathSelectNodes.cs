namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class PathSelectNodes : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<StartEndNode, Boolean> <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_GetSelectedNode>b__4_0(StartEndNode n) { }

	}

	private List<StartEndNode> startEndNodes; //Field offset: 0x20
	public Action<StartEndNode> OnSelectedNodeEvent; //Field offset: 0x28

	public StartEndNode GetSelectedNode
	{
		 get { } //Length: 247
	}

	public IEnumerable<StartEndNode> StartEndNodes
	{
		 get { } //Length: 5
	}

	public PathSelectNodes() { }

	public void Awake() { }

	public StartEndNode get_GetSelectedNode() { }

	public IEnumerable<StartEndNode> get_StartEndNodes() { }

	public void ToggleArrowVisibility(bool showEntryArrows, bool visible) { }

	public void ToggleVisibility(bool visible) { }

}

