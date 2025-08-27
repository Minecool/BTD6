namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "OrbitingTower", menuName = "BTD6/Behaviors/Towers/OrbitingTower")]
public class OrbitingTower : TowerBehavior
{
	public float rotationDegreesPerFrame; //Field offset: 0x30
	public float radius; //Field offset: 0x34
	public bool ignoreRotation; //Field offset: 0x38
	public float offsetHeight; //Field offset: 0x3C
	public bool dontUseParentOrigin; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 210
	}

	public OrbitingTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

