namespace Assets.Scripts.Data.Behaviors.Towers.GeraldoItems;

[CreateAssetMenu(fileName = "CreateEffectOnGeraldoItem", menuName = "BTD6/Behaviors/Towers/GeraldoItems/CreateEffectOnGeraldoItem")]
public class CreateEffectOnGeraldoItem : GeraldoItemBehavior
{
	public PrefabReference effect; //Field offset: 0x28
	public float lifespan; //Field offset: 0x30
	public bool fullScreen; //Field offset: 0x34
	public bool useCenterPosition; //Field offset: 0x35

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 169
	}

	public CreateEffectOnGeraldoItem() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

