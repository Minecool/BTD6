namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class InstantDamageEmissionBehavior : EmissionBehavior
{
	public InstantDamageEmissionBehavior parent; //Field offset: 0x88

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public InstantDamageEmissionBehavior() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

