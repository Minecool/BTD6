namespace Assets.Scripts.Unity.Towers.Behaviors;

public class EnergisingTotemBehavior : TowerBehavior
{
	public EnergisingTotemBehavior parent; //Field offset: 0x98
	public int rounds; //Field offset: 0xA0
	public string expRounds; //Field offset: 0xA8
	public int monkeyMonkeyCost; //Field offset: 0xB0
	public string expMonkeyMoneyCost; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 626
	}

	public EnergisingTotemBehavior() { }

	public Int32[] GatherAnimationStates() { }

	public EffectModel[] GatherEffectModels() { }

	public virtual TowerBehaviorModel get_Def() { }

}

