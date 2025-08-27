namespace Assets.Scripts.Data.GameEditor;

[CreateAssetMenu(fileName = "ModelDescriptor", menuName = "BTD6/GameEditor-GraphNodeModelDescriptor", order = 1)]
public class GraphNodeModelDescriptor : ScriptableObject
{
	public string modelName; //Field offset: 0x18
	public string modelType; //Field offset: 0x20
	public string behaviorModelType; //Field offset: 0x28
	public string scriptableType; //Field offset: 0x30
	public string scriptableBehaviorType; //Field offset: 0x38
	public List<GraphNodeModelDescriptor> childModels; //Field offset: 0x40
	public SpriteReference icon; //Field offset: 0x48

	public GraphNodeModelDescriptorDef Def
	{
		 get { } //Length: 84
	}

	public GraphNodeModelDescriptor() { }

	public GraphNodeModelDescriptorDef get_Def() { }

}

