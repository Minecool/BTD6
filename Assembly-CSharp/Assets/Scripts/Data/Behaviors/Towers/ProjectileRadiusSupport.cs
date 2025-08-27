namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "ProjectileRadiusSupport", menuName = "BTD6/Behaviors/Towers/ProjectileRadiusSupport")]
public class ProjectileRadiusSupport : SupportBehavior
{
	public string filterTowers; //Field offset: 0x48
	public bool isUnique; //Field offset: 0x50
	public float multiplier; //Field offset: 0x54
	public string mutatorId; //Field offset: 0x58
	public bool isGlobal; //Field offset: 0x60

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 303
	}

	public ProjectileRadiusSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

