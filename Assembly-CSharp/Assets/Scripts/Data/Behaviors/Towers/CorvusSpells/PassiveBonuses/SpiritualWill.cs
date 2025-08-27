namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.PassiveBonuses;

[CreateAssetMenu(fileName = "SpiritualWill", menuName = "BTD6/Behaviors/Towers/CorvusSpells/PassiveBonuses/SpiritualWill")]
public class SpiritualWill : TowerBehavior
{
	private SpiritualWillModel def; //Field offset: 0x30
	public int manaPerSecond; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 138
	}

	public SpiritualWill() { }

	public virtual TowerBehaviorModel get_Def() { }

}

