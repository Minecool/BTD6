namespace UnityEngine.Purchasing;

public class PayoutDefinition
{
	public const int MaxSubtypeLength = 64; //Field offset: 0x0
	public const int MaxDataLength = 1024; //Field offset: 0x0
	[SerializeField]
	private PayoutType m_Type; //Field offset: 0x10
	[SerializeField]
	private string m_Subtype; //Field offset: 0x18
	[SerializeField]
	private double m_Quantity; //Field offset: 0x20
	[SerializeField]
	private string m_Data; //Field offset: 0x28

	public PayoutDefinition() { }

}

