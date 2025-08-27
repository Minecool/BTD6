namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class SyphonManaFromGraveyards : AbilityBehavior
{
	public SyphonManaFromGraveyards parent; //Field offset: 0x88
	public float percent; //Field offset: 0x90
	public string expPercent; //Field offset: 0x98

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 118
	}

	public SyphonManaFromGraveyards() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

