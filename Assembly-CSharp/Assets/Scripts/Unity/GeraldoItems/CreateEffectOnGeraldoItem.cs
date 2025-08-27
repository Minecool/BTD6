namespace Assets.Scripts.Unity.GeraldoItems;

public class CreateEffectOnGeraldoItem : GeraldoItemBehavior
{
	[SerializeField]
	private PrefabReference effect; //Field offset: 0x18
	[SerializeField]
	private float lifespan; //Field offset: 0x20
	[SerializeField]
	private bool fullScreen; //Field offset: 0x24
	[SerializeField]
	private bool useCenterPosition; //Field offset: 0x25

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 169
	}

	public CreateEffectOnGeraldoItem() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

