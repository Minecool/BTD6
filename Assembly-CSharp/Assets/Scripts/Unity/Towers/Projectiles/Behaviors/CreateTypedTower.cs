namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateTypedTower : ProjectileBehavior
{
	public CreateTypedTower parent; //Field offset: 0x88
	public Tower crushingTower; //Field offset: 0x90
	public Tower expCrushingTower; //Field offset: 0x98
	public Tower boomTower; //Field offset: 0xA0
	public Tower expBoomTower; //Field offset: 0xA8
	public Tower coldTower; //Field offset: 0xB0
	public Tower expColdTower; //Field offset: 0xB8
	public Tower energyTower; //Field offset: 0xC0
	public Tower expEnergyTower; //Field offset: 0xC8
	public GameObject crushingDisplay; //Field offset: 0xD0
	public GameObject expCrushingDisplay; //Field offset: 0xD8
	public GameObject boomDisplay; //Field offset: 0xE0
	public GameObject expBoomDisplay; //Field offset: 0xE8
	public GameObject coldDisplay; //Field offset: 0xF0
	public GameObject expColdDisplay; //Field offset: 0xF8
	public GameObject energyDisplay; //Field offset: 0x100
	public GameObject expEnergyDisplay; //Field offset: 0x108

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 439
	}

	public CreateTypedTower() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

