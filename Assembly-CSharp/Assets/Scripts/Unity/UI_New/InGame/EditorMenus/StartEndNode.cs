namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class StartEndNode : MonoBehaviour
{
	public GameObject pathNode; //Field offset: 0x20
	public GameObject arrowIn; //Field offset: 0x28
	public GameObject arrowOut; //Field offset: 0x30
	public GameObject selectedHighlight; //Field offset: 0x38
	public BoxCollider boxCollider; //Field offset: 0x40
	public GameObject pathPoint0; //Field offset: 0x48
	public GameObject pathPoint1; //Field offset: 0x50
	[CompilerGenerated]
	private bool <IsDisabled>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private bool <IsSelected>k__BackingField; //Field offset: 0x59
	private PathSelectNodes parentScript; //Field offset: 0x60

	public private bool IsDisabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsSelected
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public StartEndNode() { }

	public void AddListeners(PathSelectNodes parent) { }

	public void Awake() { }

	[CompilerGenerated]
	public bool get_IsDisabled() { }

	[CompilerGenerated]
	public bool get_IsSelected() { }

	public List<Vector3> GetPathNodePositions() { }

	private void OnMouseUp() { }

	private void OnTouchActionTestCollision() { }

	[CompilerGenerated]
	private void set_IsDisabled(bool value) { }

	[CompilerGenerated]
	private void set_IsSelected(bool value) { }

	private void SetSelected() { }

	public void TogglePathArrows(bool showInArrow, bool visible) { }

	public void ToggleVisibility(bool visible) { }

	private void Update() { }

}

