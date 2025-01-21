using System.Xml.Linq;
using NibblePoker.Flemmotron.Commons.Interfaces;

namespace NibblePoker.Flemmotron.Basics.Variables;

public class StringVariable : IVariable<StringVariable> {
    private readonly string name;
    private string value;

    internal StringVariable() : this(Guid.NewGuid().ToString()) { }
    
    internal StringVariable(string name) : this(name, String.Empty) {}
    
    internal StringVariable(string name, string value) {
        this.name = name;
        this.value = value;
    }
    
    public XElement Serialize() {
        return new XElement(GetId(),
            new XElement("Name", this.GetName()),
            new XElement("Value", this.GetValue())
        );
    }

    public static StringVariable Deserialize(XElement rootElement) {
        throw new NotImplementedException();
    }

    public static string GetId() {
        return "StringVariable";
    }

    public string GetName() {
        return this.name;
    }

    public void SetValue(object rawValue) {
        throw new NotImplementedException();
    }

    public object GetValue() {
        return this.value;
    }

    public static IVariable<StringVariable> GetBlank(string? name) {
        name ??= Guid.NewGuid().ToString();
        return new StringVariable(name);
    }
}
