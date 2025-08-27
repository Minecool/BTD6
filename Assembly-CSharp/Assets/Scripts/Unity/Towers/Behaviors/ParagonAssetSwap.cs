namespace Assets.Scripts.Unity.Towers.Behaviors;

public class ParagonAssetSwap : TowerBehavior
{
	public GameObject displayToSwap; //Field offset: 0x98
	public GameObject newDisplay; //Field offset: 0xA0
	public int degree; //Field offset: 0xA8
	public string expDegree; //Field offset: 0xB0
	public bool applyToAllAbove; //Field offset: 0xB8
	public string expApplyToAllAbove; //Field offset: 0xC0
	private ParagonAssetSwapModel def; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 274
	}

	public ParagonAssetSwap() { }

	public virtual TowerBehaviorModel get_Def() { }

	private PrefabReference GetDisplayFilePath(GameObject obj) { }

}

