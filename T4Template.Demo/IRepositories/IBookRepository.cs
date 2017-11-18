
 

using System;
using System.Data;
using T4Template.Demo.Models;  

namespace T4Template.Demo {
  public interface IBookRepository {

		Book GetById(int id);
        Book Create(Book model);
        Book Update(Book model);
        int Delete(Book model);
  }
 }

  
