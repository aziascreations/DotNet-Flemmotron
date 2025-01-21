namespace NibblePoker.Flemmotron.Commons.Interfaces;

public interface IVariable<T> : ISerializable<T> {
    public string GetName();

    public void SetValue(Object rawValue);
    
    public Object GetValue();
    
    public static abstract IVariable<T> GetBlank(string? name);
    
    // TODO: Handle the cloning, and blocking of cloning.
}
