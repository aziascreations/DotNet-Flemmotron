using System.Xml.Linq;

namespace NibblePoker.Flemmotron.Commons.Interfaces;

public interface IExecutor {

    /*#region Properties

    public readonly List<Task> prerequisiteTasks;


    #endregion*/

    public IExecutor New();

    public XElement Serialize();
    
    public static abstract IExecutor Deserialize(XElement rootElement);
    
    public static abstract string GetId();
}
