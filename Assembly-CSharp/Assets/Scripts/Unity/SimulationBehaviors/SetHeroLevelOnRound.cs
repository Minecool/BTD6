namespace Assets.Scripts.Unity.SimulationBehaviors;

public class SetHeroLevelOnRound : SimulationBehavior
{
	[TowerType]
	public string tower; //Field offset: 0x18
	public Int32[] round; //Field offset: 0x20
	public Int32[] level; //Field offset: 0x28

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 128
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public SetHeroLevelOnRound() { }

	public SetHeroLevelOnRound(Int32[] round, string tower, Int32[] level) { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

}

