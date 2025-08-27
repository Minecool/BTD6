namespace Assets.Scripts.Unity;

public class DebugTowerGroupPlacer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public bool result; //Field offset: 0x10

		public <>c__DisplayClass30_0() { }

		internal void <PlaceInCircle>b__0(bool b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public bool result; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal void <PlaceInCrosspath>b__0(bool b) { }

	}

	private const float leniency = 0.01; //Field offset: 0x0
	private const int placeDelayFrames = 5; //Field offset: 0x0
	private const int maxCircleDepth = 4; //Field offset: 0x0
	private int currentTick; //Field offset: 0x10
	private bool isInCirclePlacement; //Field offset: 0x14
	private bool isInCrosspathPlacement; //Field offset: 0x15
	private int currentPosInCircle; //Field offset: 0x18
	private int currentCircleDepth; //Field offset: 0x1C
	private int timeOfLastCrosspathPlace; //Field offset: 0x20
	private int timeOfLastCirclePlace; //Field offset: 0x24
	private int currentTowerTiersIndex; //Field offset: 0x28
	private float lineXSpacing; //Field offset: 0x2C
	private float lineYSpacing; //Field offset: 0x30
	private float lineXOrigin; //Field offset: 0x34
	private float lineYOrigin; //Field offset: 0x38
	private float lineXEnd; //Field offset: 0x3C
	private float lineYEnd; //Field offset: 0x40
	private float currentXPos; //Field offset: 0x44
	private float currentYPos; //Field offset: 0x48
	private List<Int32[]> tiers; //Field offset: 0x50
	private TowerSelectionMenu towerSelectionMenu; //Field offset: 0x58
	private UnityToSimulation sim; //Field offset: 0x60
	private Vector3 circleOrigin; //Field offset: 0x68
	private TowerModel circleTowerModel; //Field offset: 0x78
	private TowerModel crosspathTowerModel; //Field offset: 0x80

	public DebugTowerGroupPlacer(TowerSelectionMenu towerSelectionMenu, UnityToSimulation sim) { }

	private bool DoesTierAlreadyExist(Int32[] toCompare) { }

	private void PlaceInCircle() { }

	private void PlaceInCrosspath() { }

	public void Process() { }

	public void Reset() { }

	private Vector2 Rotate(Vector2 vector2, float degrees) { }

	public void StartPlacingInCircle() { }

	public void StartPlacingInCrosspath() { }

}

