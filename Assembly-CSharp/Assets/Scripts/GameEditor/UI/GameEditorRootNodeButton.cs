namespace Assets.Scripts.GameEditor.UI;

public class GameEditorRootNodeButton : MonoBehaviour
{
	public Button addRootNode; //Field offset: 0x20
	public Image displayIcon; //Field offset: 0x28
	[CompilerGenerated]
	private GraphNodeModelDescriptorDef <ModelDescriptor>k__BackingField; //Field offset: 0x30

	private GraphNodeModelDescriptorDef ModelDescriptor
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public GameEditorRootNodeButton() { }

	[CompilerGenerated]
	private void <Initialise>b__6_0() { }

	[CompilerGenerated]
	private GraphNodeModelDescriptorDef get_ModelDescriptor() { }

	public void Initialise(GraphNodeModelDescriptorDef modelDescriptor) { }

	public void OnAddRootNodeClicked() { }

	[CompilerGenerated]
	private void set_ModelDescriptor(GraphNodeModelDescriptorDef value) { }

}

