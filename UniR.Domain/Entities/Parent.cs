using UniR.Domain.Entities.Abstract;
using UniR.Domain.Entities.Baas;

namespace UniR.Domain.Entities;

public class Parent : Person
{
    public Guid Id { get; set; }
    
    public virtual ICollection<Student> Students { get; set; } = [];
}