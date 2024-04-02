using prototype_design_pattern.Interfaces;

namespace prototype_design_pattern.Entities;

public class ArtificialIntelligence(string name) : IPrototype<ArtificialIntelligence>
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; } = name;

    public void ResetName(string name) => Name = name;

    public override string ToString() => $"Id: { Id } - Nome: { Name }";

    public ArtificialIntelligence Clone()
    {
        var clonedArtificialIntelligence = (ArtificialIntelligence)MemberwiseClone();
        
        clonedArtificialIntelligence.Id = Guid.NewGuid();
        
        return clonedArtificialIntelligence;
    }
}