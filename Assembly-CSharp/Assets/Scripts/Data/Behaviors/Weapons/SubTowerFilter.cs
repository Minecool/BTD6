namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "SubTowerFilter", menuName = "BTD6/Behaviors/Weapons/SubTowerFilter")]
public class SubTowerFilter : WeaponBehavior
{
	public string baseSubTowerId; //Field offset: 0x30
	public float maxNumberOfSubTowers; //Field offset: 0x38
	public bool checkForPreExisting; //Field offset: 0x3C

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 147
	}

	public SubTowerFilter() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

