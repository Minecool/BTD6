namespace Assets.Scripts.Unity.GeraldoItems;

public class JarOfPicklesBehavior : GeraldoItemBehavior
{
	[SerializeField]
	private float attackSpeedScale; //Field offset: 0x18
	[SerializeField]
	private int damageIncrease; //Field offset: 0x1C
	[SerializeField]
	private int rounds; //Field offset: 0x20
	[SerializeField]
	private PrefabReference buffDisplay; //Field offset: 0x28
	[SerializeField]
	private string buffLocsName; //Field offset: 0x30
	[SerializeField]
	private string buffIconName; //Field offset: 0x38
	[SerializeField]
	private PrefabReference effectAtTower; //Field offset: 0x40
	[SerializeField]
	private int bonusFortDamageAt; //Field offset: 0x48
	[SerializeField]
	private int bonusFortDamage; //Field offset: 0x4C
	[SerializeField]
	private int bonusFortDamageAtV2; //Field offset: 0x50
	[SerializeField]
	private int bonusFortDamageV2; //Field offset: 0x54

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 276
	}

	public JarOfPicklesBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

