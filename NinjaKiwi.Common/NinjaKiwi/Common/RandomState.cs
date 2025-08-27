namespace NinjaKiwi.Common;

[DataContract]
public struct RandomState
{
	[DataMember]
	public int inext; //Field offset: 0x0
	[DataMember]
	public int inextp; //Field offset: 0x4
	[DataMember]
	public Int32[] SeedArray; //Field offset: 0x8

}

