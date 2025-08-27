namespace Assets.Scripts.Unity.Towers.Behaviors;

public class EnergisingTotemAnimState : TowerBehavior
{
	public EnergisingTotemAnimState parent; //Field offset: 0x98
	public int animState; //Field offset: 0xA0
	public string expAnimState; //Field offset: 0xA8
	public Effect effect; //Field offset: 0xB0
	public Effect expEffect; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 97
	}

	public EnergisingTotemAnimState() { }

	public virtual TowerBehaviorModel get_Def() { }

}

