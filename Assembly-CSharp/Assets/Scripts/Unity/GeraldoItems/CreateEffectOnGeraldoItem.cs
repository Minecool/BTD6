namespace Assets.Scripts.Unity.GeraldoItems;

public class CreateEffectOnGeraldoItem : GeraldoItemBehavior
{
	[SerializeField]
	private PrefabReference effect; //Field offset: 0x10
	[SerializeField]
	private float lifespan; //Field offset: 0x18
	[SerializeField]
	private bool fullScreen; //Field offset: 0x1C
	[SerializeField]
	private bool useCenterPosition; //Field offset: 0x1D

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 169
	}

	public CreateEffectOnGeraldoItem() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

