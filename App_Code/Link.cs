using Umbraco.Core.Models.PublishedContent;


public class ESOLink
{
    // Methods
    public ESOLink(){

    }

    // Properties
    public string LinkTitle { get;  set; } = "";
    public string LinkURL { get; set; } = "";
    public string LinkTarget { get; set; } = "";
    public string LinkIcon { get; set; } = "";
    public string LinkCaption { get; set; } = "";
    public IPublishedContent InternalNode { get; set; } 
    public UrlPickerTypes LinkType { get; set; } = UrlPickerTypes.Url;

    // Nested Types
    public enum UrlPickerTypes
    {
        Url,
        Content,
        Media
    }
}
