namespace NibblePoker.Flemmotron.Commons.Interfaces;

public interface IExecutor<T> : ISerializable<T> {

    /*#region Properties

    public readonly List<Task> prerequisiteTasks;


    #endregion*/

    public IExecutor<T> GetBlank();
}
