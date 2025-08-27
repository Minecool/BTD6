namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "DamageOverTimeZone", menuName = "BTD6/Behaviors/Towers/DamageOverTimeZone")]
public class DamageOverTimeZone : TowerBehavior
{
	public DamageOverTime behavior; //Field offset: 0x30
	public float range; //Field offset: 0x38
	public bool isGlobal; //Field offset: 0x3C
	public bool filterInvisible; //Field offset: 0x3D
	public bool onlyAffectOnscreen; //Field offset: 0x3E
	public string mutatorId; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 343
	}

	public DamageOverTimeZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

