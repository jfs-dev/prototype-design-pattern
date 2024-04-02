namespace prototype_design_pattern.Interfaces;

public interface IPrototype<T> where T : class
{
    T Clone();
}