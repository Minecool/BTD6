namespace UnityEngine.UIElements.UIR;

internal interface IMeshGenerator
{

	public VisualElement currentElement
	{
		 set { } //Length: 0
	}

	public TextJobSystem textJobSystem
	{
		 get { } //Length: 0
	}

	public void DrawBorder(BorderParams borderParams) { }

	public void DrawRectangle(RectangleParams rectParams) { }

	public void DrawRectangleRepeat(RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	public void DrawText(List<NativeSlice`1<Vertex>> vertices, List<NativeSlice`1<UInt16>> indices, List<Texture2D> atlases, List<GlyphRenderMode> renderModes, List<Single> sdfScales) { }

	public void DrawText(List<NativeSlice`1<Vertex>> vertices, List<NativeSlice`1<UInt16>> indices, List<Material> materials, List<GlyphRenderMode> renderModes) { }

	public TextJobSystem get_textJobSystem() { }

	public void ScheduleJobs(MeshGenerationContext mgc) { }

	public void set_currentElement(VisualElement value) { }

}

