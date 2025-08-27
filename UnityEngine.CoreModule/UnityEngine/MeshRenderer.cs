namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/MeshRenderer.h")]
public class MeshRenderer : Renderer
{

	public Mesh additionalVertexStreams
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Mesh enlightenVertexStream
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int subMeshStartIndex
	{
		[NativeName("GetSubMeshStartIndex")]
		 get { } //Length: 51
	}

	public MeshRenderer() { }

	[RequiredByNativeCode]
	private void DontStripMeshRenderer() { }

	public Mesh get_additionalVertexStreams() { }

	public Mesh get_enlightenVertexStream() { }

	[NativeName("GetSubMeshStartIndex")]
	public int get_subMeshStartIndex() { }

	public void set_additionalVertexStreams(Mesh value) { }

	public void set_enlightenVertexStream(Mesh value) { }

}

