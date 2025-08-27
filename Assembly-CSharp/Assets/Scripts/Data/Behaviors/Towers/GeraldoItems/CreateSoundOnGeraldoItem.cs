namespace Assets.Scripts.Data.Behaviors.Towers.GeraldoItems;

[CreateAssetMenu(fileName = "CreateSoundOnGeraldoItem", menuName = "BTD6/Behaviors/Towers/GeraldoItems/CreateSoundOnGeraldoItem")]
public class CreateSoundOnGeraldoItem : GeraldoItemBehavior
{
	public AudioClipReference sound; //Field offset: 0x28

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public CreateSoundOnGeraldoItem() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

