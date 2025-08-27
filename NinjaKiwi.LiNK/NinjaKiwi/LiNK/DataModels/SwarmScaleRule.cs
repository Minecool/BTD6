namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class SwarmScaleRule
{
	[DataMember(Name = "annotationName", EmitDefaultValue = False)]
	public string annotationName; //Field offset: 0x10
	[DataMember(Name = "annotationValue", EmitDefaultValue = False)]
	public string annotationValue; //Field offset: 0x18

	public SwarmScaleRule() { }

}

