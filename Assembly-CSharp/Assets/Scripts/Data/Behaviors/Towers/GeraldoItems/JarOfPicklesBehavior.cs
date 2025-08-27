namespace Assets.Scripts.Data.Behaviors.Towers.GeraldoItems;

[CreateAssetMenu(fileName = "JarOfPicklesBehavior", menuName = "BTD6/Behaviors/Towers/GeraldoItems/JarOfPicklesBehavior")]
public class JarOfPicklesBehavior : GeraldoItemBehavior
{
	public float attackSpeedScale; //Field offset: 0x28
	public int damageIncrease; //Field offset: 0x2C
	public int rounds; //Field offset: 0x30
	public PrefabReference buffDisplay; //Field offset: 0x38
	public string buffLocsName; //Field offset: 0x40
	public string buffIconName; //Field offset: 0x48
	public PrefabReference effectAtTower; //Field offset: 0x50
	public int bonusFortDamageAt; //Field offset: 0x58
	public int bonusFortDamage; //Field offset: 0x5C
	public int bonusFortDamageAtV2; //Field offset: 0x60
	public int bonusFortDamageV2; //Field offset: 0x64

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 276
	}

	public JarOfPicklesBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

