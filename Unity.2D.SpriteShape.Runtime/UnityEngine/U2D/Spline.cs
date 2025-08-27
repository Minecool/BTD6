namespace UnityEngine.U2D;

public class Spline
{
	private static readonly string KErrorMessage; //Field offset: 0x0
	private static readonly float KEpsilon; //Field offset: 0x8
	[SerializeField]
	private bool m_IsOpenEnded; //Field offset: 0x10
	[SerializeField]
	private List<SplineControlPoint> m_ControlPoints; //Field offset: 0x18

	public bool isOpenEnded
	{
		 get { } //Length: 75
	}

	private static Spline() { }

	public Spline() { }

	public void Clear() { }

	public bool get_isOpenEnded() { }

	internal Corner GetCornerMode(int index) { }

	public virtual int GetHashCode() { }

	public float GetHeight(int index) { }

	public Vector3 GetLeftTangent(int index) { }

	public int GetPointCount() { }

	public Vector3 GetPosition(int index) { }

	public Vector3 GetRightTangent(int index) { }

	public int GetSpriteIndex(int index) { }

	public ShapeTangentMode GetTangentMode(int index) { }

	public void InsertPointAt(int index, Vector3 point) { }

	private bool IsPositionValid(int index, int next, Vector3 point) { }

	public void RemovePointAt(int index) { }

	internal void SetCornerMode(int index, Corner value) { }

	public void SetHeight(int index, float value) { }

	public void SetLeftTangent(int index, Vector3 tangent) { }

	public void SetPosition(int index, Vector3 point) { }

	public void SetRightTangent(int index, Vector3 tangent) { }

	public void SetTangentMode(int index, ShapeTangentMode mode) { }

}

