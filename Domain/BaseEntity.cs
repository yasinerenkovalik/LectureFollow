using System.Security.Cryptography;

namespace Domain;

public abstract class BaseEntity
{
    public int Id { get; set; }
  
    public bool Active { get; set; }
    
}