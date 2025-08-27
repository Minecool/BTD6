namespace Assets.Scripts.Unity.GeraldoItems;

public class CreateSoundOnGeraldoItem : GeraldoItemBehavior
{
	[SerializeField]
	private AudioClipReference sound; //Field offset: 0x10

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public CreateSoundOnGeraldoItem() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

