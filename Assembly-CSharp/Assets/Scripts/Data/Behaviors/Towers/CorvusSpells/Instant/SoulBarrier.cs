namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.Instant;

[CreateAssetMenu(fileName = "SoulBarrier", menuName = "BTD6/Behaviors/Towers/CorvusSpells/Instant/SoulBarrier")]
public class SoulBarrier : CorvusInstantSpell
{
	public int manaPerLifeAbsorbed; //Field offset: 0x88
	public int maxLivesAbsorbed; //Field offset: 0x8C

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 652
	}

	public SoulBarrier() { }

	public virtual TowerBehaviorModel get_Def() { }

}

