namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class PathSplineNode : SplineNode
{
	public GameObject endNode; //Field offset: 0xA0
	public GameObject startNodeHighlightEffect; //Field offset: 0xA8
	public GameObject startSelectedIcon; //Field offset: 0xB0
	public GameObject endNodeHighlightEffect; //Field offset: 0xB8
	public GameObject endNodeSelectedIcon; //Field offset: 0xC0
	public GameObject moabInvulStartIcon; //Field offset: 0xC8
	public GameObject moabInvulEndIcon; //Field offset: 0xD0
	public GameObject bloonInvulStartIcon; //Field offset: 0xD8
	public GameObject bloonInvulEndIcon; //Field offset: 0xE0
	public GameObject moabScaleUpIcon; //Field offset: 0xE8
	public GameObject moabScaleDownIcon; //Field offset: 0xF0
	public GameObject bloonScaleUpIcon; //Field offset: 0xF8
	public GameObject bloonScaleDownIcon; //Field offset: 0x100
	public GameObject bloonsSpeedUpIcon; //Field offset: 0x108
	public GameObject bloonsSpeedDownIcon; //Field offset: 0x110
	private MapEditorPath mapEditorPath; //Field offset: 0x118
	[CompilerGenerated]
	private PathNodeSettings <NodeSettings>k__BackingField; //Field offset: 0x120

	public virtual bool CanDeleteNode
	{
		 get { } //Length: 8
	}

	public PathNodeSettings NodeSettings
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public PathSplineNode() { }

	public virtual bool get_CanDeleteNode() { }

	[CompilerGenerated]
	public PathNodeSettings get_NodeSettings() { }

	public virtual void Initialise(MapEditorSpriteShapeController spriteShapeController, int index, PathNode saveData = null) { }

	public bool IsConnectedToExitNode() { }

	protected virtual void OnDraggingEnded() { }

	protected virtual void OnDraggingTriggered() { }

	protected virtual void OnSplineChangedEvent(MapEditorSpriteShapeController spline) { }

	[CompilerGenerated]
	public void set_NodeSettings(PathNodeSettings value) { }

	protected virtual void Update() { }

	public void UpdateIconDisplays(PathSplineNode preceedingNode = null) { }

}

