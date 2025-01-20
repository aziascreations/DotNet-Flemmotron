using System.Xml.Linq;
using NibblePoker.Flemmotron.Commons.Interfaces;

namespace NibblePoker.Flemmotron.Commons.Parameters;

public class StringParameter : IParameter {
    private string _name;
    private string _value;

    public StringParameter() : this(String.Empty) { }

    public StringParameter(string value) {
        this._value = value;
        this._name = Guid.NewGuid().ToString();
    }
    
    public void Dispose() { }

    public string GetName() {
        return this._name;
    }

    public void SetValue(object rawValue) {
        if(rawValue is not string value) {
            throw new Exception("Invalid type !");
        }
        this._value = value;
    }

    public void SetValues(IEnumerable<object> rawValues) {
        throw new NotImplementedException();
    }

    public object GetValue() {
        return this._value;
    }

    public IEnumerable<object> GetValues() {
        return new List<object>() { this.GetValue() };
    }

    public XElement Serialize() {
        return new XElement(GetId(), new XElement("Value", this._value));
    }

    public static IParameter Deserialize(XElement rootElement) {
        if(!rootElement.Name.ToString().Equals(GetId())) {
            throw new Exception($"Invalid root element '{rootElement.Name}' given to '{GetId()}' !");
        }
        return new StringParameter();
    }
    
    public static string GetId() {
        return "StringParameter";
    }
}
