using System.Xml.Linq;
using NibblePoker.Flemmotron.Commons.Interfaces;

namespace NibblePoker.Flemmotron.Basics.Executors;

public class MessageBoxExecutor : IExecutor {
    public XElement Serialize() {
        throw new NotImplementedException();
    }

    public static IExecutor Deserialize(XElement rootElement) {
        throw new NotImplementedException();
    }

    public static string GetId() {
        throw new NotImplementedException();
    }
}
