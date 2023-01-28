namespace ComponentSandbox.Templates;

/* Currently just using the enum. The class may enter in later*/
public enum CardHeaderTemplateType
{
    Standard,
    Avatar,
    Custom
    
}
public class CardHeaderTemplate
{
    private CardHeaderTemplateType _type;
    
    public CardHeaderTemplate(CardHeaderTemplateType? type)
    {
        _type = type ?? throw new AggregateException(nameof(type));
    }

    public CardHeaderTemplateType Type
    {
        get => _type;
        set {
            if (_type != value)
            {
                _type = value;
            }
        }
    }
}