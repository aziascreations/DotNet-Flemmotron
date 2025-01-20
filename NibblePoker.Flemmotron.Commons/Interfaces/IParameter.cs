using System.Xml.Linq;

namespace NibblePoker.Flemmotron.Commons.Interfaces;

// TODO: Export most of the logic to IVariable and make the parameters use them to use the same logic for generics and parameter vars.
public interface IParameter : IDisposable {
    public string GetName();

    public void SetValue(Object rawValue);
    
    public void SetValues(IEnumerable<Object> rawValues);
    
    public Object GetValue();
    
    public IEnumerable<Object> GetValues();

    public XElement Serialize();
    
    public static abstract IParameter Deserialize(XElement rootElement);
    
    public static abstract string GetId();
}
