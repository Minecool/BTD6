//Type is in global namespace

[ExecuteInEditMode]
public class MapLerp : MonoBehaviour
{
	[Range(0, 1)]
	public float lerp0102; //Field offset: 0x20
	[Range(0, 1)]
	public float lerp0203; //Field offset: 0x24
	[Range(0, 1)]
	public float lerp0301; //Field offset: 0x28

	public MapLerp() { }

	private void OnValidate() { }

	private void RefreshGlobalShaderVariables() { }

	private void Start() { }

}

