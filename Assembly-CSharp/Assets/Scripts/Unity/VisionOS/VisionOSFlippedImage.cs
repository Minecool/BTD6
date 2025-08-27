namespace Assets.Scripts.Unity.VisionOS;

public class VisionOSFlippedImage : MonoBehaviour, IMeshModifier
{
	private static readonly FieldInfo kIndicesField; //Field offset: 0x0
	private Graphic _graphic; //Field offset: 0x20
	private bool _cachedShouldReverseWinding; //Field offset: 0x28

	private bool RequiresReverseWinding
	{
		private get { } //Length: 140
	}

	private bool ShouldReverseWinding
	{
		private get { } //Length: 138
	}

	private static VisionOSFlippedImage() { }

	public VisionOSFlippedImage() { }

	private void Awake() { }

	private bool get_RequiresReverseWinding() { }

	private bool get_ShouldReverseWinding() { }

	private static void ReverseWinding(VertexHelper verts) { }

	private override void UnityEngine.UI.IMeshModifier.ModifyMesh(Mesh mesh) { }

	private override void UnityEngine.UI.IMeshModifier.ModifyMesh(VertexHelper verts) { }

	private void Update() { }

}

