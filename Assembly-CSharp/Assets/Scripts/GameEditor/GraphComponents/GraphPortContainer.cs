namespace Assets.Scripts.GameEditor.GraphComponents;

public class GraphPortContainer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Action<GraphNodeModelDescriptorDef, Transform> onAddPortClicked; //Field offset: 0x10
		public GraphNodeModelDescriptorDef contentsDescriptor; //Field offset: 0x18
		public GraphPortContainer <>4__this; //Field offset: 0x20

		public <>c__DisplayClass6_0() { }

		internal void <Initialize>b__0() { }

	}

	public Button addButton; //Field offset: 0x20
	public NK_TextMeshProUGUI addButtonTxt; //Field offset: 0x28
	public Transform portListContainer; //Field offset: 0x30
	private List<GraphPort> ports; //Field offset: 0x38
	private GraphNodeModelDescriptorDef contentsDescriptor; //Field offset: 0x40
	private Action<GraphNodeModelDescriptorDef, Transform> onAddPortClicked; //Field offset: 0x48

	public GraphPortContainer() { }

	public void AddPort(GraphPort port) { }

	public void Initialize(GraphNodeModelDescriptorDef contentsDescriptor, Action<GraphNodeModelDescriptorDef, Transform> onAddPortClicked) { }

}

