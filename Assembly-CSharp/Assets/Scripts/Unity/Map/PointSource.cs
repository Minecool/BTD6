namespace Assets.Scripts.Unity.Map;

public class PointSource : MonoBehaviour
{

	public PointSource() { }

	public PointInfo CreatePointInfo(Transform childTransform, Vector3 position) { }

	public override List<PointInfo> GetPointInfo() { }

	public override IEnumerable<Vector3> GetPoints() { }

	public override Vector3[] GetPointsArray() { }

}

