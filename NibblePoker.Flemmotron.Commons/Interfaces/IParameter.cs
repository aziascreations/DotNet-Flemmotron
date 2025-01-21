using System.Xml.Linq;

namespace NibblePoker.Flemmotron.Commons.Interfaces;

// TODO: Export most of the logic to IVariable and make the parameters use them to use the same logic for generics and parameter vars.
public interface IParameter : IDisposable {
    
    public void SetValues(IEnumerable<Object> rawValues);
    
    public IEnumerable<Object> GetValues();
}
