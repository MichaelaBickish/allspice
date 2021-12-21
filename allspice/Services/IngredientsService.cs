using System.Collections.Generic;
using allspice.Models;
using allspice.Repositories;

namespace allspice.Services
{
  public class IngredientsService
  {
     private readonly IngredientsRepository _repo;
    public IngredientsService(IngredientsRepository repo)
    {
      _repo = repo;
    }
    internal List<Ingredient> Get()
        {
          return _repo.Get();
        }
  }
}