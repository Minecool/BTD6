namespace Assets.Scripts.GameEditor.UI;

public class PropertyField : GraphPort
{
	[CompilerGenerated]
	private Action<String, Object> OnValueChanged; //Field offset: 0x48
	[CompilerGenerated]
	private Action<PropertyField> OnCreateGraphNodeRequested; //Field offset: 0x50
	[CompilerGenerated]
	private object <Metadata>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private bool <HasNonDefaultData>k__BackingField; //Field offset: 0x60

	public event Action<PropertyField> OnCreateGraphNodeRequested
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<String, Object> OnValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public private bool HasNonDefaultData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private object Metadata
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public PropertyField() { }

	[CompilerGenerated]
	public void add_OnCreateGraphNodeRequested(Action<PropertyField> value) { }

	[CompilerGenerated]
	public void add_OnValueChanged(Action<String, Object> value) { }

	[CompilerGenerated]
	public bool get_HasNonDefaultData() { }

	[CompilerGenerated]
	public object get_Metadata() { }

	public override void Initialise(GraphNode parentNode, GraphNodeModelDescriptorDef descriptor, object metadata, bool hasData) { }

	protected void RaiseGraphNodeCreateRequested() { }

	protected void RaiseValueChanged(object value) { }

	[CompilerGenerated]
	public void remove_OnCreateGraphNodeRequested(Action<PropertyField> value) { }

	[CompilerGenerated]
	public void remove_OnValueChanged(Action<String, Object> value) { }

	[CompilerGenerated]
	private void set_HasNonDefaultData(bool value) { }

	[CompilerGenerated]
	private void set_Metadata(object value) { }

	public void ToggleVisbileEmptyValues(bool show) { }

}

