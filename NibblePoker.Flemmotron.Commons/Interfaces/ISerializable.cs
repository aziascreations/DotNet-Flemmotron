using System.Xml.Linq;

namespace NibblePoker.Flemmotron.Commons.Interfaces;

public interface ISerializable<T> {
    public XElement Serialize();
    
    public static abstract T Deserialize(XElement rootElement);

    public static abstract string GetId();
}
