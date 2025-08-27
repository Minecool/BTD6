namespace Assets.Scripts.Unity.Towers.Behaviors;

public class BananaFarmerCamoBananas : TowerBehavior
{
	public BananaFarmerCamoBananas parent; //Field offset: 0x98
	public Weapon camoBananaWeapon; //Field offset: 0xA0
	public Weapon expCamoBananaWeapon; //Field offset: 0xA8
	public int camoBananaFarmCount; //Field offset: 0xB0
	public string expCamoBananaFarmCount; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 161
	}

	public BananaFarmerCamoBananas() { }

	public virtual TowerBehaviorModel get_Def() { }

}

