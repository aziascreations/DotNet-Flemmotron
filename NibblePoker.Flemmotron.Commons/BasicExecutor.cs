using System.Xml.Linq;
using NibblePoker.Flemmotron.Commons.Interfaces;

namespace NibblePoker.Flemmotron.Commons;

public class BasicExecutor : IExecutor {
    //private static const ID = "BasicExecutor";


    public IExecutor New() {
        return new BasicExecutor();
    }

    public XElement Serialize() {
        return new XElement(GetId());
    }

    public static IExecutor Deserialize(XElement rootElement) {
        if(!rootElement.Name.ToString().Equals(GetId())) {
            throw new Exception($"Invalid root element '{rootElement.Name}' given to '{GetId()}' !");
        }
        return new BasicExecutor();
    }

    public static string GetId() {
        return typeof(BasicExecutor).ToString();
    }
}
