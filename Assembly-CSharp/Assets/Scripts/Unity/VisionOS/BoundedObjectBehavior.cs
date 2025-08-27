namespace Assets.Scripts.Unity.VisionOS;

public class BoundedObjectBehavior : MonoBehaviour
{
	[SerializeField]
	private float m_ToVel; //Field offset: 0x20
	[SerializeField]
	private float m_MaxVel; //Field offset: 0x24
	[SerializeField]
	private float m_MaxForce; //Field offset: 0x28
	[SerializeField]
	private float m_Gain; //Field offset: 0x2C
	[SerializeField]
	private float m_LerpReturnTime; //Field offset: 0x30
	[SerializeField]
	private float m_Delay; //Field offset: 0x34
	private Vector3 m_StartingPosition; //Field offset: 0x38
	private Vector3 m_StartingLerpPosition; //Field offset: 0x44
	private Transform m_Transform; //Field offset: 0x50
	private Rigidbody m_Rigidbody; //Field offset: 0x58
	private bool m_Selected; //Field offset: 0x60
	private bool m_StartingPositionSet; //Field offset: 0x61
	private bool m_Return; //Field offset: 0x62
	private float m_CurrentTime; //Field offset: 0x64
	private float m_DelayTime; //Field offset: 0x68

	public BoundedObjectBehavior() { }

	public void MoveWithPhysics(Vector3 worldPosition) { }

	public void Select(bool selected) { }

	private void Start() { }

	private void Update() { }

}

