namespace UnityEngine.UI.Extensions;

[AddComponentMenu("Layout/Extensions/NonDrawingGraphic")]
public class NonDrawingGraphic : MaskableGraphic
{
	public bool enableConsoleNav; //Field offset: 0xE0

	public NonDrawingGraphic() { }

	protected virtual void Awake() { }

	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	public virtual void SetMaterialDirty() { }

	public virtual void SetVerticesDirty() { }

}

