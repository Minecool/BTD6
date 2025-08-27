namespace Assets.Scripts.Simulation.Physics;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public class Bucket
{
	public readonly Vector2 centre; //Field offset: 0x0
	private float largestRadius; //Field offset: 0x0
	public int largestCellSpan; //Field offset: 0x0
	public List<T> collidables; //Field offset: 0x0

	public Bucket`1(Vector2 centre) { }

	public void Add(T obj) { }

	public void Clear() { }

}

