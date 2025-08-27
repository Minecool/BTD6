namespace Assets.Scripts.Models.Towers;

public class DeployCIData
{
	public string helperMsg; //Field offset: 0x10
	public ObjectId towerId; //Field offset: 0x18
	public TowerModel towerModelToDeploy; //Field offset: 0x20
	public float withinRange; //Field offset: 0x28
	public string withinBaseTowerId; //Field offset: 0x30
	public int withinBaseTowerTier; //Field offset: 0x38
	public int withinBaseTowerPath; //Field offset: 0x3C
	public float withinCircleIntersectRange; //Field offset: 0x40
	public Vector2 towerPos; //Field offset: 0x44
	public bool useBeastHandlerContribution; //Field offset: 0x4C

	public DeployCIData() { }

}

