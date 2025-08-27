namespace Assets.Scripts.Models.Towers;

public class SelectTargetCIData
{
	public PrefabReference targetImageId; //Field offset: 0x10
	public Vector3 targetImageScale; //Field offset: 0x18
	public string helperMessage; //Field offset: 0x28
	public int numberOfPoints; //Field offset: 0x30
	public Nullable<Vector2> previousTargetPosition; //Field offset: 0x34
	public float withinRange; //Field offset: 0x40
	public PrefabReference targetInvalidImageId; //Field offset: 0x48
	public float pathSegmentRange; //Field offset: 0x50
	public string withinBaseTowerId; //Field offset: 0x58
	public int withinBaseTowerTier; //Field offset: 0x60
	public int withinBaseTowerPath; //Field offset: 0x64
	public bool useBeastHandlerContribution; //Field offset: 0x68
	public bool clearOnInit; //Field offset: 0x69
	public bool fromTowerBehavior; //Field offset: 0x6A

	public SelectTargetCIData() { }

}

