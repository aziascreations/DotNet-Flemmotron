using System.Xml.Linq;
using NibblePoker.Flemmotron.Commons.Interfaces;

namespace NibblePoker.Flemmotron.Basics.Executors;

public class MessageBoxExecutor : IExecutor<MessageBoxExecutor> {
    public XElement Serialize() {
        throw new NotImplementedException();
    }

    public static MessageBoxExecutor Deserialize(XElement rootElement) {
        throw new NotImplementedException();
    }

    public static string GetId() {
        throw new NotImplementedException();
    }

    public IExecutor<MessageBoxExecutor> GetBlank() {
        throw new NotImplementedException();
    }
}
