namespace Assets.Scripts.GameEditor.UI;

public class GraphNode : Draggable2DNode
{
	[CompilerGenerated]
	private List<GraphPort> <InputPorts>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private List<GraphPort> <OutputPorts>k__BackingField; //Field offset: 0x48
	public NK_TextMeshProUGUI titleTxt; //Field offset: 0x50
	public Button deleteBtn; //Field offset: 0x58
	public Transform scrollRect; //Field offset: 0x60
	public Transform graphPortContainerTransform; //Field offset: 0x68
	public Transform propertiesContainerTransform; //Field offset: 0x70
	[CompilerGenerated]
	private GraphNodeModelDescriptorDef <NodeDescriptor>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private Model <ModelData>k__BackingField; //Field offset: 0x80
	private Dictionary<String, PropertyField> properties; //Field offset: 0x88
	private Dictionary<Type, GraphPortContainer> portContainers; //Field offset: 0x90

	private GameEditorData GameEditorData
	{
		private get { } //Length: 71
	}

	private bool HasModelData
	{
		private get { } //Length: 12
	}

	public private List<GraphPort> InputPorts
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private Model ModelData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public string Name
	{
		 get { } //Length: 27
	}

	public private GraphNodeModelDescriptorDef NodeDescriptor
	{
		[CompilerGenerated]
		 get { } //Length: 70
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private List<GraphPort> OutputPorts
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public GraphNode() { }

	[CompilerGenerated]
	private void <Initialise>b__29_0() { }

	[CompilerGenerated]
	private void <OnCreateGraphNodeRequested>b__36_0(GraphPort property, GraphNodeModelDescriptorDef descriptor) { }

	private void AddGraphPortContainer(GraphNodeModelDescriptorDef contentsDescriptor) { }

	public void AddInputPort(GraphPort port) { }

	public void AddOutputPort(GraphPort port) { }

	private void AddPropertyField(ParameterInfo parameterInfo, Model modelDataToLoad = null) { }

	private void DisconnectAllPorts() { }

	private GameEditorData get_GameEditorData() { }

	private bool get_HasModelData() { }

	[CompilerGenerated]
	public List<GraphPort> get_InputPorts() { }

	[CompilerGenerated]
	public Model get_ModelData() { }

	public string get_Name() { }

	[CompilerGenerated]
	public GraphNodeModelDescriptorDef get_NodeDescriptor() { }

	[CompilerGenerated]
	public List<GraphPort> get_OutputPorts() { }

	private object GetModelValue(Model model, ParameterInfo parameterInfo, out bool foundData) { }

	public override void Initialise(GraphNodeModelDescriptorDef descriptor, Model modelData = null) { }

	private void OnCreateChildGraphNodeRequested(GraphNodeModelDescriptorDef descriptor, Transform transform) { }

	private GraphNode OnCreateGraphNodeForGraphPort(GraphPort graphPort, GraphNodeModelDescriptorDef selectedDescriptor) { }

	private void OnCreateGraphNodeRequested(GraphPort graphPort) { }

	public void OnDeleteClicked() { }

	private void OnPropertyValueChanged(string propertyName, object value) { }

	public void OnToggleVisibleUnassignedProperties(bool show) { }

	public void RemoveInputPort(GraphPort port) { }

	public void RemoveOutputPort(GraphPort port) { }

	[CompilerGenerated]
	private void set_InputPorts(List<GraphPort> value) { }

	[CompilerGenerated]
	private void set_ModelData(Model value) { }

	[CompilerGenerated]
	private void set_NodeDescriptor(GraphNodeModelDescriptorDef value) { }

	[CompilerGenerated]
	private void set_OutputPorts(List<GraphPort> value) { }

	private void UpdateModelProperty(string propertyName, object value) { }

}

