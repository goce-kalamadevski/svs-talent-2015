using System;
[AttributeUsage(AttributeTargets.Class)]
public class AccountMetadataAttribute:Attribute
{
    public string AccountDescription
    {
        get;
        set;
    }
    public string AccountLimitations
    {
        get;
        set;
    }
}
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class FormatRestrictionAttribute:Attribute
{
    public string FormatString
    {
        get;
        set;
    }
    public int MaxLength
    {
        get;
        set;
    }
}