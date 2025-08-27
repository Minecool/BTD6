namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateTypedTower", menuName = "BTD6/Behaviors/Projectiles/CreateTypedTower")]
public class CreateTypedTower : ProjectileBehavior
{
	public Tower crushingTower; //Field offset: 0x30
	public Tower boomTower; //Field offset: 0x38
	public Tower coldTower; //Field offset: 0x40
	public Tower energyTower; //Field offset: 0x48
	public PrefabReference crushingDisplay; //Field offset: 0x50
	public PrefabReference boomDisplay; //Field offset: 0x58
	public PrefabReference coldDisplay; //Field offset: 0x60
	public PrefabReference energyDisplay; //Field offset: 0x68

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 387
	}

	public CreateTypedTower() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

