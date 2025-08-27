namespace Assets.Scripts.Unity.Map;

public abstract class AreaBuff : MonoBehaviour
{
	private BuffIndicatorModel buffIndicatorModel; //Field offset: 0x20
	private readonly string buffId; //Field offset: 0x28
	public string filterInTowerSets; //Field offset: 0x30
	public string mutatorId; //Field offset: 0x38
	public int priority; //Field offset: 0x40

	public override BuffIndicatorModel BuffIndicatorModel
	{
		 get { } //Length: 181
	}

	public abstract AreaBuffModel Def
	{
		 get { } //Length: 0
	}

	public AreaBuff(string buffId) { }

	public override BuffIndicatorModel get_BuffIndicatorModel() { }

	public abstract AreaBuffModel get_Def() { }

}

