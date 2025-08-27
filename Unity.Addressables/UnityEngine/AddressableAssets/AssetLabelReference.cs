namespace UnityEngine.AddressableAssets;

public class AssetLabelReference : IKeyEvaluator
{
	[FormerlySerializedAs("m_labelString")]
	[SerializeField]
	private string m_LabelString; //Field offset: 0x10

	public string labelString
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public override object RuntimeKey
	{
		 get { } //Length: 75
	}

	public AssetLabelReference() { }

	public string get_labelString() { }

	public override object get_RuntimeKey() { }

	public virtual int GetHashCode() { }

	public override bool RuntimeKeyIsValid() { }

	public void set_labelString(string value) { }

}

