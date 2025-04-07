namespace DZA.Core.DomainObject;

public abstract class EntityBase
{
    public Guid Id { get; }

    protected EntityBase()
    => Id = Guid.NewGuid();

    public override bool Equals(object? obj)
    {
        var compareTo = obj as EntityBase;

        if(ReferenceEquals(this, compareTo)) return true;
        if(ReferenceEquals(null, compareTo)) return false;

        return Id.Equals(compareTo.Id);
    }
}