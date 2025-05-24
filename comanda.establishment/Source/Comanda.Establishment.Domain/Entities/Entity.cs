namespace Comanda.Establishment.Domain.Entities;

public abstract class Entity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public bool IsDeleted { get; private set; }

    public void MarkAsDeleted() => IsDeleted = true;
}