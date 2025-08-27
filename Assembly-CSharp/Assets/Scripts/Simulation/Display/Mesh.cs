namespace Assets.Scripts.Simulation.Display;

public class Mesh
{
	public List<Int32> triangles; //Field offset: 0x10
	public List<Vector2> uvs; //Field offset: 0x18
	public List<Vector3> verticies; //Field offset: 0x20
	public Vector3 position; //Field offset: 0x28
	public bool isValid; //Field offset: 0x34
	public bool isAlwaysValid; //Field offset: 0x35
	public Action<Mesh> Released; //Field offset: 0x38

	public Mesh() { }

	public void Clear() { }

	public void Release() { }

}

