namespace Assets.Scripts.Data.Input;

public class SelectableMeshConfig : ScriptableObject
{
	[StrongReferenceAllowed]
	public Shader overObjectShader; //Field offset: 0x18
	[StrongReferenceAllowed]
	public Shader standardObjectShader; //Field offset: 0x20
	public float hoverScale; //Field offset: 0x28
	public float pressedScale; //Field offset: 0x2C

	public SelectableMeshConfig() { }

}

